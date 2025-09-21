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
            transBtn = new Button();
            dashBtn = new Button();
            mainPanel = new Panel();
            dateTimePicker1 = new DateTimePicker();
            sideBar.SuspendLayout();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // sideBar
            // 
            sideBar.BackColor = Color.LightGray;
            sideBar.BorderStyle = BorderStyle.Fixed3D;
            sideBar.Controls.Add(transBtn);
            sideBar.Controls.Add(dashBtn);
            sideBar.Dock = DockStyle.Left;
            sideBar.Location = new Point(0, 0);
            sideBar.Name = "sideBar";
            sideBar.Size = new Size(150, 629);
            sideBar.TabIndex = 13;
            // 
            // transBtn
            // 
            transBtn.Dock = DockStyle.Top;
            transBtn.FlatStyle = FlatStyle.Flat;
            transBtn.Location = new Point(0, 23);
            transBtn.Name = "transBtn";
            transBtn.Size = new Size(146, 23);
            transBtn.TabIndex = 15;
            transBtn.Text = "Transactions";
            transBtn.UseVisualStyleBackColor = true;
            transBtn.Click += transBtn_Click;
            // 
            // dashBtn
            // 
            dashBtn.Dock = DockStyle.Top;
            dashBtn.FlatStyle = FlatStyle.Flat;
            dashBtn.Location = new Point(0, 0);
            dashBtn.Name = "dashBtn";
            dashBtn.Size = new Size(146, 23);
            dashBtn.TabIndex = 14;
            dashBtn.Text = "Dashboard";
            dashBtn.UseVisualStyleBackColor = true;
            dashBtn.Click += dashBtn_Click;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.WhiteSmoke;
            mainPanel.BorderStyle = BorderStyle.FixedSingle;
            mainPanel.Controls.Add(dateTimePicker1);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(150, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(762, 629);
            mainPanel.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(299, 192);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(95, 23);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.Value = new DateTime(2025, 9, 10, 0, 0, 0, 0);
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
            mainPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel sideBar;
        private Button dashBtn;
        private Panel mainPanel;
        private Button transBtn;
        private DateTimePicker dateTimePicker1;
    }
}
