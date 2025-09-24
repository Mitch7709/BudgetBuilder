using BudgetBuilder.Services;
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

        public TransactionView()
        {
            _transactions = TransactionDataService.GetTransactions();         

            InitializeComponent();

            CategoryComboBox.Items.AddRange(new string[] { "", "Income", "Rent", "Food", "Utilities" });

            dgvTransactions.DataSource = new BindingList<Transaction>(_transactions);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            _transactions.Clear();
            var filtered = TransactionDataService.GetFilteredTransactions(
                CategoryComboBox.SelectedItem?.ToString(),
                DatePickTo.Checked ? DatePickTo.Value.Date : null,
                DatePickFrom.Checked ? DatePickFrom.Value.Date : null);

            dgvTransactions.DataSource = new BindingList<Transaction>(filtered);
        }
    }
}
