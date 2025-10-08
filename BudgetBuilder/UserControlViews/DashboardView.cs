using BudgetBuilder.Transactions;
using System.Collections.ObjectModel;
using static BudgetBuilder.Transactions.Transaction;

namespace BudgetBuilder.UserControlViews
{
    public partial class DashboardView : UserControl
    {
        private readonly ObservableCollection<Transaction> _transactions = new ObservableCollection<Transaction>();

        private readonly double _incomeTotal = 0;
        private readonly double _expenseTotal = 0;
        private readonly double _balanceTotal = 0;

        public DashboardView(int selectedMonth, ObservableCollection<Transaction> transactions)
        {
            _transactions = transactions;
            var transactionsForMonth = _transactions.Where(t => t.Date.Month == selectedMonth && t.Date.Year == DateTime.Now.Year).ToList();

            _incomeTotal = transactionsForMonth.Where(t => t.Type == TransactionType.Income).Sum(t => t.Amount);
            _expenseTotal = transactionsForMonth.Where(t => t.Type == TransactionType.Expense).Sum(t => t.Amount);
            _balanceTotal = _incomeTotal - _expenseTotal;

            InitializeComponent();

            incomelbl.Text = $"Total Income: ${_incomeTotal}";
            expenselbl.Text = $"Total Expenses: ${_expenseTotal}";
            balancelbl.Text = $"Balance: ${_balanceTotal}";
        }
    }
}
