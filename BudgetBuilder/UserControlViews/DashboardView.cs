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
    public partial class DashboardView : UserControl
    {
        private readonly double _incomeTotal = 0;
        private readonly double _expenseTotal = 0;
        private readonly double _balanceTotal = 0;

        public DashboardView(double incomeTotal, double expenseTotal, double balanceTotal)
        {
            _incomeTotal = incomeTotal;
            _expenseTotal = expenseTotal;
            _balanceTotal = balanceTotal;

            InitializeLayout();
        }

        private void InitializeLayout()
        {
            TableLayoutPanel tableLayout = new TableLayoutPanel();
            tableLayout.Dock = DockStyle.Fill;
            tableLayout.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayout.RowCount = 3;
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            //tableLayout.Size = new Size(760, 627);

            FlowLayoutPanel headerPanel = new FlowLayoutPanel();
            headerPanel.Dock = DockStyle.Fill;
            headerPanel.FlowDirection = FlowDirection.LeftToRight;
            headerPanel.Padding = new Padding(10);
            headerPanel.Controls.Add(CreateDashboardLabel());

            FlowLayoutPanel summaryContainer = new FlowLayoutPanel();
            summaryContainer.Dock = DockStyle.Fill;
            summaryContainer.FlowDirection = FlowDirection.LeftToRight;
            summaryContainer.WrapContents = false;
            summaryContainer.Padding = new Padding(40, 10, 10, 10);

            summaryContainer.Controls.Add(CreateSummaryPanel($"Total Income: ${_incomeTotal}", Color.LightGreen));
            summaryContainer.Controls.Add(CreateSummaryPanel($"Total Expenses: ${_expenseTotal}", Color.LightCoral));
            summaryContainer.Controls.Add(CreateSummaryPanel($"Balance: ${_balanceTotal}", Color.LightBlue));

            tableLayout.Controls.Add(headerPanel, 0, 0);
            tableLayout.Controls.Add(summaryContainer, 0, 1);

            this.Controls.Add(tableLayout);
        }

        private Panel CreateDashboardLabel()
        {
            Panel panel = new Panel();


            Label lbl = new Label();
            lbl.Text = "Dashboard";
            lbl.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lbl.AutoSize = true;

            panel.Controls.Add(lbl);
            return panel;
        }

        private Panel CreateSummaryPanel(string text, Color backColor)
        {
            Panel panel = new Panel();
            panel.Size = new Size(200, 30);
            panel.Margin = new Padding(10);
            panel.BackColor = backColor;

            Label label = new Label();
            label.Text = text;
            label.Dock = DockStyle.Fill;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Font = new Font("Segoe UI", 12, FontStyle.Bold);

            panel.Controls.Add(label);
            return panel;
        }
    }
}
