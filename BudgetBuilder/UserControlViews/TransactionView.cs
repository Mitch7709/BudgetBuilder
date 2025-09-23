using BudgetBuilder.Transactions;
using System;
using System.Collections.Generic;
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
        public TransactionView()
        {
            InitializeComponent();

            CategoryComboBox.Items.AddRange(new string[] { "Category", "Income", "Rent", "Food", "Utilities" });

            var sampleData = new List<Transaction>
            {
                new Transaction(new DateTime(2024, 1, 5), "Grocery Store", -150.75, "Food", TransactionType.Expense),
                new Transaction(new DateTime(2024, 1, 10), "Salary", 3000.00, "Income", TransactionType.Income),
                new Transaction(new DateTime(2024, 1, 15), "Electric Bill", -75.50, "Utilities", TransactionType.Expense),
                new Transaction(new DateTime(2024, 1, 20), "Restaurant", -60.00, "Food", TransactionType.Expense),
                new Transaction(new DateTime(2024, 1, 25), "Freelance Project", 500.00, "Income", TransactionType.Income),
                new Transaction(new DateTime(2024, 1, 28), "Internet Bill", -45.00, "Utilities", TransactionType.Expense),
                new Transaction(new DateTime(2024, 2, 3), "Grocery Store", -130.20, "Food", TransactionType.Expense),
                new Transaction(new DateTime(2024, 2, 10), "Salary", 3000.00, "Income", TransactionType.Income),
                new Transaction(new DateTime(2024, 2, 14), "Valentine's Gift", -80.00, "Gifts", TransactionType.Expense),
                new Transaction(new DateTime(2024, 2, 18), "Electric Bill", -70.25, "Utilities", TransactionType.Expense),
                new Transaction(new DateTime(2024, 2, 22), "Restaurant", -55.00, "Food", TransactionType.Expense),
                new Transaction(new DateTime(2024, 2, 27), "Freelance Project", 600.00, "Income", TransactionType.Income),
                new Transaction(new DateTime(2024, 2, 29), "Internet Bill", -50.00, "Utilities", TransactionType.Expense)
            };
            dgvTransactions.DataSource = new BindingList<Transaction>(sampleData);
        }       
    }
}
