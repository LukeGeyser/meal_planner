using MealPlanner.Models;
using MealPlanner.Services;
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
    public partial class SignUpPage : ContentPage
    {

        List<User> users = App.users;
        public static User signUpUser;

        public SignUpPage()
        {
            InitializeComponent();
        }

        private void Back_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new SignInPage();
        }

        private void Next_Clicked(object sender, EventArgs e)
        {
            if (Username.Text == null || Password.Text == null || RePassword.Text == null)
            {
                DisplayAlert("Not filled In", "Not all field are filled in...", "Got it!");
            }
            else if (Username.Text != null && Password.Text != null && RePassword.Text != null)
            {
                // Check if Username already Exists in Database
                if (users.Any(user => user.Username == Username.Text))
                {
                    // Usernames Alreadt Exist, inform User
                    DisplayAlert("Username Already Exist", "Please try again...", "Got it!");
                }
                else if (!users.Any(user => user.Username == Username.Text))
                {
                    // Username doesn't exist in database, Continue with Checks

                    if (Password.Text != RePassword.Text) // Check if Passwords Do NOT Match
                    {
                        // Inform User That Passwords do not match
                        DisplayAlert("Passwords do not match", "Please try again...", "Got it!");
                    }
                    else if (Password.Text == RePassword.Text) // Check if Passwords Match
                    {
                        // Proceed with SignUp Forms
                        signUpUser = SecurityService.EncryptNewPassword(signUpUser = new User()
                        {
                            Username = Username.Text,
                            Password = Password.Text
                        });
                        Application.Current.MainPage = new ClientDetailsSignUpPage();
                    }
                }
                
            }
        }
    }
}