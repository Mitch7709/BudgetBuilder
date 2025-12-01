using BudgetBuilder.DataStorage;
using BudgetBuilder.Models;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace BudgetBuilder.UserControlViews
{
    public partial class EstimateView : UserControl
    {
        private readonly ObservableCollection<Estimate> _estimates = new();

        public EstimateView(ObservableCollection<Estimate> estimates)
        {
            InitializeComponent();
            _estimates = estimates ?? new ObservableCollection<Estimate>();
            EstimateView_Load(this, EventArgs.Empty);
        }

        private void AddEstimateBtn_Click(object sender, EventArgs e)
        {
            AddNewEstimate();
        }

        private void AddNewEstimate()
        {
            var estId = _estimates.Count > 0 ? _estimates[^1].Id + 1 : 1;
            var newEstimate = new Estimate(estId, string.Empty, 0m);

            // Persist and add to in-memory collection first
            TransactionDataService.AddEstimate(newEstimate);

            CreateEstimateControls(newEstimate);
        }

        private void EstimateView_Load(object sender, EventArgs e)
        {
            foreach (var estimate in _estimates)
            {
                CreateEstimateControls(estimate);
            }
        }

        private void CreateEstimateControls(Estimate estimate)
        {
            FlowLayoutPanel rowPanel = new FlowLayoutPanel
            {
                AutoSize = false,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false,
                Margin = new Padding(5),
                Padding = new Padding(15),
                Size = new Size(415, 60),
                BorderStyle = BorderStyle.FixedSingle,
                Tag = estimate       // store the object itself
            };

            TextBox nameTextBox = new TextBox
            {
                Size = new Size(142, 23),
                PlaceholderText = "Estimate Name",
                Margin = new Padding(3, 3, 12, 3),
                Text = estimate.Name,
                Tag = estimate
            };
            nameTextBox.TextChanged += NameTextBox_TextChanged;

            NumericUpDown amountNumericUpDown = new NumericUpDown
            {
                Size = new Size(120, 23),
                Minimum = 0,
                Maximum = 1_000_000,
                DecimalPlaces = 2,
                Increment = 0.01M,
                Margin = new Padding(3, 3, 12, 3),
                Value = estimate.Amount,
                Tag = estimate
            };
            amountNumericUpDown.ValueChanged += AmountNumericUpDown_ValueChanged;

            Button removeButton = new Button
            {
                Text = "Remove",
                Size = new Size(75, 23),
                Margin = new Padding(3),
                Tag = estimate
            };
            removeButton.Click += RemoveButton_Click;

            rowPanel.Controls.Add(nameTextBox);
            rowPanel.Controls.Add(amountNumericUpDown);
            rowPanel.Controls.Add(removeButton);

            EstimateLayoutPanel.Controls.Add(rowPanel);
        }

        private void NameTextBox_TextChanged(object? sender, EventArgs e)
        {
            if (sender is TextBox tb && tb.Tag is Estimate est)
            {
                est.Name = tb.Text;
            }
        }

        private void AmountNumericUpDown_ValueChanged(object? sender, EventArgs e)
        {
            if (sender is NumericUpDown num && num.Tag is Estimate est)
            {
                est.Amount = num.Value;
            }
        }

        private void RemoveButton_Click(object? sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is Estimate est)
            {
                // Remove from collection & persistence (id-based delete)
                int id = est.Id;
                TransactionDataService.DeleteEstimate(id);

                // Remove from in-memory collection by id
                //int indexToRemove = -1;
                //for (int i = 0; i < _estimates.Count; i++)
                //{
                //    if (_estimates[i].Id == id)
                //    {
                //        indexToRemove = i;
                //        break;
                //    }
                //}
                //if (indexToRemove >= 0)
                //{
                //    _estimates.RemoveAt(indexToRemove);
                //}

                // Remove associated panel
                foreach (Control c in EstimateLayoutPanel.Controls)
                {
                    if (c is FlowLayoutPanel flp && flp.Tag is Estimate taggedEst && taggedEst.Id == id)
                    {
                        EstimateLayoutPanel.Controls.Remove(flp);
                        flp.Dispose();
                        break;
                    }
                }
            }
        }
    }
}
