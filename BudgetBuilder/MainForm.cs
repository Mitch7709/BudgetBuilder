using BudgetBuilder.Transactions;
using BudgetBuilder.UserControlViews;
using System.Collections.ObjectModel;

namespace BudgetBuilder
{
    public partial class MainForm : Form
    {
        string currentView = "";
        ObservableCollection<Transaction> transactions = new ObservableCollection<Transaction>();

        public MainForm()
        {
            InitializeComponent();

            monthComboBox.SelectedIndex = DateTime.Now.Month - 1;
            transactions = TransactionDataService.Load();

            ShowDashboard();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            TransactionDataService.Save();
        }

        private void dashBtn_Click(object sender, EventArgs e)
        {
            transactions = TransactionDataService.GetTransactions();
            ShowDashboard();
        }

        private void transBtn_Click(object sender, EventArgs e)
        {
            transactions = TransactionDataService.GetTransactions();
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

            UserControl dashView = new DashboardView(monthComboBox.SelectedIndex + 1, transactions);
            currentView = "Dashboard";
            dashView.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(dashView);

        }

        private void ShowTransactions()
        {
            mainPanel.Controls.Clear();

            UserControl transView = new TransactionView(monthComboBox.SelectedIndex + 1, transactions);
            currentView = "Transaction";
            transView.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(transView);
        }

        
    }
}
