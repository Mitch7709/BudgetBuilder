using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetBuilder.Models
{
    public class AnnualTransactions
    {
        public string Description { get; set; }
        public decimal Amount { get; set; }

        public AnnualTransactions(string description, decimal amount)
        {
            Description = description;
            Amount = amount;
        }

        public decimal GetMonthlyAmount()
        {
            return Amount / 12;
        }
    }
}
