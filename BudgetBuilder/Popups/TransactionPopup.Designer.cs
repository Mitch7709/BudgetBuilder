namespace BudgetBuilder.Popups
{
    partial class TransactionPopup
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            descriptionValue = new TextBox();
            amountValue = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            categoryValue = new ComboBox();
            typeValue = new ComboBox();
            label4 = new Label();
            dateValue = new DateTimePicker();
            label5 = new Label();
            confirmBtn = new Button();
            cancelBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)amountValue).BeginInit();
            SuspendLayout();
            // 
            // descriptionValue
            // 
            descriptionValue.Location = new Point(196, 63);
            descriptionValue.Name = "descriptionValue";
            descriptionValue.Size = new Size(149, 23);
            descriptionValue.TabIndex = 0;
            // 
            // amountValue
            // 
            amountValue.DecimalPlaces = 2;
            amountValue.Location = new Point(41, 63);
            amountValue.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            amountValue.Name = "amountValue";
            amountValue.Size = new Size(120, 23);
            amountValue.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 45);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 2;
            label1.Text = "Amount";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(196, 45);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 3;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 105);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 5;
            label3.Text = "Category";
            // 
            // categoryValue
            // 
            categoryValue.FormattingEnabled = true;
            categoryValue.Location = new Point(41, 123);
            categoryValue.Name = "categoryValue";
            categoryValue.Size = new Size(121, 23);
            categoryValue.TabIndex = 6;
            // 
            // typeValue
            // 
            typeValue.FormattingEnabled = true;
            typeValue.Items.AddRange(new object[] { "Income", "Expense" });
            typeValue.Location = new Point(196, 123);
            typeValue.Name = "typeValue";
            typeValue.Size = new Size(121, 23);
            typeValue.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(196, 105);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 7;
            label4.Text = "Type";
            // 
            // dateValue
            // 
            dateValue.Format = DateTimePickerFormat.Short;
            dateValue.Location = new Point(131, 178);
            dateValue.Name = "dateValue";
            dateValue.Size = new Size(105, 23);
            dateValue.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(131, 160);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 10;
            label5.Text = "Date";
            // 
            // confirmBtn
            // 
            confirmBtn.Location = new Point(87, 217);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new Size(75, 23);
            confirmBtn.TabIndex = 11;
            confirmBtn.Text = "Confirm";
            confirmBtn.UseVisualStyleBackColor = true;
            confirmBtn.Click += confirmBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(179, 217);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 23);
            cancelBtn.TabIndex = 12;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            // 
            // TransactionPopup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 269);
            Controls.Add(cancelBtn);
            Controls.Add(confirmBtn);
            Controls.Add(label5);
            Controls.Add(dateValue);
            Controls.Add(typeValue);
            Controls.Add(label4);
            Controls.Add(categoryValue);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(amountValue);
            Controls.Add(descriptionValue);
            Name = "TransactionPopup";
            Text = "TransactionPopup";
            ((System.ComponentModel.ISupportInitialize)amountValue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox descriptionValue;
        private NumericUpDown amountValue;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox categoryValue;
        private ComboBox typeValue;
        private Label label4;
        private DateTimePicker dateValue;
        private Label label5;
        private Button confirmBtn;
        private Button cancelBtn;
    }
}