using System.Collections.ObjectModel;
using System.Text.Json;
using System.Text.Json.Serialization;
using BudgetBuilder.Models;

namespace BudgetBuilder.DataStorage
{
    public static class TransactionDataService
    {
        private static readonly string budgetPath =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "BudgetBuilder", "budget.json");

        private static readonly JsonSerializerOptions _jsonOptions = new()
        {
            WriteIndented = true,
            AllowTrailingCommas = true,
            ReadCommentHandling = JsonCommentHandling.Skip,
            Converters = { new JsonStringEnumConverter() } // optional: serialize enums as strings
        };

        // Single, global, live collection for the entire app
        private static readonly TotalBudget _totalBudget = new();

        // Prevent accidental re-loads overwriting in-memory changes
        private static bool _isLoaded;

        #region File Operations
        public static void Save()
        {
            Directory.CreateDirectory(Path.GetDirectoryName(budgetPath)!);

            // Write to a temp file and move over the original to reduce corruption risk
            var tempPath = budgetPath + ".tmp";
            using (var fs = File.Create(tempPath))
            {
                JsonSerializer.Serialize(fs, _totalBudget, _jsonOptions);
                fs.Flush(true);
            }

            File.Move(tempPath, budgetPath, overwrite: true);
        }

        // Loads once and returns the live collection reference
        public static TotalBudget Load()
        {
            if (_isLoaded)
                return _totalBudget;

            try
            {
                if (File.Exists(budgetPath))
                {
                    using var fs = File.OpenRead(budgetPath);
                    var items = JsonSerializer.Deserialize<TotalBudget>(fs, _jsonOptions);
                    if (items is not null)
                    {
                        _totalBudget.Transactions.Clear();
                        foreach (var t in items.Transactions)
                            _totalBudget.Transactions.Add(t);

                        _totalBudget.Estimates.Clear();
                        foreach (var e in items.Estimates)
                            _totalBudget.Estimates.Add(e);

                        _totalBudget.AnnualTransactions.Clear();
                        foreach (var a in items.AnnualTransactions)
                            _totalBudget.AnnualTransactions.Add(a);
                    }
                }
                _isLoaded = true;
            }
            catch (Exception)
            {
                // Swallow or log as appropriate; start with an empty collection on error
                _totalBudget.Transactions.Clear();
                _totalBudget.Estimates.Clear();
                _totalBudget.AnnualTransactions.Clear();
                _isLoaded = true;
            }

            return _totalBudget;
        }

        public static void ClearData()
        {
            _totalBudget.Transactions.Clear();
            _totalBudget.Estimates.Clear();
            _totalBudget.AnnualTransactions.Clear();

            if (File.Exists(budgetPath))
            {
                File.Delete(budgetPath);
            }
        }
        #endregion

        public static ObservableCollection<Transaction> GetTransactions()
        {
            return _totalBudget.Transactions;
        }

        public static ObservableCollection<string> GetCategories()
        {
            var categories = _totalBudget.Estimates
                .Select(e => e.Name)
                .Distinct()
                .OrderBy(c => c)
                .ToList();

            return new ObservableCollection<string>(categories);
        }

        public static ObservableCollection<Estimate> GetEstimates()
        {
            return _totalBudget.Estimates;
        }

        #region Transaction Operations

        public static void AddTransaction(Transaction transaction) => _totalBudget.Transactions.Add(transaction);

        public static void UpdateTransaction(int index, Transaction updatedTransaction)
        {
            if (index >= 0 && index < _totalBudget.Transactions.Count)
                _totalBudget.Transactions[index] = updatedTransaction;
        }

        public static void DeleteTransaction(int index)
        {
            if (index >= 0 && index < _totalBudget.Transactions.Count)
                _totalBudget.Transactions.RemoveAt(index);
        }

        #endregion

        #region Estimate Operations
        public static void AddEstimate(Estimate estimate) => _totalBudget.Estimates.Add(estimate);

        public static void DeleteEstimate(int id)
        {
            var estimate = _totalBudget.Estimates.FirstOrDefault(e => e.Id == id);
            if (estimate != null)
                _totalBudget.Estimates.Remove(estimate);
        }
        #endregion

        #region Annual Transaction Operations
        public static void AddAnnualTransaction(AnnualTransaction annualTransaction) => _totalBudget.AnnualTransactions.Add(annualTransaction);

        public static void UpdateAnnualTransaction(int index, AnnualTransaction updatedAnnualTransaction)
        {
            if (index >= 0 && index < _totalBudget.AnnualTransactions.Count)
                _totalBudget.AnnualTransactions[index] = updatedAnnualTransaction;
        }
        public static void DeleteAnnualTransaction(int index)
        {
            if (index >= 0 && index < _totalBudget.AnnualTransactions.Count)
                _totalBudget.AnnualTransactions.RemoveAt(index);
        }
        #endregion
    }
}
