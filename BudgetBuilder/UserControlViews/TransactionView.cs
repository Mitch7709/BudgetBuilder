using BudgetBuilder.Popups;
using BudgetBuilder.Transactions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BudgetBuilder.Transactions.Transaction;

namespace BudgetBuilder.UserControlViews
{
    public partial class TransactionView : UserControl
    {
        private readonly ObservableCollection<Transaction> _transactions = new ObservableCollection<Transaction>();
        private readonly int selectedMonth;

        public TransactionView(int selectedMonth)
        {
            this.selectedMonth = selectedMonth;
            _transactions = TransactionDataService.Load();

            InitializeComponent();

            var categories = TransactionDataService.GetTransactionCategories();

            CategoryComboBox.Items.Add("All");
            CategoryComboBox.Items.AddRange(categories.ToArray());

            var transactionsForMonth = _transactions.Where(t => t.Date.Month == selectedMonth && t.Date.Year == DateTime.Now.Year).ToList();
            dgvTransactions.DataSource = new BindingList<Transaction>(transactionsForMonth);
        }

        private void btnFilter_Click(object sender, EventArgs e)
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

        private void btnAddTransaction_Click_1(object sender, EventArgs e)
        {
            var transaction = new Transaction(DateTime.Now, string.Empty, 0.0, string.Empty, TransactionType.Expense);
            var popUp = new TransactionPopup("Add", transaction);
            popUp.ShowDialog();

            var updatedTransactions = TransactionDataService.GetTransactions();
            var transactionsForMonth = updatedTransactions.Where(t => t.Date.Month == selectedMonth && t.Date.Year == DateTime.Now.Year).ToList();
            dgvTransactions.DataSource = new BindingList<Transaction>(transactionsForMonth);
        }

        private void btnEditTransaction_Click(object sender, EventArgs e)
        {
            var transaction = (Transaction)dgvTransactions.CurrentRow?.DataBoundItem;
            if (transaction == null)
                return;

            var transactionIndex = _transactions.IndexOf(transaction);
            var popUp = new TransactionPopup("Edit", transaction, transactionIndex);
            popUp.ShowDialog();

            //Update the DataGridView to reflect changes
            var updatedTransactions = TransactionDataService.GetTransactions();
            var transactionsForMonth = updatedTransactions.Where(t => t.Date.Month == selectedMonth && t.Date.Year == DateTime.Now.Year).ToList();
            dgvTransactions.DataSource = new BindingList<Transaction>(transactionsForMonth);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TransactionDataService.Save(_transactions);
        }
    }
}
