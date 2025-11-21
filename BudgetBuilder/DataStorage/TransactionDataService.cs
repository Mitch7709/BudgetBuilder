using System.Collections.ObjectModel;
using System.Text.Json;
using System.Text.Json.Serialization;
using BudgetBuilder.Models;

namespace BudgetBuilder.DataStorage
{
    public static class TransactionDataService
    {
        private static readonly string transactionPath =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "BudgetBuilder", "transactions.json");

        private static readonly JsonSerializerOptions _jsonOptions = new()
        {
            WriteIndented = true,
            AllowTrailingCommas = true,
            ReadCommentHandling = JsonCommentHandling.Skip,
            Converters = { new JsonStringEnumConverter() } // optional: serialize enums as strings
        };

        // Single, global, live collection for the entire app
        private static readonly ObservableCollection<Transaction> _transactions = new();

        // Prevent accidental re-loads overwriting in-memory changes
        private static bool _isLoaded;

        #region File Operations
        public static void Save()
        {
            Directory.CreateDirectory(Path.GetDirectoryName(transactionPath)!);

            // Write to a temp file and move over the original to reduce corruption risk
            var tempPath = transactionPath + ".tmp";
            using (var fs = File.Create(tempPath))
            {
                JsonSerializer.Serialize(fs, _transactions, _jsonOptions);
                fs.Flush(true);
            }

            File.Move(tempPath, transactionPath, overwrite: true);
        }

        // Loads once and returns the live collection reference
        public static ObservableCollection<Transaction> Load()
        {
            if (_isLoaded)
                return _transactions;

            try
            {
                if (File.Exists(transactionPath))
                {
                    using var fs = File.OpenRead(transactionPath);
                    var items = JsonSerializer.Deserialize<List<Transaction>>(fs, _jsonOptions);
                    if (items is not null)
                    {
                        _transactions.Clear();
                        foreach (var t in items)
                            _transactions.Add(t);
                    }
                }
                _isLoaded = true;
            }
            catch (Exception)
            {
                // Swallow or log as appropriate; start with an empty collection on error
                _transactions.Clear();
                _isLoaded = true;
            }

            return _transactions;
        }
        #endregion

        public static ObservableCollection<Transaction> GetTransactions() => _transactions;

        public static ObservableCollection<string> GetTransactionCategories()
        {
            var categories = _transactions
                .Select(t => t.Category)
                .Where(c => !string.IsNullOrWhiteSpace(c))
                .Distinct()
                .OrderBy(c => c)
                .ToList();

            return new ObservableCollection<string>(categories);
        }

        public static void AddTransaction(Transaction transaction) => _transactions.Add(transaction);

        public static void UpdateTransaction(int index, Transaction updatedTransaction)
        {
            if (index >= 0 && index < _transactions.Count)
                _transactions[index] = updatedTransaction;
        }

        public static void DeleteTransaction(int index)
        {
            if (index >= 0 && index < _transactions.Count)
                _transactions.RemoveAt(index);
        }
    }
}
