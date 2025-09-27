using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetBuilder.Transactions
{
    public static class TransactionDataService
    {
        public static List<Transaction> transactions = new List<Transaction>()
        {
            new Transaction(new DateTime(2025, 1, 5), "Grocery Store", 150.75, "Food", Transaction.TransactionType.Expense),
            new Transaction(new DateTime(2025, 1, 10), "Salary", 3000.00, "Income", Transaction.TransactionType.Income),
            new Transaction(new DateTime(2025, 1, 15), "Electric Bill", 75.50, "Utilities", Transaction.TransactionType.Expense),
            new Transaction(new DateTime(2025, 9, 20), "Restaurant", 60.00, "Food", Transaction.TransactionType.Expense),
            new Transaction(new DateTime(2025, 9, 25), "Freelance Project", 500.00, "Income", Transaction.TransactionType.Income),
            new Transaction(new DateTime(2025, 9, 28), "Internet Bill", 45.00, "Utilities", Transaction.TransactionType.Expense),
            new Transaction(new DateTime(2025, 2, 3), "Grocery Store", 130.20, "Food", Transaction.TransactionType.Expense),
            new Transaction(new DateTime(2025, 2, 10), "Salary", 3000.00, "Income", Transaction.TransactionType.Income),
            new Transaction(new DateTime(2025, 3, 14), "Valentine's Gift", 80.00, "Gifts", Transaction.TransactionType.Expense),
            new Transaction(new DateTime(2025, 4, 18), "Electric Bill", 70.25, "Utilities", Transaction.TransactionType.Expense),
            new Transaction(new DateTime(2025, 4, 22), "Restaurant", 55.00, "Food", Transaction.TransactionType.Expense),
            new Transaction(new DateTime(2025, 5, 27), "Freelance Project", 600.00, "Income", Transaction.TransactionType.Income),
            new Transaction(new DateTime(2025, 7, 29), "Internet Bill", 50.00, "Utilities", Transaction.TransactionType.Expense)
        };

        public static ObservableCollection<Transaction> GetTransactions()
        {
            return new ObservableCollection<Transaction>(transactions);
        }

        public static ObservableCollection<Transaction> GetTransactionsByMonth(int month, int year)
        {
            var filtered = transactions.Where(t => t.Date.Month == month && t.Date.Year == year);
            return new ObservableCollection<Transaction>(filtered);
        }

        public static ObservableCollection<string> GetTransactionCategories()
        {
            var categories = transactions.Select(t => t.Category).Distinct().ToList();
            return new ObservableCollection<string>(categories);
        }

        public static void AddTransaction(Transaction transaction)
        {
            transactions.Add(transaction);
        }

        public static void UpdateTransaction(int index, Transaction updatedTransaction)
        {
            if (index >= 0 && index < transactions.Count)
            {
                transactions[index] = updatedTransaction;
            }
        }
    }
}
