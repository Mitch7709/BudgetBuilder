namespace BudgetBuilder
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            sideBar = new Panel();
            estBtn = new Button();
            label1 = new Label();
            monthComboBox = new ComboBox();
            transBtn = new Button();
            dashBtn = new Button();
            mainPanel = new Panel();
            sideBar.SuspendLayout();
            SuspendLayout();
            // 
            // sideBar
            // 
            sideBar.BackColor = Color.LightGray;
            sideBar.BorderStyle = BorderStyle.Fixed3D;
            sideBar.Controls.Add(estBtn);
            sideBar.Controls.Add(label1);
            sideBar.Controls.Add(monthComboBox);
            sideBar.Controls.Add(transBtn);
            sideBar.Controls.Add(dashBtn);
            sideBar.Dock = DockStyle.Left;
            sideBar.Location = new Point(0, 0);
            sideBar.Name = "sideBar";
            sideBar.Size = new Size(144, 629);
            sideBar.TabIndex = 13;
            // 
            // estBtn
            // 
            estBtn.Cursor = Cursors.Hand;
            estBtn.FlatStyle = FlatStyle.Flat;
            estBtn.Location = new Point(10, 117);
            estBtn.Name = "estBtn";
            estBtn.Size = new Size(118, 33);
            estBtn.TabIndex = 18;
            estBtn.Text = "Estimates";
            estBtn.UseVisualStyleBackColor = true;
            estBtn.Click += estBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 17;
            label1.Text = "Month";
            // 
            // monthComboBox
            // 
            monthComboBox.FormattingEnabled = true;
            monthComboBox.Items.AddRange(new object[] { "January", "February ", "March ", "April ", "May ", "June ", "July ", "August ", "September", "October", "November", "December" });
            monthComboBox.Location = new Point(10, 25);
            monthComboBox.Name = "monthComboBox";
            monthComboBox.Size = new Size(121, 23);
            monthComboBox.TabIndex = 16;
            monthComboBox.SelectedIndexChanged += monthComboBox_SelectedIndexChanged;
            // 
            // transBtn
            // 
            transBtn.Cursor = Cursors.Hand;
            transBtn.FlatStyle = FlatStyle.Flat;
            transBtn.Location = new Point(10, 165);
            transBtn.Name = "transBtn";
            transBtn.Size = new Size(118, 33);
            transBtn.TabIndex = 15;
            transBtn.Text = "Transactions";
            transBtn.UseVisualStyleBackColor = true;
            transBtn.Click += transBtn_Click;
            // 
            // dashBtn
            // 
            dashBtn.Cursor = Cursors.Hand;
            dashBtn.FlatStyle = FlatStyle.Flat;
            dashBtn.Location = new Point(10, 69);
            dashBtn.Name = "dashBtn";
            dashBtn.Size = new Size(118, 33);
            dashBtn.TabIndex = 14;
            dashBtn.Text = "Dashboard";
            dashBtn.UseVisualStyleBackColor = true;
            dashBtn.Click += dashBtn_Click;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.WhiteSmoke;
            mainPanel.BorderStyle = BorderStyle.FixedSingle;
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(144, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(768, 629);
            mainPanel.TabIndex = 14;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 629);
            Controls.Add(mainPanel);
            Controls.Add(sideBar);
            Name = "MainForm";
            Text = "Budget Builder";
            sideBar.ResumeLayout(false);
            sideBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel sideBar;
        private Button dashBtn;
        private Panel mainPanel;
        private Button transBtn;
        private Label label1;
        private ComboBox monthComboBox;
        private Button estBtn;
    }
}
