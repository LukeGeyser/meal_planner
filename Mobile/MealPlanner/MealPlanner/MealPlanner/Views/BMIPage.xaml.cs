using MealPlanner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MealPlanner.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BMIPage : ContentPage
    {
        private User loggedInUser = SignInPage.loggedInUser;

        private string status_Color { get; set; }
        public String Status_Color
        {
            get { return status_Color; }
            set
            {
                status_Color = value;
                OnPropertyChanged();
            }
        }

        private double height { get; set; }
        public Double Height_Local
        {
            get { return height; }
            set
            {
                height = value;
                OnPropertyChanged();
            }
        }

        private double weight { get; set; }
        public Double Weight_Local
        {
            get { return weight; }
            set
            {
                weight = value;
                OnPropertyChanged();
            }
        }

        private double bmi { get; set; }
        public Double Bmi
        {
            get { return bmi; }
            set
            {
                bmi = value;
                OnPropertyChanged();
            }
        }

        private string bmi_Status { get; set; }
        public String Bmi_Status
        {
            get { return bmi_Status; }
            set
            {
                bmi_Status = value;
                OnPropertyChanged();
            }
        }

        public BMIPage()
        {
            InitializeComponent();

            Status_Color = "#2d2d2d";

            weight = loggedInUser.Weight;
            height = loggedInUser.Height;

            BindingContext = this;
        }

        private void Calculate_Clicked(object sender, EventArgs e)
        {
            Bmi = weight / (height * height);

            if (bmi < 18.5)
            {
                Bmi_Status = "You are underweight!";
                Status_Color = "#db5151";
            }
            else if (bmi >= 18.5 && bmi < 25)
            {
                Bmi_Status = "You are healthy!";
                Status_Color = "#669e2f";
            }
            else if (bmi >= 25 && bmi < 30)
            {
                Bmi_Status = "You are overweight!";
                Status_Color = "#3bb5d4";
            }
            else
            {
                Bmi_Status = "Your are obese!";
                Status_Color = "#b537db";
            }
        }
    }
}