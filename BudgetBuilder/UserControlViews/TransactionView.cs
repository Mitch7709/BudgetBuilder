using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetBuilder.UserControlViews
{
    public partial class TransactionView : UserControl
    {
        public TransactionView()
        {
            InitializeLayout();
        }

        private void InitializeLayout()
        {
            TableLayoutPanel tableLayout = new TableLayoutPanel();
            tableLayout.Dock = DockStyle.Fill;
            tableLayout.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayout.RowCount = 4;
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10));

            FlowLayoutPanel headerPanel = new FlowLayoutPanel();
            headerPanel.Dock = DockStyle.Fill;
            headerPanel.FlowDirection = FlowDirection.LeftToRight;
            headerPanel.Padding = new Padding(10);
            headerPanel.Controls.Add(CreateTransactionLabel());

            FlowLayoutPanel controlPanel = new FlowLayoutPanel();
            controlPanel.Dock = DockStyle.Fill;
            controlPanel.FlowDirection = FlowDirection.LeftToRight;
            controlPanel.WrapContents = false;
            controlPanel.Padding = new Padding(40, 10, 10, 10);

            controlPanel.Controls.Add(CreateCategoryControl());
            controlPanel.Controls.Add(CreateControlLabel("From:"));
            controlPanel.Controls.Add(CreateDateSearchControl(" From "));
            controlPanel.Controls.Add(CreateControlLabel("To:"));
            controlPanel.Controls.Add(CreateDateSearchControl(" To "));
            controlPanel.Controls.Add(CreateSearchControl());

            tableLayout.Controls.Add(headerPanel, 0, 0);
            tableLayout.Controls.Add(controlPanel, 0, 1);
            this.Controls.Add(tableLayout);
        }

        private Panel CreateTransactionLabel()
        {             
            Panel panel = new Panel();

            Label lbl = new Label();
            lbl.Text = "Transactions";
            lbl.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lbl.AutoSize = true;

            panel.Controls.Add(lbl);
            return panel;
        }

        private Panel CreateCategoryControl()
        {
            Panel panel = new Panel();
            panel.Margin = new Padding(10);
            panel.Size = new Size(80, 30);

            ComboBox categoryComboBox = new ComboBox();
            categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryComboBox.Items.AddRange(new string[] {"Category", "Income", "Expense" });
            categoryComboBox.SelectedIndex = 0;
            categoryComboBox.Width = 80;

            categoryComboBox.DropDown += (s, e) =>
            {
                if (categoryComboBox.Items.Contains("Category"))
                {
                    categoryComboBox.Items.Remove("Category");
                }
            };

            panel.Controls.Add(categoryComboBox);
            return panel;
        }

        private Panel CreateControlLabel(string text)
        {
            Panel panel = new Panel();
            panel.Margin = new Padding(0, 10, 0, 10);
            panel.Size = new Size(50, 30);

            Label lbl = new Label();
            lbl.AutoSize = true;
            lbl.Text = text;
            lbl.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            lbl.AutoSize = true;
            panel.Controls.Add(lbl);
            return panel;
        }

        private Panel CreateDateSearchControl(string text)
        {
            Panel panel = new Panel();
            panel.Margin = new Padding(0, 10, 5, 10);
            panel.Size = new Size(80, 30);

            DateTimePicker datePicker = new DateTimePicker();
            datePicker.Format = DateTimePickerFormat.Short;
            datePicker.Width = 80;
            datePicker.CustomFormat = text;
            datePicker.ValueChanged += (s, e) =>
            {
                datePicker.Format = DateTimePickerFormat.Short;
            };

            panel.Controls.Add(datePicker);
            return panel;
        }

        private Panel CreateSearchControl()
        {
            Panel panel = new Panel();
            panel.Margin = new Padding(10);
            panel.Size = new Size(80, 30);
            
            TextBox searchText = new TextBox();
            searchText.Width = 80;
            searchText.PlaceholderText = "Search";


            panel.Controls.Add(searchText);
            return panel;
        }
    }
}
