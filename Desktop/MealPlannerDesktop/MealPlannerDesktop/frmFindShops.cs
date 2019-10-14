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
using System.Diagnostics;
using System.Threading;

namespace MealPlannerDesktop
{
    public partial class frmFindShops : Form
    {
        //Collections to hold results from MapAPI

        private ObservableCollection<Result> WoolworthsResults { get; set; }
        private ObservableCollection<Result> PicknPayResults { get; set; }
        private ObservableCollection<Result> SpaResults { get; set; }
        private ObservableCollection<Result> CheckersResults { get; set; }

        private ObservableCollection<DisplayStoreInfoViewModel> displayingList
            = new ObservableCollection<DisplayStoreInfoViewModel>();

        List<StoreNearYou> DisplayStores = new List<StoreNearYou>();
        BindingSource bs = new BindingSource();

        private MapsAPI mapsAPI = new MapsAPI();

        private double latitude = 0;
        private double longitute = 0;

        //GeoCoordinateWatcher is a Geolocation service for visual studio 
        //to access their location.
        private GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();

        public frmFindShops()
        {
            InitializeComponent();
        }

        private void Watcher_StatusChanged(object sender, GeoPositionStatusChangedEventArgs e)
        {
            if (e.Status == GeoPositionStatus.Ready)
            {
                if (watcher.Position.Location.IsUnknown)
                {
                    Debug.WriteLine("Cannot find location");
                }
                else
                {
                    Debug.WriteLine("Lat: " + watcher.Position.Location.Latitude.ToString());
                    Debug.WriteLine("Lon: " + watcher.Position.Location.Longitude.ToString());
                }
            }
        }

        private static void GeoPositionChanged(object sender, GeoPositionChangedEventArgs<GeoCoordinate> e)
        {
            Console.WriteLine("The current location is: " +
                e.Position.Location.Latitude + "/" +
                e.Position.Location.Longitude + ".");
        }

        private void FrmFindShops_Load(object sender, EventArgs e)
        {
            watcher.StatusChanged += Watcher_StatusChanged;
            bool found = false;
            int stopSearch = 0;
            while(found == false)
            {
                //Continuously search for device location until location is found.

                watcher.TryStart(false, TimeSpan.FromMilliseconds(2000));
                GeoCoordinate coord = watcher.Position.Location;
                stopSearch++;
                Debug.WriteLine("status: " + watcher.Status.ToString());

                if (coord.IsUnknown != true)
                {
                    Debug.WriteLine("Lat: {0}, Long: {1}",
                        coord.Latitude,
                        coord.Longitude);
                    latitude = coord.Latitude;
                    longitute = coord.Longitude;

                    found = true;
                }
                else
                {
                    Debug.WriteLine("Unknown latitude and longitude.");
                }
                if(stopSearch >= 100)
                {
                    found = true;
                }
                Thread.Sleep(100);
            }



            WoolworthsResults = new ObservableCollection<Result>();
            PicknPayResults = new ObservableCollection<Result>();
            SpaResults = new ObservableCollection<Result>();
            CheckersResults = new ObservableCollection<Result>();
            DisplayStores = new List<StoreNearYou>();

            PopulateStores();
        }


        private async void PopulateStores()
        {
            //Populate collections with results from MapAPI class

            await mapsAPI.PopulateMaps(WoolworthsResults, Convert.ToDouble(latitude), 
                Convert.ToDouble(longitute), "woolworths");
            await mapsAPI.PopulateMaps(PicknPayResults, Convert.ToDouble(latitude),
                Convert.ToDouble(longitute), "PicknPay");
            await mapsAPI.PopulateMaps(SpaResults, Convert.ToDouble(latitude),
                Convert.ToDouble(longitute), "spar");
            await mapsAPI.PopulateMaps(CheckersResults, Convert.ToDouble(latitude),
                Convert.ToDouble(longitute), "checkers");
        }


        private List<StoreNearYou> GenerateDisplayingList(ObservableCollection<Result> results, string storeID)
        {
            //Generate output to display to customer: store name, distance from device
            //and whether store is open now.

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
                    item.geometry.location.lat, item.geometry.location.lng).ToString("0") + "km from you",
                    StoreID = storeID
                }); ;
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
            //Calculate distance between store and location of device

            var sCoords = new GeoCoordinate(sLatitude, sLongitude);
            var eCoords = new GeoCoordinate(eLatitude, eLongitude);
            return sCoords.GetDistanceTo(eCoords) / 1000;
        }

        private void CbxStoreName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                bs.DataSource = null;
                dgvStoresDisplay.DataSource = null;

                //Display logos and results based on selected choice in comboBox

                switch (cbxStoreName.SelectedIndex)
                {
                    case 0:
                        pbStoreLogo.ImageLocation = "woolworths.jpg";
                        bs.DataSource = GenerateDisplayingList(WoolworthsResults,"Woolworths");
                        break;
                    case 1:
                        pbStoreLogo.ImageLocation = "picknpay.jpg";
                        bs.DataSource = GenerateDisplayingList(PicknPayResults, "Pick n Pay");
                        break;
                    case 2:
                        pbStoreLogo.ImageLocation = "spar.jpg";
                        bs.DataSource = GenerateDisplayingList(SpaResults,"Spar");
                        break;
                    case 3:
                        pbStoreLogo.ImageLocation = "checkers.jpg";
                        bs.DataSource = GenerateDisplayingList(CheckersResults,"Checkers");
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

        private void DgvStoresDisplay_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnMore_Click(object sender, EventArgs e)
        {
            try
            {
                var current = (StoreNearYou)bs.Current;
                bool found = false;
                int counter = 0;
                while(found == false && counter < displayingList.Count)
                {
                    if(displayingList[counter].Name == current.Name)
                    {
                        found = true;
                        frmStoreInformation info = new frmStoreInformation(displayingList[counter]);
                        info.Show();
                        this.Close();
                    }
                    else
                    {
                        counter++;
                    }
                }
                if(found == false)
                {
                    MessageBox.Show("Please select a store first.", "More Information"
                        , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
