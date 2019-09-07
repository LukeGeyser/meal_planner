using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using MealPlanner.Models;
using MealPlanner.Services;

namespace MealPlanner.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignInPage : ContentPage
    {

        #region Variables 

        List<User> userList = App.users;
        User loggedInUser;

        #endregion


        public SignInPage()
        {
            InitializeComponent();
        }

        private void Sign_In_Clicked(object sender, EventArgs e)
        {

            if (Username.Text == null || Password.Text == null || Username.Text == "" || Password.Text == "") { 
                Error.IsVisible = true;
            } else if (Username.Text != null || Password.Text != null) {

                Error.IsVisible = false;

                // Check if user input credentials are valid inputs

                if (userList.Any(user => user.Username == Username.Text && user.Password == Password.Text))
                {
                    loggedInUser = userList.Find(user => user.Username == Username.Text && user.Password == Password.Text);
                    DisplayAlert($"{loggedInUser.Firstname}", $"{loggedInUser.Dob}", "WORKING");
                }
                else if (!userList.Any(user => user.Username == Username.Text && user.Password == Password.Text))
                {
                    DisplayAlert("NOT WORKING", "NOT WORKING", "NO");
                }

                // if user input credentials are valid, sign user in and continue

                // else if user input credentials are invalid, display an error!
            }

            // Check if user input credentials are valid inputs

            

            // if user input credentials are valid, sign user in and continue

            // else if user input credentials are invalid, display an error!

        }

        private void Sign_Up_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new SignUpPage();
        }

    }
}