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
            _transactions = TransactionDataService.GetTransactionsByMonth(this.selectedMonth, DateTime.Now.Year);         

            InitializeComponent();

            CategoryComboBox.Items.AddRange(new string[] { "", "Income", "Rent", "Food", "Utilities" });

            dgvTransactions.DataSource = new BindingList<Transaction>(_transactions);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            var filtered = _transactions.Where(t =>
                (string.IsNullOrEmpty(CategoryComboBox.SelectedItem?.ToString()) || t.Category == CategoryComboBox.SelectedItem.ToString())
            ).ToList();

            dgvTransactions.DataSource = new BindingList<Transaction>(filtered);
        }
    }
}
