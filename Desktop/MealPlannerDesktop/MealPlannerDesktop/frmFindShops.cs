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
using static MealPlannerDesktop.MapResultDataWrapper;
using System.Device.Location;

namespace MealPlannerDesktop
{
    public partial class frmFindShops : Form
    {
        private ObservableCollection<Result> WoolworthsResults { get; set; }
        private ObservableCollection<Result> PicknPayResults { get; set; }
        private ObservableCollection<Result> SpaResults { get; set; }
        private ObservableCollection<Result> CheckersResults { get; set; }

        private ObservableCollection<DisplayStoreInfoViewModel> displayingList
            = new ObservableCollection<DisplayStoreInfoViewModel>();

        List<StoreNearYou> DisplayStores = new List<StoreNearYou>();
        BindingSource bs = new BindingSource();

        private MapsAPI mapsAPI = new MapsAPI();

        private string latitude;
        private string longitute;
        private GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();

        private void Watcher_StatusChanged(object sender, GeoPositionStatusChangedEventArgs e) // Find GeoLocation of Device  
        {
            try
            {
                if (e.Status == GeoPositionStatus.Ready)
                {
                    // Display the latitude and longitude.  
                    if (watcher.Position.Location.IsUnknown)
                    {
                        latitude = "0";
                        longitute = "0";
                    }
                    else
                    {
                        latitude = watcher.Position.Location.Latitude.ToString();
                        longitute = watcher.Position.Location.Longitude.ToString();
                    }
                }
                else
                {
                    latitude = "0";
                    longitute = "0";
                }
            }
            catch (Exception)
            {
                latitude = "0";
                longitute = "0";
            }
        }

        public frmFindShops()
        {
            InitializeComponent();
        }

        private void FrmFindShops_Load(object sender, EventArgs e)
        {
            watcher = new GeoCoordinateWatcher();
            // Catch the StatusChanged event.  
            watcher.StatusChanged += Watcher_StatusChanged;
            // Start the watcher.  
            watcher.Start();

            WoolworthsResults = new ObservableCollection<Result>();
            PicknPayResults = new ObservableCollection<Result>();
            SpaResults = new ObservableCollection<Result>();
            CheckersResults = new ObservableCollection<Result>();
            DisplayStores = new List<StoreNearYou>();

            PopulateStores();
        }


        private async void PopulateStores()
        {
            await mapsAPI.PopulateMaps(WoolworthsResults, Convert.ToDouble(latitude), 
                Convert.ToDouble(longitute), "woolworths");
            await mapsAPI.PopulateMaps(PicknPayResults, Convert.ToDouble(latitude),
                Convert.ToDouble(longitute), "PicknPay");
            await mapsAPI.PopulateMaps(SpaResults, Convert.ToDouble(latitude),
                Convert.ToDouble(longitute), "spar");
            await mapsAPI.PopulateMaps(CheckersResults, Convert.ToDouble(latitude),
                Convert.ToDouble(longitute), "checkers");
        }


        private List<StoreNearYou> GenerateDisplayingList(ObservableCollection<Result> results)
        {
            displayingList.Clear();
            DisplayStores.Clear();
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
                    Icon_Source = null,
                    open_Text = (item.opening_hours == null ? false : true) ? "Open Now" : "Closed",
                    ColorHex = (item.opening_hours == null ? false : true) ? "#669e2f" : "#db5151",
                    Distance = "Around " + GetDistanceFromStore(Convert.ToDouble(latitude), Convert.ToDouble(longitute),
                    item.geometry.location.lat, item.geometry.location.lng).ToString("0") + "km from you"
                });
            }
            for(var i = 0; i < displayingList.Count; i++)
            {
                DisplayStores.Add(new StoreNearYou(displayingList[i].Name
                    , displayingList[i].Distance, displayingList[i].open_Text));
            }

            return DisplayStores;
        }



        private double GetDistanceFromStore(double sLatitude, double sLongitude, double eLatitude, double eLongitude)
        {
            return 0;

            //var sCoords = new Location(sLatitude, sLongitude);
            //var eCoords = new Location(eLatitude, eLongitude);
            //return sCoords.CalculateDistance(eCoords, DistanceUnits.Kilometers);
        }

        private void CbxStoreName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                bs.DataSource = null;
                dgvStoresDisplay.DataSource = null;
                switch (cbxStoreName.SelectedIndex)
                {
                    case 0:
                        pbStoreLogo.ImageLocation = "woolworths.jpg";
                        bs.DataSource = GenerateDisplayingList(WoolworthsResults);
                        break;
                    case 1:
                        pbStoreLogo.ImageLocation = "picknpay.jpg";
                        bs.DataSource = GenerateDisplayingList(PicknPayResults);
                        break;
                    case 2:
                        pbStoreLogo.ImageLocation = "spar.jpg";
                        bs.DataSource = GenerateDisplayingList(SpaResults);
                        break;
                    case 3:
                        pbStoreLogo.ImageLocation = "checkers.jpg";
                        bs.DataSource = GenerateDisplayingList(CheckersResults);
                        break;
                    default:
                        pbStoreLogo.ImageLocation = "selectShop.png";
                        break;
                }
                txtNearYou.Text = cbxStoreName.Items[cbxStoreName.SelectedIndex].ToString()
                    + " near you...";
                dgvStoresDisplay.DataSource = bs;
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            try
            {
                frmMainPage main = new frmMainPage();
                main.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
