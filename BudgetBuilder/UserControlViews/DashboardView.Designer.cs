namespace BudgetBuilder.UserControlViews
{
    partial class DashboardView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dashTableLayout = new TableLayoutPanel();
            headerPanel = new FlowLayoutPanel();
            dashLabel = new Label();
            summaryPanel = new FlowLayoutPanel();
            panel1 = new Panel();
            incomelbl = new Label();
            panel2 = new Panel();
            expenselbl = new Label();
            panel3 = new Panel();
            balancelbl = new Label();
            dashTableLayout.SuspendLayout();
            headerPanel.SuspendLayout();
            summaryPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // dashTableLayout
            // 
            dashTableLayout.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            dashTableLayout.ColumnCount = 1;
            dashTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            dashTableLayout.Controls.Add(headerPanel, 0, 0);
            dashTableLayout.Controls.Add(summaryPanel, 0, 1);
            dashTableLayout.Dock = DockStyle.Fill;
            dashTableLayout.Location = new Point(0, 0);
            dashTableLayout.Name = "dashTableLayout";
            dashTableLayout.RowCount = 3;
            dashTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            dashTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            dashTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            dashTableLayout.Size = new Size(762, 629);
            dashTableLayout.TabIndex = 0;
            // 
            // headerPanel
            // 
            headerPanel.Controls.Add(dashLabel);
            headerPanel.Dock = DockStyle.Fill;
            headerPanel.Location = new Point(5, 5);
            headerPanel.Name = "headerPanel";
            headerPanel.Padding = new Padding(10);
            headerPanel.Size = new Size(752, 56);
            headerPanel.TabIndex = 0;
            // 
            // dashLabel
            // 
            dashLabel.AutoSize = true;
            dashLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashLabel.Location = new Point(13, 10);
            dashLabel.Name = "dashLabel";
            dashLabel.Size = new Size(109, 25);
            dashLabel.TabIndex = 0;
            dashLabel.Text = "Dashboard";
            // 
            // summaryPanel
            // 
            summaryPanel.Controls.Add(panel1);
            summaryPanel.Controls.Add(panel2);
            summaryPanel.Controls.Add(panel3);
            summaryPanel.Dock = DockStyle.Fill;
            summaryPanel.Location = new Point(5, 69);
            summaryPanel.Name = "summaryPanel";
            summaryPanel.Padding = new Padding(10);
            summaryPanel.Size = new Size(752, 56);
            summaryPanel.TabIndex = 1;
            summaryPanel.WrapContents = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGreen;
            panel1.Controls.Add(incomelbl);
            panel1.Location = new Point(20, 20);
            panel1.Margin = new Padding(10);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 30);
            panel1.TabIndex = 0;
            // 
            // incomelbl
            // 
            incomelbl.Dock = DockStyle.Fill;
            incomelbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            incomelbl.Location = new Point(0, 0);
            incomelbl.Name = "incomelbl";
            incomelbl.Size = new Size(200, 30);
            incomelbl.TabIndex = 0;
            incomelbl.Text = "Total Income: $5000";
            incomelbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGreen;
            panel2.Controls.Add(expenselbl);
            panel2.Location = new Point(240, 20);
            panel2.Margin = new Padding(10);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 30);
            panel2.TabIndex = 2;
            // 
            // expenselbl
            // 
            expenselbl.BackColor = Color.LightCoral;
            expenselbl.Dock = DockStyle.Fill;
            expenselbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            expenselbl.Location = new Point(0, 0);
            expenselbl.Name = "expenselbl";
            expenselbl.Size = new Size(200, 30);
            expenselbl.TabIndex = 0;
            expenselbl.Text = "Total Expense:";
            expenselbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGreen;
            panel3.Controls.Add(balancelbl);
            panel3.Location = new Point(460, 20);
            panel3.Margin = new Padding(10);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 30);
            panel3.TabIndex = 3;
            // 
            // balancelbl
            // 
            balancelbl.BackColor = Color.LightBlue;
            balancelbl.Dock = DockStyle.Fill;
            balancelbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            balancelbl.Location = new Point(0, 0);
            balancelbl.Name = "balancelbl";
            balancelbl.Size = new Size(200, 30);
            balancelbl.TabIndex = 0;
            balancelbl.Text = "Balance:";
            balancelbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DashboardView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dashTableLayout);
            Name = "DashboardView";
            Size = new Size(762, 629);
            dashTableLayout.ResumeLayout(false);
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            summaryPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel dashTableLayout;
        private FlowLayoutPanel headerPanel;
        private Label dashLabel;
        private FlowLayoutPanel summaryPanel;
        private Panel panel1;
        private Label incomelbl;
        private Panel panel2;
        private Label expenselbl;
        private Panel panel3;
        private Label balancelbl;
    }
}
