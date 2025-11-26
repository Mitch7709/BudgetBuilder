using BudgetBuilder.Models;
using BudgetBuilder.DataStorage;
using BudgetBuilder.Enums;

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

            var categories = TransactionDataService.GetCategories();
            categoryValue.Items.AddRange(categories.ToArray());

            amountValue.Value = (decimal)transaction.Amount;
            descriptionValue.Text = transaction.Description;
            categoryValue.Text = transaction.Category;
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
