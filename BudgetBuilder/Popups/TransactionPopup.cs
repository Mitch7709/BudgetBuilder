using BudgetBuilder.Models;
using BudgetBuilder.DataStorage;
using BudgetBuilder.Enums;
using System.ComponentModel;
using System.Collections.Specialized;

namespace BudgetBuilder.Popups
{
    public partial class TransactionPopup : Form
    {
        private readonly string _action;
        private readonly int _transactionIndex;

        public TransactionPopup(string action, Transaction transaction, int transactionIndex = 0)
        {
            InitializeComponent();
            _action = action;
            _transactionIndex = transactionIndex;

            // Populate categories initially
            RefreshCategories();

            // Subscribe to estimates changes for live updates
            var estimates = TransactionDataService.GetEstimates();
            estimates.CollectionChanged += Estimates_CollectionChanged;
            foreach (var est in estimates)
            {
                if (est is INotifyPropertyChanged npc)
                    npc.PropertyChanged += Estimate_PropertyChanged;
            }

            amountValue.Value = (decimal)transaction.Amount;
            descriptionValue.Text = transaction.Description;
            // Restore the transaction's category selection if present
            if (!string.IsNullOrWhiteSpace(transaction.Category))
            {
                var idx = categoryValue.Items.IndexOf(transaction.Category);
                if (idx >= 0) categoryValue.SelectedIndex = idx;
                else categoryValue.Text = transaction.Category; // allow non-listed text temporarily
            }
            typeValue.Text = transaction.Type.ToString();
            dateValue.Value = transaction.Date;

            if (action == "Add")
            {
                this.Text = "Add Transaction";
            }
            else if (action == "Edit")
            {
                this.Text = "Edit Transaction";
            }
        }

        private void Estimates_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
        {
            // Track property changes for new/removed items
            if (e.NewItems is not null)
            {
                foreach (var item in e.NewItems)
                {
                    if (item is INotifyPropertyChanged npc)
                        npc.PropertyChanged += Estimate_PropertyChanged;
                }
            }
            if (e.OldItems is not null)
            {
                foreach (var item in e.OldItems)
                {
                    if (item is INotifyPropertyChanged npc)
                        npc.PropertyChanged -= Estimate_PropertyChanged;
                }
            }

            RefreshCategories();
        }

        private void Estimate_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(Estimate.Name))
            {
                RefreshCategories();
            }
        }

        private void RefreshCategories()
        {
            var previousText = categoryValue.Text;

            var categories = TransactionDataService.GetCategories();

            categoryValue.BeginUpdate();
            categoryValue.Items.Clear();
            categoryValue.Items.AddRange(categories.ToArray());
            categoryValue.EndUpdate();

            // Try to preserve current selection/text
            if (!string.IsNullOrWhiteSpace(previousText))
            {
                var idx = categoryValue.Items.IndexOf(previousText);
                if (idx >= 0)
                    categoryValue.SelectedIndex = idx;
                else
                    categoryValue.Text = previousText;
            }
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            var transaction = new Transaction(
                dateValue.Value,
                descriptionValue.Text,
                (decimal)amountValue.Value,
                categoryValue.Text,
                (TransactionType)Enum.Parse(typeof(TransactionType), typeValue.Text)
            );

            var validationError = transaction.ValidateFields();
            if (!string.IsNullOrEmpty(validationError))
            {
                MessageBox.Show(validationError, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_action == "Add")
            {
                TransactionDataService.AddTransaction(transaction);
            }
            else if (_action == "Edit")
            {
                TransactionDataService.UpdateTransaction(_transactionIndex, transaction);
            }
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
