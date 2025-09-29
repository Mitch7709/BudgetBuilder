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
            panel4 = new Panel();
            SearchBox = new TextBox();
            panel6 = new Panel();
            btnFilter = new Button();
            panel5 = new Panel();
            dgvTransactions = new DataGridView();
            Date = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            flowLayoutPanel3 = new FlowLayoutPanel();
            panel2 = new Panel();
            btnAddTransaction = new Button();
            panel3 = new Panel();
            btnEditTransaction = new Button();
            btnSave = new Button();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            flowLayoutPanel3.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
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
            tableLayoutPanel1.Controls.Add(flowLayoutPanel3, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(762, 629);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(btnSave);
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
            flowLayoutPanel2.Controls.Add(panel4);
            flowLayoutPanel2.Controls.Add(panel6);
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
            // panel4
            // 
            panel4.Controls.Add(SearchBox);
            panel4.Location = new Point(142, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(121, 53);
            panel4.TabIndex = 3;
            // 
            // SearchBox
            // 
            SearchBox.Anchor = AnchorStyles.None;
            SearchBox.Location = new Point(6, 15);
            SearchBox.Name = "SearchBox";
            SearchBox.PlaceholderText = "Search";
            SearchBox.Size = new Size(106, 23);
            SearchBox.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnFilter);
            panel6.Location = new Point(269, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(121, 53);
            panel6.TabIndex = 4;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = SystemColors.ButtonHighlight;
            btnFilter.Cursor = Cursors.Hand;
            btnFilter.Location = new Point(22, 14);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(75, 23);
            btnFilter.TabIndex = 0;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
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
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(panel2);
            flowLayoutPanel3.Controls.Add(panel3);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.Location = new Point(4, 567);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(754, 58);
            flowLayoutPanel3.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnAddTransaction);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(142, 55);
            panel2.TabIndex = 0;
            // 
            // btnAddTransaction
            // 
            btnAddTransaction.AutoSize = true;
            btnAddTransaction.Location = new Point(21, 13);
            btnAddTransaction.Name = "btnAddTransaction";
            btnAddTransaction.Size = new Size(103, 25);
            btnAddTransaction.TabIndex = 0;
            btnAddTransaction.Text = "Add Transaction";
            btnAddTransaction.UseVisualStyleBackColor = true;
            btnAddTransaction.Click += btnAddTransaction_Click_1;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnEditTransaction);
            panel3.Location = new Point(151, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(142, 55);
            panel3.TabIndex = 1;
            // 
            // btnEditTransaction
            // 
            btnEditTransaction.AutoSize = true;
            btnEditTransaction.Location = new Point(21, 13);
            btnEditTransaction.Name = "btnEditTransaction";
            btnEditTransaction.Size = new Size(103, 25);
            btnEditTransaction.TabIndex = 0;
            btnEditTransaction.Text = "Edit Transaction";
            btnEditTransaction.UseVisualStyleBackColor = true;
            btnEditTransaction.Click += btnEditTransaction_Click;
            // 
            // btnSave
            // 
            btnSave.AutoSize = true;
            btnSave.Location = new Point(142, 13);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(90, 25);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
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
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            flowLayoutPanel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel1;
        private ComboBox CategoryComboBox;
        private Panel panel4;
        private TextBox SearchBox;
        private Panel panel5;
        private DataGridView dgvTransactions;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn Type;
        private Panel panel6;
        private Button btnFilter;
        private FlowLayoutPanel flowLayoutPanel3;
        private Panel panel2;
        private Button btnAddTransaction;
        private Panel panel3;
        private Button btnEditTransaction;
        private Button btnSave;
    }
}
