using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xamarin.Essentials;
using static MealPlannerDesktop.MapResultDataWrapper;

namespace MealPlannerDesktop
{
    public partial class frmFindShops : Form
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

        private void OnPropertyChanged()
        {
            for(int i = 0; i < DisplayingList.Count; i++)
            {
                lstStoresDisplay.Items.Add(DisplayingList[i].Name);
            }
        }

        private MapsAPI mapsAPI = new MapsAPI();
        Xamarin.Essentials.Location location = new Xamarin.Essentials.Location(0,0);

        private string storeSelected { get; set; }
        
    
        async private void LoadAllStores(Xamarin.Essentials.Location location)
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
                    Distance = "Around " + GetDistanceFromStore(location.Latitude, location.Longitude, item.geometry.location.lat, item.geometry.location.lng).ToString("0") + "km from you"
                });
            }
            NearYou.Text = Title + " near you:";
        }

        private double GetDistanceFromStore(double sLatitude, double sLongitude, double eLatitude, double eLongitude)
        {
            var sCoords = new Xamarin.Essentials.Location(sLatitude, sLongitude);
            var eCoords = new Xamarin.Essentials.Location(eLatitude, eLongitude);
            return sCoords.CalculateDistance(eCoords, DistanceUnits.Kilometers);
        }



        private void FrmFindShops_Load(object sender, EventArgs e)
        {
            
        }

        private void CbxStoreName_SelectedIndexChanged(object sender, EventArgs e)
        {
            storeSelected = cbxStoreName.SelectedItem.ToString();
            if (storeSelected == "WoolWorths") GenerateDisplayingList(WoolworthsResults, "woolworths.png", "WoolWorths");
            else if (storeSelected == "Pick n Pay") GenerateDisplayingList(PicknPayResults, "picknpay.png", "Pick n Pay's");
            else if (storeSelected == "Spar") GenerateDisplayingList(SpaResults, "spa.png", "Spa's");
            else if (storeSelected == "Checkers") GenerateDisplayingList(CheckersResults, "checkers.png", "Checkers");
        }
    }
}
