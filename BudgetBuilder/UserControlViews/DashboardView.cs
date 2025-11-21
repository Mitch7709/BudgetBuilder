using BudgetBuilder.DataStorage;
using BudgetBuilder.Enums;
using BudgetBuilder.Models;
using System.Collections.ObjectModel;

namespace BudgetBuilder.UserControlViews
{
    public partial class DashboardView : UserControl
    {
        private readonly ObservableCollection<Transaction> _transactions;

        private decimal _incomeTotal;
        private decimal _expenseTotal;
        private decimal _balanceTotal;
        private int _currentMonth;

        public DashboardView(int selectedMonth, ObservableCollection<Transaction> transactions)
        {
            _transactions = transactions; // reference retained (not copied)
            _currentMonth = selectedMonth;

            InitializeComponent();

            RecalculateAndUpdateLabels();
        }


        public void RecalculateAndUpdateLabels()
        {
            var transactionsForMonth = TransactionDataService.GetTransactions()
                .Where(t => t.Date.Month == _currentMonth);

            _incomeTotal = transactionsForMonth.Where(t => t.Type == TransactionType.Income).Sum(t => t.Amount);
            _expenseTotal = transactionsForMonth.Where(t => t.Type == TransactionType.Expense).Sum(t => t.Amount);
            _balanceTotal = _incomeTotal - _expenseTotal;

            // Update labels (using currency formatting)
            incomelbl.Text = $"Total Income: {_incomeTotal:C}";
            expenselbl.Text = $"Total Expenses: {_expenseTotal:C}";
            balancelbl.Text = $"Balance: {_balanceTotal:C}";
        }
    }
}
