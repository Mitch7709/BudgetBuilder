using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetBuilder.Models
{
    public class Estimate
    {
        public string Name { get; set; }
        public decimal Amount { get; set; }

        public Estimate(string name, decimal amount)
        {
            Name = name;
            Amount = amount;
        }
    }
}
