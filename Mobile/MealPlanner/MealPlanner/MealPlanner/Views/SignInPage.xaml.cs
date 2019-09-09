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
        //DataHandler dataHandler = new DataHandler();

        #endregion


        public SignInPage()
        {
            InitializeComponent();
        }

        private void Sign_In_Clicked(object sender, EventArgs e)
        {

            if (Username.Text == null || Password.Text == null || Username.Text == "" || Password.Text == "") {
                Error.IsVisible = true;
            }
            else if (Username.Text != null || Password.Text != null) {
                Error.IsVisible = false;
                //dataHandler.AddSingleUser(SecurityService.EncryptNewPassword(new User(Username.Text, Password.Text, "Janay", "Sander", "JanaySander17@gmail.com", "02411", DateTime.Now, 0, 0)));

                User attemptLogin = new User(Username.Text, Password.Text);

                // Check if user input credentials are valid inputs

                if (userList.Any(user => user.Username == Username.Text))
                {
                    loggedInUser = userList.Find(user => user.Username == Username.Text);
                    attemptLogin.Salt = loggedInUser.Salt;
                    attemptLogin = SecurityService.EncryptPassword(attemptLogin);

                    if (loggedInUser.Password == attemptLogin.Password)
                    {
                        DisplayAlert($"{loggedInUser.Username}", $"{loggedInUser.Dob}", "WORKING");
                    }
                    else if (loggedInUser.Password == attemptLogin.Password)
                    {
                        DisplayAlert("PASSWORD NOT CORRECT", "Password Incorrect", "NO");
                    }
                }
                else if (!userList.Any(user => user.Username == Username.Text && user.Password == Password.Text))
                {
                    DisplayAlert("NOT WORKING", "NOT WORKING", "NO");
                }

                // if user input credentials are valid, sign user in and continue

                // else if user input credentials are invalid, display an error!
            }

        }

        private void Sign_Up_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new SignUpPage();
        }

        private void Next_Clicked(object sender, EventArgs e)
        {

        }
    }
}