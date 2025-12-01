using BudgetBuilder.Models;
using System.ComponentModel;

namespace BudgetBuilder.UserControlViews
{
    public partial class EstimateView : UserControl
    {
        private readonly BindingList<Estimate> _estimates = new();

        public EstimateView()
        {
            InitializeComponent();
        }

        private void AddEstimateBtn_Click(object sender, EventArgs e)
        {
            AddNewEstimate();
        }

        private void AddNewEstimate()
        {
            var newEstimate = new Estimate(0, string.Empty, 0);

            FlowLayoutPanel newFlowLayout = new FlowLayoutPanel
            {
                AutoSize = false,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false,
                Margin = new Padding(5),
                Padding = new Padding(15),
                Size = new Size(500, 60)
            };        
            
            TextBox nameTextBox = new TextBox
            {
                Size = new Size(142, 23),
                PlaceholderText = "Estimate Name",
                Margin = new Padding(3,3,12,3),                
            };
            nameTextBox.TextChanged += (s, e) =>
            {
                newEstimate.Name = nameTextBox.Text;
            };

            NumericUpDown amountNumericUpDown = new NumericUpDown
            {
                Size = new Size(120, 23),
                Minimum = 0,
                Maximum = 1000000,
                DecimalPlaces = 2,
                Increment = 0.01M,
                Margin = new Padding(3, 3, 12, 3),
            };
            amountNumericUpDown.ValueChanged += (s, e) =>
            {
                newEstimate.Amount = amountNumericUpDown.Value;
            };

            Button removeButton = new Button
            {
                Text = "Remove",
                Size = new Size(75, 23),
                Margin = new Padding(3),
            };
            removeButton.Click += (s, e) =>
            {
                this.EstimateLayoutPanel.Controls.Remove(newFlowLayout);
                //_estimates.Remove(newEstimate);
            };

            newFlowLayout.Controls.Add(nameTextBox);
            newFlowLayout.Controls.Add(amountNumericUpDown);
            newFlowLayout.Controls.Add(removeButton);

            this.EstimateLayoutPanel.Controls.Add(newFlowLayout);
            //_estimates.Add(newEstimate);
        }
    }
}
