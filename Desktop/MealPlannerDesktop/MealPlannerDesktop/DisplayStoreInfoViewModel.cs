using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MealPlannerDesktop
{
    public class DisplayStoreInfoViewModel : INotifyPropertyChanged
    {
        private string id { get; set; }
        private string name { get; set; }
        private bool opening_hours { get; set; }
        private string place_id { get; set; }
        private double lat { get; set; }
        private double lng { get; set; }
        private string distance { get; set; }
        private int price_level { get; set; }
        private double rating { get; set; }
        private int user_ratings_total { get; set; }
        private string vicinity { get; set; }
        private string icon_Source { get; set; }
        private string photo_Details { get; set; }
        private string storeID { get; set; }
        public string open_Text { get; set; }
        public string ColorHex { get; set; }


        public string StoreID
        {
            get { return storeID; }
            set
            {
                storeID = value;
                OnPropertyChanged();
            }
        }
        public string Photo_Details
        {
            get { return photo_Details; }
            set
            {
                photo_Details = value;
                OnPropertyChanged();
            }
        }


        public String Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged();
            }
        }
        public String Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }
        public Boolean Opening_Hours
        {
            get { return opening_hours; }
            set
            {
                opening_hours = value;
                OnPropertyChanged();
            }
        }
        public String Place_Id
        {
            get { return place_id; }
            set
            {
                place_id = value;
                OnPropertyChanged();
            }
        }
        public Double Lat
        {
            get { return lat; }
            set
            {
                lat = value;
                OnPropertyChanged();
            }
        }
        public Double Lng
        {
            get { return lng; }
            set
            {
                lng = value;
                OnPropertyChanged();
            }
        }
        public String Distance
        {
            get { return distance; }
            set
            {
                distance = value;
                OnPropertyChanged();
            }
        }
        public int Price_Level
        {
            get { return price_level; }
            set
            {
                price_level = value;
                OnPropertyChanged();
            }
        }
        public Double Rating
        {
            get { return rating; }
            set
            {
                rating = value;
                OnPropertyChanged();
            }
        }
        public int User_Ratings_Total
        {
            get { return user_ratings_total; }
            set
            {
                user_ratings_total = value;
                OnPropertyChanged();
            }
        }
        public String Vicinity
        {
            get { return vicinity; }
            set
            {
                vicinity = value;
                OnPropertyChanged();
            }
        }
        public String Icon_Source
        {
            get { return icon_Source; }
            set
            {
                icon_Source = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
