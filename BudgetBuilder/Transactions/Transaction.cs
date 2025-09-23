using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetBuilder.Transactions
{
    public class Transaction
    {
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
        public string Category { get; set; }
        public TransactionType Type { get; set; }
        public Transaction(DateTime date, string description, double amount, string category, TransactionType type)
        {
            Date = date;
            Description = description;
            Amount = amount;
            Category = category;
            Type = type;
        }

        public enum TransactionType
        {
            Income,
            Expense
        }
    }
}
