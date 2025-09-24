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
            new Transaction(new DateTime(2024, 1, 5), "Grocery Store", -150.75, "Food", Transaction.TransactionType.Expense),
            new Transaction(new DateTime(2024, 1, 10), "Salary", 3000.00, "Income", Transaction.TransactionType.Income),
            new Transaction(new DateTime(2024, 1, 15), "Electric Bill", -75.50, "Utilities", Transaction.TransactionType.Expense),
            new Transaction(new DateTime(2024, 1, 20), "Restaurant", -60.00, "Food", Transaction.TransactionType.Expense),
            new Transaction(new DateTime(2024, 1, 25), "Freelance Project", 500.00, "Income", Transaction.TransactionType.Income),
            new Transaction(new DateTime(2024, 1, 28), "Internet Bill", -45.00, "Utilities", Transaction.TransactionType.Expense),
            new Transaction(new DateTime(2024, 2, 3), "Grocery Store", -130.20, "Food", Transaction.TransactionType.Expense),
            new Transaction(new DateTime(2024, 2, 10), "Salary", 3000.00, "Income", Transaction.TransactionType.Income),
            new Transaction(new DateTime(2024, 2, 14), "Valentine's Gift", -80.00, "Gifts", Transaction.TransactionType.Expense),
            new Transaction(new DateTime(2024, 2, 18), "Electric Bill", -70.25, "Utilities", Transaction.TransactionType.Expense),
            new Transaction(new DateTime(2024, 2, 22), "Restaurant", -55.00, "Food", Transaction.TransactionType.Expense),
            new Transaction(new DateTime(2024, 2, 27), "Freelance Project", 600.00, "Income", Transaction.TransactionType.Income),
            new Transaction(new DateTime(2024, 2, 29), "Internet Bill", -50.00, "Utilities", Transaction.TransactionType.Expense)
        };

        public static ObservableCollection<Transaction> GetTransactions()
        {
            return new ObservableCollection<Transaction>(transactions);
        }

        public static ObservableCollection<Transaction> GetFilteredTransactions(string category, DateTime? startDate, DateTime? endDate)
        {
            var filtered = transactions.AsEnumerable();
            if (!string.IsNullOrWhiteSpace(category) && category != "Category")
            {
                filtered = filtered.Where(t => t.Category.Equals(category, StringComparison.OrdinalIgnoreCase));
            }
            if (startDate.HasValue)
            {
                filtered = filtered.Where(t => t.Date >= startDate.Value);
            }
            if (endDate.HasValue)
            {
                filtered = filtered.Where(t => t.Date <= endDate.Value);
            }
            return new ObservableCollection<Transaction>(filtered);
        }
    }
}
