using MealPlanner.Models;
using MealPlanner.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MealPlanner.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AdditionalInfoSignUpPage : ContentPage
    {

        public User signUpUser = ClientDetailsSignUpPage.signUpUser;
        DataHandler dataHandler = new DataHandler();

        public AdditionalInfoSignUpPage()
        {
            InitializeComponent();
            DOB.MaximumDate = DateTime.Today;
        }

        private void Finish_Clicked(object sender, EventArgs e)
        {
            if (DOB.Date == null || Height.Text == null || Weight == null)
            {
                DisplayAlert("Not filled In", "Not all field are filled in...", "Got it!");
            }
            else if (DOB.Date != null && Height.Text != null && Weight != null)
            {
                if (Regex.IsMatch(Height.Text, @"^\d+$") == false || Regex.IsMatch(Weight.Text, @"^\d+$") == false)
                {
                    DisplayAlert("Field Input Invalid", "Weight or Height input is incorrect...", "Got it!");
                }
                else if (Regex.IsMatch(Height.Text, @"^\d+$") == true || Regex.IsMatch(Weight.Text, @"^\d+$") == true)
                {
                    signUpUser.Dob = DOB.Date;
                    signUpUser.Weight = double.Parse(Weight.Text);
                    signUpUser.Height = double.Parse(Height.Text);
                    App.users.Add(signUpUser);
                    dataHandler.AddSingleUser(signUpUser);
                    Application.Current.MainPage = new HomePage();
                }
            }
        }

        private void Back_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new ClientDetailsSignUpPage();
        }
    }
}