using BudgetBuilder.Popups;
using BudgetBuilder.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using BudgetBuilder.DataStorage;
using BudgetBuilder.Enums;
using System.Collections.Specialized;

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

            // Initial population
            RefreshCategories();

            // Bind initial grid
            var transactionsForMonth = _transactions.Where(t => t.Date.Month == selectedMonth && t.Date.Year == DateTime.Now.Year).ToList();
            dgvTransactions.DataSource = new BindingList<Transaction>(transactionsForMonth);

            // Subscribe to live Estimates changes so categories stay in sync
            var estimates = TransactionDataService.GetEstimates();
            estimates.CollectionChanged += Estimates_CollectionChanged;

            // Subscribe to property changes for existing items (e.g., Name edits)
            foreach (var est in estimates)
            {
                // Estimate implements INotifyPropertyChanged after our change
                if (est is INotifyPropertyChanged npc)
                    npc.PropertyChanged += Estimate_PropertyChanged;
            }
        }

        private void Estimates_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
        {
            // Add handlers to new items
            if (e.NewItems is not null)
            {
                foreach (var item in e.NewItems)
                {
                    if (item is INotifyPropertyChanged npc)
                        npc.PropertyChanged += Estimate_PropertyChanged;
                }
            }

            // Remove handlers from old items
            if (e.OldItems is not null)
            {
                foreach (var item in e.OldItems)
                {
                    if (item is INotifyPropertyChanged npc)
                        npc.PropertyChanged -= Estimate_PropertyChanged;
                }
            }

            // Update categories after add/remove
            RefreshCategories();
        }

        private void Estimate_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            // If the name changed, categories list needs updating
            if (e.PropertyName == nameof(Estimate.Name))
            {
                RefreshCategories();
            }
        }

        private void RefreshCategories()
        {
            var selected = CategoryComboBox.SelectedItem?.ToString();

            var categories = TransactionDataService.GetCategories();

            CategoryComboBox.BeginUpdate();
            CategoryComboBox.Items.Clear();
            CategoryComboBox.Items.Add("All");
            CategoryComboBox.Items.AddRange(categories.ToArray());
            CategoryComboBox.EndUpdate();

            // Restore selection if possible
            if (!string.IsNullOrWhiteSpace(selected))
            {
                var index = CategoryComboBox.Items.IndexOf(selected);
                CategoryComboBox.SelectedIndex = index >= 0 ? index : 0; // default to "All"
            }
            else
            {
                CategoryComboBox.SelectedIndex = 0; // "All"
            }
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
            var transaction = new Transaction(DateTime.Now, string.Empty, 0, string.Empty, TransactionType.Expense);
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

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var transaction = (Transaction)dgvTransactions.CurrentRow?.DataBoundItem;
            if (transaction == null)
                return;

            var transactionIndex = _transactions.IndexOf(transaction);
            TransactionDataService.DeleteTransaction(transactionIndex);

            UpdateTransactionGrid();
        }

        private void UpdateTransactionGrid()
        {
            var updatedTransactions = TransactionDataService.GetTransactions();
            var transactionsForMonth = updatedTransactions.Where(t => t.Date.Month == selectedMonth && t.Date.Year == DateTime.Now.Year).ToList();
            dgvTransactions.DataSource = new BindingList<Transaction>(transactionsForMonth);
        }
    }
}
