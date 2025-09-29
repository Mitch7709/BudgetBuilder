using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BudgetBuilder.Transactions
{
    public static class TransactionDataService
    {
        private static readonly string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "BudgetBuilder", "transactions.json");

        public static List<Transaction> transactions = new List<Transaction>();

        #region File Operations
        public static void Save(ObservableCollection<Transaction> transactions)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(filePath)!);

            var json = JsonSerializer.Serialize(transactions, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public static ObservableCollection<Transaction> Load()
        {
            if (!File.Exists(filePath))
                return new ObservableCollection<Transaction>();

            var json = File.ReadAllText(filePath);

            transactions = JsonSerializer.Deserialize<List<Transaction>>(json) ?? transactions;
            return new ObservableCollection<Transaction>(transactions);
        }
        #endregion

        public static ObservableCollection<Transaction> GetTransactions()
        {
            return new ObservableCollection<Transaction>(transactions);
        }

        public static ObservableCollection<string> GetTransactionCategories()
        {
            var categories = transactions.Select(t => t.Category).Distinct().ToList();
            return new ObservableCollection<string>(categories);
        }

        public static void AddTransaction(Transaction transaction)
        {
            transactions.Add(transaction);
            Save(new ObservableCollection<Transaction>(transactions));
        }

        public static void UpdateTransaction(int index, Transaction updatedTransaction)
        {
            if (index >= 0 && index < transactions.Count)
            {
                transactions[index] = updatedTransaction;
                Save(new ObservableCollection<Transaction>(transactions));
            }
        }
    }
}
