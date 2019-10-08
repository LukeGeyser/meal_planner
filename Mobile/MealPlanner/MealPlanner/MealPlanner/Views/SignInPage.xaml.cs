﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using MealPlanner.Models;
using MealPlanner.Services;
using System.Threading;

namespace MealPlanner.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignInPage : ContentPage
    {

        #region Variables 

        List<User> userList = App.users;
        public static User loggedInUser;
        //DataHandler dataHandler = new DataHandler();
        #endregion


        public SignInPage()
        {
            InitializeComponent();
        }

        private void Sign_In_Clicked(object sender, EventArgs e)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                Sign_In.IsEnabled = false;
                Sign_Up.IsEnabled = false;
                loadingPNG.IsVisible = true;
                loadingPNG.FadeTo(100, 500, Easing.Linear);
            });

            Task.Run(async () =>
            {
                if (Username.Text == null || Password.Text == null || Username.Text == "" || Password.Text == "")
                {
                    Error.IsVisible = true;
                }
                else if (Username.Text != null || Password.Text != null)
                {

                    User attemptLogin = new User(Username.Text, Password.Text);

                    // Check if user input credentials are valid inputs
                    if (userList.Any(user => user.Username == Username.Text))
                    {
                        loggedInUser = userList.Find(user => user.Username == Username.Text);
                        attemptLogin.Salt = loggedInUser.Salt;
                        attemptLogin = SecurityService.EncryptPassword(attemptLogin);

                        if (loggedInUser.Password == attemptLogin.Password)
                        {
                            Device.BeginInvokeOnMainThread(() =>
                            {
                                Application.Current.MainPage = new HomePage();
                            });

                        }
                        else if (loggedInUser.Password != attemptLogin.Password)
                        {
                            Device.BeginInvokeOnMainThread(() =>
                            {
                                DisplayAlert("PASSWORD NOT CORRECT", "Password Incorrect", "NO");
                                Sign_In.IsEnabled = true;
                                Sign_Up.IsEnabled = true;
                            });

                        }
                    }
                    else if (!userList.Any(user => user.Username == Username.Text && user.Password == Password.Text))
                    {
                        Device.BeginInvokeOnMainThread(() =>
                        {
                            DisplayAlert("NOT WORKING", "NOT WORKING", "NO");
                            Sign_In.IsEnabled = true;
                            Sign_Up.IsEnabled = true;
                        });
                        
                    }

                    // if user input credentials are valid, sign user in and continue

                    // else if user input credentials are invalid, display an error!
                }
            });

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