using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace MealPlanner.Models
{
    public class WeightGainTips : INotifyPropertyChanged
    {
        private string tip { get; set; }
        public String Tip
        {
            get { return tip; }
            set
            {
                tip = value;
                OnPropertyChanged();
            }
        }

        public WeightGainTips(string tip)
        {
            this.tip = tip;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
