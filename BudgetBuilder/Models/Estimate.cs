using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetBuilder.Models
{
    public class Estimate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }

        public Estimate(int id, string name, decimal amount)
        {
            Id = id;
            Name = name;
            Amount = amount;
        }
    }
}
