using BudgetBuilder.Transactions;
using BudgetBuilder.UserControlViews;

namespace BudgetBuilder
{
    public partial class MainForm : Form
    {

        double incomeTotal = 0;
        double expenseTotal = 0;
        double balanceTotal = 0;

        public MainForm()
        {
            InitializeComponent();

            monthComboBox.SelectedIndex = DateTime.Now.Month - 1;

            ShowDashboard();
        }

        private void dashBtn_Click(object sender, EventArgs e)
        {
            ShowDashboard();
        }

        private void transBtn_Click(object sender, EventArgs e)
        {
            ShowTransactions();
        }

        private void monthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowDashboard();
        }

        private void ShowDashboard()
        {
            var transactions = TransactionDataService.GetTransactionsByMonth(monthComboBox.SelectedIndex + 1, DateTime.Now.Year).ToList();

            incomeTotal = transactions.Where(t => t.Type == Transaction.TransactionType.Income).Sum(t => t.Amount);
            expenseTotal = transactions.Where(t => t.Type == Transaction.TransactionType.Expense).Sum(t => Math.Abs(t.Amount));
            balanceTotal = incomeTotal - expenseTotal;

            mainPanel.Controls.Clear();

            UserControl dashView = new DashboardView(incomeTotal, expenseTotal, balanceTotal);
            dashView.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(dashView);

        }

        private void ShowTransactions()
        {
            mainPanel.Controls.Clear();

            UserControl transView = new TransactionView(monthComboBox.SelectedIndex + 1);
            transView.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(transView);
        }

        
    }
}
