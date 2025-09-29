using BudgetBuilder.Transactions;
using BudgetBuilder.UserControlViews;

namespace BudgetBuilder
{
    public partial class MainForm : Form
    {
        string currentView;
        int selectedMonth;

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
            switch (currentView)
            {
                case "Dashboard":
                    ShowDashboard();
                    break;
                case "Transaction":
                    ShowTransactions();
                    break;
                default:
                    break;
            }
        }

        private void ShowDashboard()
        {
            mainPanel.Controls.Clear();

            UserControl dashView = new DashboardView(monthComboBox.SelectedIndex + 1);
            currentView = "Dashboard";
            dashView.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(dashView);

        }

        private void ShowTransactions()
        {
            mainPanel.Controls.Clear();

            UserControl transView = new TransactionView(monthComboBox.SelectedIndex + 1);
            currentView = "Transaction";
            transView.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(transView);
        }

        
    }
}
