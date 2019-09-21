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
using System.Threading.Tasks;

namespace MealPlanner
{
    public partial class App : Application
    {
        Page currentPage = null;
        DataHandler dataHandler = new DataHandler();
        public static List<User> users = new List<User>();
        

        public App()
        {
            InitializeComponent();

            //DependencyService.Register<MockDataStore>();
            Task.Run(async () =>
            {
                await dataHandler.GetAllUsers(users);
            });
            MainPage = new SignInPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts            
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
