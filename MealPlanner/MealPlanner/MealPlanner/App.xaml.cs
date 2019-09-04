using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MealPlanner.Services;
using MealPlanner.Views;

namespace MealPlanner
{
    public partial class App : Application
    {
        Page currentPage = null;
        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
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
