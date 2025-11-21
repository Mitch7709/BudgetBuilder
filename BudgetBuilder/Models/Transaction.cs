using System.ComponentModel;
using BudgetBuilder.Enums;

namespace BudgetBuilder.Models
{
    public class Transaction
    {
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public string Category { get; set; }
        public TransactionType Type { get; set; }

        public Transaction(DateTime date, string description, decimal amount, string category, TransactionType type)
        {
            Date = date;
            Description = description;
            Amount = amount;
            Category = category;
            Type = type;
        }

        public string ValidateFields()
        {    
            if (string.IsNullOrWhiteSpace(Description))
                return "Description cannot be empty.";
            if (Amount <= 0)
                return "Amount must be greater than zero.";
            if (string.IsNullOrWhiteSpace(Category))
                return "Category cannot be empty.";
            return string.Empty; // No validation errors
        }
    }
}
