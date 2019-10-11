using MealPlanner.Models;
using MealPlanner.Services;
using MealPlanner.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MealPlanner.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectedShopDetailsPage : ContentPage
    {
        public DisplayStoreInfoViewModel storeInfoViewModel { get; set; }

        public string RatingString { get; set; }

        public string PriceRating { get; set; }

        public string PriceRatingHex { get; set; }

        public Shops Shops { get; set; }

        public SelectedShopDetailsPage(DisplayStoreInfoViewModel viewModel)
        {
            InitializeComponent();
            storeInfoViewModel = viewModel;

            Shops = new DataHandler().GetShopsDetails(storeInfoViewModel.StoreID);

            RatingString = storeInfoViewModel.Rating == 0 ? "No Ratings For This Store..." : $"Rating: {storeInfoViewModel.Rating}";

            storeInfoViewModel.Vicinity = "Near " + storeInfoViewModel.Vicinity;

            if (storeInfoViewModel.Price_Level == 0)
            {
                PriceRating = "Price Rating Unavailable";
                PriceRatingHex = "#2d2d2d";
            }
            else if (storeInfoViewModel.Price_Level == 1)
            {
                PriceRating = "1   (Inexpensive)";
                PriceRatingHex = "#669e2f";
            }
            else if (storeInfoViewModel.Price_Level == 2)
            {
                PriceRating = "2   (Moderate)";
                PriceRatingHex = "#ffcb3b";
            }
            else if (storeInfoViewModel.Price_Level == 3)
            {
                PriceRating = "3   (Expensive)";
                PriceRatingHex = "#ffb73b";
            }
            else if (storeInfoViewModel.Price_Level == 4)
            {
                PriceRating = "4   (Very Expensive)";
                PriceRatingHex = "#db5151";
            }


            BindingContext = this;
        }

        private async void Phone_Clicked(object sender, EventArgs e)
        {
            await Call(Shops.Phone);
        }

        private async Task Call(string number)
        {
            try
            {
                PhoneDialer.Open(number);
            }
            catch (FeatureNotSupportedException)
            {

                throw;
            }
        }

        private void Email_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri($"mailto:{Shops.Email}"));
        }

        private async void Website_Clicked(object sender, EventArgs e)
        {
            await Browser.OpenAsync($"{Shops.Website}", new BrowserLaunchOptions
            {
                LaunchMode = BrowserLaunchMode.SystemPreferred,
                TitleMode = BrowserTitleMode.Show,
                PreferredToolbarColor = Color.FromHex("#669e2f"),
                PreferredControlColor = Color.FromHex("#669e2f")
            });
        }
    }
}