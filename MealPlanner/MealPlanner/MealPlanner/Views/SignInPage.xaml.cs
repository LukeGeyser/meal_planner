using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MealPlanner.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignInPage : ContentPage
    {
        public SignInPage()
        {
            InitializeComponent();
        }

        private void Sign_In_Clicked(object sender, EventArgs e)
        {
            // Check if user input credentials are valid inputs

                // if user input credentials are valid, sign user in and continue

                // else if user input credentials are invalid, display an error!

            DisplayAlert("URGENT ALERT", $"Username: {Username.Text}, Password: {Password.Text}", "Coolio");
        }

        private void Sign_Up_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new SignUpPage();
        }
    }
}