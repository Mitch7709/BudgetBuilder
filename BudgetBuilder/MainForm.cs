using BudgetBuilder.Transactions;
using BudgetBuilder.UserControlViews;
using System.Collections.ObjectModel;

namespace BudgetBuilder
{
    public partial class MainForm : Form
    {
        private enum ViewKind { None, Dashboard, Transaction }

        private ViewKind currentView = ViewKind.None;
        private ObservableCollection<Transaction> transactions = new ObservableCollection<Transaction>();

        // Cached views + their month context
        private DashboardView? dashboardView;
        private int dashboardViewMonth = -1;

        private TransactionView? transactionView;
        private int transactionViewMonth = -1;

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
                case ViewKind.Dashboard:
                    ShowDashboard();
                    break;
                case ViewKind.Transaction:
                    ShowTransactions();
                    break;
                default:
                    break;
            }
        }

        private void ShowDashboard()
        {
            var month = monthComboBox.SelectedIndex + 1;

            mainPanel.SuspendLayout();

            // Ensure a dashboard view exists with the correct month context
            if (dashboardView is null || dashboardViewMonth != month)
            {
                var newView = new DashboardView(month, transactions)
                {
                    Dock = DockStyle.Fill,
                    Visible = false
                };

                if (dashboardView is not null)
                {
                    mainPanel.Controls.Remove(dashboardView);
                    dashboardView.Dispose();
                }

                dashboardView = newView;
                dashboardViewMonth = month;
                mainPanel.Controls.Add(dashboardView);
            }
            else
            {
                // Update existing view's context
                dashboardView.RecalculateAndUpdateLabels();
            }

            // Hide the other view (if present) and bring the dashboard to front
            if (transactionView is not null)
                transactionView.Visible = false;

            dashboardView.Visible = true;
            dashboardView.BringToFront();

            currentView = ViewKind.Dashboard;

            mainPanel.ResumeLayout(performLayout: false);
        }

        private void ShowTransactions()
        {
            var month = monthComboBox.SelectedIndex + 1;

            mainPanel.SuspendLayout();

            // Ensure a transaction view exists with the correct month context
            if (transactionView is null || transactionViewMonth != month)
            {
                var newView = new TransactionView(month, transactions)
                {
                    Dock = DockStyle.Fill,
                    Visible = false
                };

                if (transactionView is not null)
                {
                    mainPanel.Controls.Remove(transactionView);
                    transactionView.Dispose();
                }

                transactionView = newView;
                transactionViewMonth = month;
                mainPanel.Controls.Add(transactionView);
            }

            // Hide the other view (if present) and bring the transactions to front
            if (dashboardView is not null)
                dashboardView.Visible = false;

            transactionView.Visible = true;
            transactionView.BringToFront();

            currentView = ViewKind.Transaction;

            mainPanel.ResumeLayout(performLayout: false);
        }
    }
}
