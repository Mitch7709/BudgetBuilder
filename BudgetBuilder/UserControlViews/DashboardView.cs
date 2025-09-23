namespace BudgetBuilder.UserControlViews
{
    public partial class DashboardView : UserControl
    {
        private readonly double _incomeTotal = 0;
        private readonly double _expenseTotal = 0;
        private readonly double _balanceTotal = 0;

        public DashboardView(double incomeTotal, double expenseTotal, double balanceTotal)
        {
            _incomeTotal = incomeTotal;
            _expenseTotal = expenseTotal;
            _balanceTotal = balanceTotal;

            InitializeComponent();

            incomelbl.Text = $"Total Income: ${_incomeTotal}";
            expenselbl.Text = $"Total Expenses: ${_expenseTotal}";
            balancelbl.Text = $"Balance: ${_balanceTotal}";
        }
    }
}
