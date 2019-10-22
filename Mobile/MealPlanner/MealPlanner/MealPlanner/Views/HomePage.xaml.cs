using MealPlanner.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MealPlanner.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class HomePage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();

        public HomePage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            masterPage.listView.ItemSelected += OnItemSelected;
        }

        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as HomeMenuItem;
            var selectedItem = ((ListView)sender).SelectedItem;
            if (item != null)
            {
                if (item.Title == ("Logout"))
                {
                    bool answer = await DisplayAlert("Warning", "Are you sure you want to exit the Application?", "Yes", "No");
                    switch (answer)
                    {
                        case true:
                            SignInPage.loggedInUser = null;
                            Application.Current.MainPage = new SignInPage();
                            break;
                        case false:
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType))
                    {
                        BarBackgroundColor = Color.FromHex("#fafafa")
                    };
                }
                masterPage.listView.SelectedItem = null;
                IsPresented = false;
            }
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Browse:
                        MenuPages.Add(id, new NavigationPage(new HomePage()));
                        break;
                    case (int)MenuItemType.About:
                        MenuPages.Add(id, new NavigationPage(new AboutPage()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}