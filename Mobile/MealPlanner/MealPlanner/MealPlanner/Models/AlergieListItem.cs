using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace MealPlanner.Models
{
    public class AlergieListItem : INotifyPropertyChanged
    {
        public int id { get; set; }

        private string _name { get; set; }

        public string Description { get; set; }

        private bool _isChecked { get; set; }

        public String Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }
        public Boolean IsChecked
        {
            get { return _isChecked; }
            set
            {
                _isChecked = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
