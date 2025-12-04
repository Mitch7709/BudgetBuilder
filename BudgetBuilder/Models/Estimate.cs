using System;
using System.ComponentModel;

namespace BudgetBuilder.Models
{
    public class Estimate : INotifyPropertyChanged
    {
        private int _id;
        private string _name;
        private decimal _amount;

        public int Id
        {
            get => _id;
            set
            {
                if (_id == value) return;
                _id = value;
                OnPropertyChanged(nameof(Id));
            }
        }

        public string Name
        {
            get => _name;
            set
            {
                if (_name == value) return;
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public decimal Amount
        {
            get => _amount;
            set
            {
                if (_amount == value) return;
                _amount = value;
                OnPropertyChanged(nameof(Amount));
            }
        }

        public Estimate(int id, string name, decimal amount)
        {
            _id = id;
            _name = name;
            _amount = amount;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
