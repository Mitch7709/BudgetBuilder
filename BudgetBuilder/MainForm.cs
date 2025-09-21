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

        private void ShowDashboard()
        {
            incomeTotal = 5000;
            expenseTotal = 3200;
            balanceTotal = incomeTotal - expenseTotal;

            mainPanel.Controls.Clear();

            UserControl dashView = new DashboardView(incomeTotal, expenseTotal, balanceTotal);
            dashView.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(dashView);

        }

        private void ShowTransactions()
        {
            mainPanel.Controls.Clear();

            Label lbl = new Label();
            lbl.Text = "Transactions";
            lbl.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lbl.Location = new Point(20, 20);
            lbl.AutoSize = true;

            mainPanel.Controls.Add(lbl);
        }        
    }
}
