using BudgetBuilder.Popups;
using BudgetBuilder.Transactions;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using static BudgetBuilder.Transactions.Transaction;

namespace BudgetBuilder.UserControlViews
{
    public partial class TransactionView : UserControl
    {
        private readonly ObservableCollection<Transaction> _transactions = new ObservableCollection<Transaction>();
        private readonly int selectedMonth;

        public TransactionView(int selectedMonth, ObservableCollection<Transaction> transactions)
        {
            this.selectedMonth = selectedMonth;
            _transactions = transactions;

            InitializeComponent();

            var categories = TransactionDataService.GetTransactionCategories();

            CategoryComboBox.Items.Add("All");
            CategoryComboBox.Items.AddRange(categories.ToArray());

            var transactionsForMonth = _transactions.Where(t => t.Date.Month == selectedMonth && t.Date.Year == DateTime.Now.Year).ToList();
            dgvTransactions.DataSource = new BindingList<Transaction>(transactionsForMonth);
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var transactionsForMonth = _transactions.Where(t => t.Date.Month == selectedMonth && t.Date.Year == DateTime.Now.Year).ToList();

            if (CategoryComboBox.SelectedItem == null || CategoryComboBox.SelectedItem.ToString() == "All")
            {
                dgvTransactions.DataSource = new BindingList<Transaction>(transactionsForMonth);
            }
            else
            {
                var filtered = transactionsForMonth.Where(t =>
                    (string.IsNullOrEmpty(CategoryComboBox.SelectedItem?.ToString()) || t.Category == CategoryComboBox.SelectedItem.ToString())
                ).ToList();

                dgvTransactions.DataSource = new BindingList<Transaction>(filtered);
            }
        }

        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            var transaction = new Transaction(DateTime.Now, string.Empty, 0.0, string.Empty, TransactionType.Expense);
            var popUp = new TransactionPopup("Add", transaction);
            popUp.ShowDialog();

            UpdateTransactionGrid();
        }

        private void btnEditTransaction_Click(object sender, EventArgs e)
        {
            var transaction = (Transaction)dgvTransactions.CurrentRow?.DataBoundItem;
            if (transaction == null)
                return;

            var transactionIndex = _transactions.IndexOf(transaction);
            var popUp = new TransactionPopup("Edit", transaction, transactionIndex);
            popUp.ShowDialog();

            UpdateTransactionGrid();
        }


        private void UpdateTransactionGrid()
        {
            var updatedTransactions = TransactionDataService.GetTransactions();
            var transactionsForMonth = updatedTransactions.Where(t => t.Date.Month == selectedMonth && t.Date.Year == DateTime.Now.Year).ToList();
            dgvTransactions.DataSource = new BindingList<Transaction>(transactionsForMonth);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var transaction = (Transaction)dgvTransactions.CurrentRow?.DataBoundItem;
            if (transaction == null)
                return;

            var transactionIndex = _transactions.IndexOf(transaction);
            TransactionDataService.DeleteTransaction(transactionIndex);

            UpdateTransactionGrid();
        }
    }
}
