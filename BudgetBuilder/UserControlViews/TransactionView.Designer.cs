namespace BudgetBuilder.UserControlViews
{
    partial class TransactionView
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel1 = new Panel();
            CategoryComboBox = new ComboBox();
            panel2 = new Panel();
            DatePickFrom = new DateTimePicker();
            label2 = new Label();
            panel3 = new Panel();
            DatePickTo = new DateTimePicker();
            label3 = new Label();
            panel4 = new Panel();
            SearchBox = new TextBox();
            panel5 = new Panel();
            dgvTransactions = new DataGridView();
            Date = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(panel5, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(762, 629);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(4, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10);
            flowLayoutPanel1.Size = new Size(754, 56);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 10);
            label1.Name = "label1";
            label1.Size = new Size(123, 25);
            label1.TabIndex = 0;
            label1.Text = "Transactions";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(panel1);
            flowLayoutPanel2.Controls.Add(panel2);
            flowLayoutPanel2.Controls.Add(panel3);
            flowLayoutPanel2.Controls.Add(panel4);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(4, 67);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(754, 56);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(CategoryComboBox);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(133, 53);
            panel1.TabIndex = 0;
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(3, 15);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(121, 23);
            CategoryComboBox.TabIndex = 2;
            CategoryComboBox.Text = "Category";
            // 
            // panel2
            // 
            panel2.Controls.Add(DatePickFrom);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(142, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(153, 53);
            panel2.TabIndex = 1;
            // 
            // DatePickFrom
            // 
            DatePickFrom.CustomFormat = " From ";
            DatePickFrom.Format = DateTimePickerFormat.Short;
            DatePickFrom.Location = new Point(47, 15);
            DatePickFrom.Name = "DatePickFrom";
            DatePickFrom.ShowCheckBox = true;
            DatePickFrom.Size = new Size(100, 23);
            DatePickFrom.TabIndex = 1;
            // 
            // label2
            // 
            label2.Location = new Point(3, 18);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 0;
            label2.Text = "From:";
            // 
            // panel3
            // 
            panel3.Controls.Add(DatePickTo);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(301, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(153, 53);
            panel3.TabIndex = 2;
            // 
            // DatePickTo
            // 
            DatePickTo.CustomFormat = " From ";
            DatePickTo.Format = DateTimePickerFormat.Short;
            DatePickTo.Location = new Point(47, 15);
            DatePickTo.Name = "DatePickTo";
            DatePickTo.ShowCheckBox = true;
            DatePickTo.Size = new Size(100, 23);
            DatePickTo.TabIndex = 1;
            // 
            // label3
            // 
            label3.Location = new Point(3, 18);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 0;
            label3.Text = "To:";
            // 
            // panel4
            // 
            panel4.Controls.Add(SearchBox);
            panel4.Location = new Point(460, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(92, 53);
            panel4.TabIndex = 3;
            // 
            // SearchBox
            // 
            SearchBox.Anchor = AnchorStyles.None;
            SearchBox.Location = new Point(6, 15);
            SearchBox.Name = "SearchBox";
            SearchBox.PlaceholderText = "Search";
            SearchBox.Size = new Size(80, 23);
            SearchBox.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(dgvTransactions);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(4, 130);
            panel5.Name = "panel5";
            panel5.Size = new Size(754, 430);
            panel5.TabIndex = 2;
            // 
            // dgvTransactions
            // 
            dgvTransactions.AllowUserToAddRows = false;
            dgvTransactions.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.LightGray;
            dgvTransactions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransactions.Columns.AddRange(new DataGridViewColumn[] { Date, Category, Description, Amount, Type });
            dgvTransactions.Dock = DockStyle.Fill;
            dgvTransactions.Location = new Point(0, 0);
            dgvTransactions.MultiSelect = false;
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.ReadOnly = true;
            dgvTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransactions.Size = new Size(754, 430);
            dgvTransactions.TabIndex = 0;
            // 
            // Date
            // 
            Date.DataPropertyName = "Date";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            Date.DefaultCellStyle = dataGridViewCellStyle2;
            Date.HeaderText = "Date";
            Date.Name = "Date";
            Date.ReadOnly = true;
            // 
            // Category
            // 
            Category.DataPropertyName = "Category";
            Category.HeaderText = "Category";
            Category.Name = "Category";
            Category.ReadOnly = true;
            Category.Width = 150;
            // 
            // Description
            // 
            Description.DataPropertyName = "Description";
            Description.HeaderText = "Description";
            Description.Name = "Description";
            Description.ReadOnly = true;
            Description.Width = 250;
            // 
            // Amount
            // 
            Amount.DataPropertyName = "Amount";
            Amount.HeaderText = "Amount";
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            // 
            // Type
            // 
            Type.DataPropertyName = "Type";
            Type.HeaderText = "Type";
            Type.Name = "Type";
            Type.ReadOnly = true;
            Type.Width = 80;
            // 
            // TransactionView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "TransactionView";
            Size = new Size(762, 629);
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel1;
        private ComboBox CategoryComboBox;
        private Panel panel2;
        private Label label2;
        private DateTimePicker DatePickFrom;
        private Panel panel3;
        private DateTimePicker DatePickTo;
        private Label label3;
        private Panel panel4;
        private TextBox SearchBox;
        private Panel panel5;
        private DataGridView dgvTransactions;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn Type;
    }
}
