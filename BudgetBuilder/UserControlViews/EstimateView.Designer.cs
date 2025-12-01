namespace BudgetBuilder.UserControlViews
{
    partial class EstimateView
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
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            EstimateLayoutPanel = new FlowLayoutPanel();
            panel2 = new Panel();
            AddEstimateBtn = new Button();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Controls.Add(EstimateLayoutPanel, 0, 1);
            tableLayoutPanel1.Controls.Add(panel2, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(762, 629);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(4, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(754, 56);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 53);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 13);
            label1.Name = "label1";
            label1.Size = new Size(185, 25);
            label1.TabIndex = 0;
            label1.Text = "Estimate Categories";
            // 
            // EstimateLayoutPanel
            // 
            EstimateLayoutPanel.AutoScroll = true;
            EstimateLayoutPanel.AutoScrollMinSize = new Size(15, 0);
            EstimateLayoutPanel.Dock = DockStyle.Fill;
            EstimateLayoutPanel.FlowDirection = FlowDirection.TopDown;
            EstimateLayoutPanel.Location = new Point(4, 67);
            EstimateLayoutPanel.Name = "EstimateLayoutPanel";
            EstimateLayoutPanel.Size = new Size(754, 494);
            EstimateLayoutPanel.TabIndex = 1;
            EstimateLayoutPanel.WrapContents = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(AddEstimateBtn);
            panel2.Location = new Point(4, 568);
            panel2.Name = "panel2";
            panel2.Size = new Size(144, 54);
            panel2.TabIndex = 0;
            // 
            // AddEstimateBtn
            // 
            AddEstimateBtn.Location = new Point(19, 14);
            AddEstimateBtn.Name = "AddEstimateBtn";
            AddEstimateBtn.Size = new Size(99, 23);
            AddEstimateBtn.TabIndex = 0;
            AddEstimateBtn.Text = "Add Estimate";
            AddEstimateBtn.UseVisualStyleBackColor = true;
            AddEstimateBtn.Click += AddEstimateBtn_Click;
            // 
            // EstimateView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "EstimateView";
            Size = new Size(762, 629);
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Label label1;
        private FlowLayoutPanel EstimateLayoutPanel;
        private Panel panel2;
        private Button AddEstimateBtn;
    }
}
