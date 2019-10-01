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
using System.Text.RegularExpressions;

namespace MealPlanner.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShopsDisplayPage : ContentPage
    {
        private ObservableCollection<Result> WoolworthsResults { get; set; }
        private ObservableCollection<Result> PicknPayResults { get; set; }
        private ObservableCollection<Result> SpaResults { get; set; }
        private ObservableCollection<Result> CheckersResults { get; set; }

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
            location = await GetLastKnownLocation();
            if (location != null)
                LoadAllStores(location);
            location = await GetLocation();
        }

        #region Private Helpers

        private async Task<Location> GetLastKnownLocation()
        {
            Location location;
            try
            {
                location = await Geolocation.GetLastKnownLocationAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return location;
        }

        private async Task<Location> GetLocation()
        {
            Location location;
            try
            {
                location = await Geolocation.GetLocationAsync(new GeolocationRequest(GeolocationAccuracy.Lowest));
            }
            catch (Exception)
            {
                throw;
            }
            return location;
        }

        async private void LoadAllStores(Location location)
        {
            await mapsAPI.PopulateMaps(WoolworthsResults, location.Latitude, location.Longitude, "woolworths");
            await mapsAPI.PopulateMaps(PicknPayResults, location.Latitude, location.Longitude, "PicknPay");
            await mapsAPI.PopulateMaps(SpaResults, location.Latitude, location.Longitude, "spar");
            await mapsAPI.PopulateMaps(CheckersResults, location.Latitude, location.Longitude, "checkers");
        }

        private void GenerateDisplayingList(ObservableCollection<Result> results, string Icon_Source, string Title)
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
                    Vicinity = item.vicinity,
                    Icon_Source = Icon_Source,
                    open_Text = (item.opening_hours == null ? false : true) ? "Open Now" : "Closed",
                    ColorHex = (item.opening_hours == null ? false : true) ? "#669e2f" : "#db5151",
                    Distance = "Around " + GetDistanceFromStore(location.Latitude, location.Longitude, item.geometry.location.lat, item.geometry.location.lng).ToString("0") + "km from you",
                    Photo_Details = item.photos == null ? "store.jpg" : mapsAPI.GetPhotoString(item.photos[0].height, item.photos[0].photo_reference)
                });
            }
            NearYou.Text = Title + " near you:";
        }

        private double GetDistanceFromStore(double sLatitude, double sLongitude, double eLatitude, double eLongitude)
        {
            var sCoords = new Location(sLatitude, sLongitude);
            var eCoords = new Location(eLatitude, eLongitude);
            return sCoords.CalculateDistance(eCoords, DistanceUnits.Kilometers);
        }

        #endregion

        #region Private Events

        private void StorePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            storeSelected = StorePicker.SelectedItem.ToString();
            if (storeSelected == "WoolWorths") GenerateDisplayingList(WoolworthsResults, "woolworths.png", "WoolWorths");
            else if (storeSelected == "Pick n Pay") GenerateDisplayingList(PicknPayResults, "picknpay.png", "Pick n Pay's");
            else if (storeSelected == "Spar") GenerateDisplayingList(SpaResults, "spa.png", "Spa's");
            else if (storeSelected == "Checkers") GenerateDisplayingList(CheckersResults, "checkers.png", "Checkers");
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

        private async void ShopsDisplayed_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new SelectedShopDetailsPage(DisplayingList[e.SelectedItemIndex]));
        }

        #endregion

    }
}