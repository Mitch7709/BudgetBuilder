using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetBuilder.Models
{
    public class TotalBudget
    {
        public ObservableCollection<Transaction> Transactions { get; set; }
        public ObservableCollection<Estimate> Estimates { get; set; }
        public ObservableCollection<AnnualTransaction> AnnualTransactions { get; set; }

        public TotalBudget()
        {
            Transactions = new ObservableCollection<Transaction>();
            Estimates = new ObservableCollection<Estimate>();
            AnnualTransactions = new ObservableCollection<AnnualTransaction>();
        }
    }
}
