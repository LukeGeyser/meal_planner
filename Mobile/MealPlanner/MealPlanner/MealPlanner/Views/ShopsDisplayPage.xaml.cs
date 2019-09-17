using MealPlanner.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MealPlanner.Models.MapResultDataWrapper;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using MealPlanner.ViewModels;

namespace MealPlanner.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShopsDisplayPage : ContentPage
    {

        public static ObservableCollection<Result> WoolworthsResults { get; set; }
        public static ObservableCollection<Result> PicknPayResults { get; set; }
        public static ObservableCollection<Result> SpaResults { get; set; }
        public static ObservableCollection<Result> CheckersResults { get; set; }

        private ObservableCollection<DisplayStoreInfoViewModel> displayingList;
        public ObservableCollection<DisplayStoreInfoViewModel> DisplayingList
        {
            get { return displayingList; }
            set
            {
                displayingList = value;
                OnPropertyChanged();
            }
        }

        private MapsAPI mapsAPI = new MapsAPI();
        Location location;
        ViewCell lastCell;

        private string storeSelected { get; set; }

        public ShopsDisplayPage()
        {
            InitializeComponent();
            WoolworthsResults = new ObservableCollection<Result>();
            PicknPayResults = new ObservableCollection<Result>();
            SpaResults = new ObservableCollection<Result>();
            CheckersResults = new ObservableCollection<Result>();
            DisplayingList = new ObservableCollection<DisplayStoreInfoViewModel>();

            BindingContext = this;
        }

        protected override async void OnAppearing()
        {
            location = await GetLocation();
            LoadAllStores(location);
        }

        #region Private Helpers

        private async Task<Location> GetLocation()
        {
            Location location;
            try
            {
                location = await Geolocation.GetLocationAsync();
                if (location != null)
                {
                    //await DisplayAlert($"{location.Latitude.ToString()}", $"{location.Longitude.ToString()}", "Coolio");
                }
            }
            catch (Exception)
            {
                throw;
            }
            return location;
        }

        private async void LoadAllStores(Location location)
        {
            await mapsAPI.PopulateMaps(WoolworthsResults, "-26.152755799999998", "28.3111148", "woolworths");
            await mapsAPI.PopulateMaps(PicknPayResults, "-26.152755799999998", "28.3111148", "PicknPay");
            await mapsAPI.PopulateMaps(SpaResults, "-26.152755799999998", "28.3111148", "spa");
            await mapsAPI.PopulateMaps(CheckersResults, "-26.152755799999998", "28.3111148", "checkers");
        }

        private void GenerateDisplayingList(ObservableCollection<Result> results)
        {
            displayingList.Clear();
            foreach (var item in results)
            {
                displayingList.Add(new DisplayStoreInfoViewModel()
                {
                    Id = item.id,
                    Name = item.name,
                    Opening_Hours = item.opening_hours == null ? false : true,
                    Place_Id = item.place_id,
                    Lat = item.geometry.location.lat,
                    Lng = item.geometry.location.lng,
                    Price_Level = item.price_level,
                    Rating = item.rating,
                    User_Ratings_Total = item.user_ratings_total,
                    Vicinity = item.vicinity
                });
            }
        }

        #endregion

        #region Private Events

        private void StorePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            storeSelected = StorePicker.SelectedItem.ToString();
            if (storeSelected == "WoolWorths") GenerateDisplayingList(WoolworthsResults);
            else if (storeSelected == "Pick n Pay") GenerateDisplayingList(PicknPayResults);
            else if (storeSelected == "Spa") GenerateDisplayingList(SpaResults);
            else if (storeSelected == "Checkers") GenerateDisplayingList(CheckersResults);
        }

        private void ViewCell_Tapped(object sender, EventArgs e)
        {
            if (lastCell != null)
                lastCell.View.BackgroundColor = Color.Transparent;
            var viewCell = (ViewCell)sender;
            if (viewCell.View != null)
            {
                viewCell.View.BackgroundColor = Color.FromHex("#d4d4d4");
                lastCell = viewCell;
            }
        }

        #endregion

    }
}