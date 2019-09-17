using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MealPlanner.Services;
using MealPlanner.Views;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Collections.Generic;
using MealPlanner.Models;
using System.Collections.ObjectModel;
using static MealPlanner.Models.MapResultDataWrapper;

namespace MealPlanner
{
    public partial class App : Application
    {
        Page currentPage = null;
        DataHandler dataHandler = new DataHandler();
        public static List<User> users;
        

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            users = dataHandler.GetAllUsers();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            MainPage = new SignInPage();
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
            currentPage = Current.MainPage;
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
            MainPage = currentPage;
        }
    }
}
