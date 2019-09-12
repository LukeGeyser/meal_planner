using MealPlanner.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static MealPlanner.Models.MapResultDataWrapper;

namespace MealPlanner.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        string url = String.Format("https://maps.googleapis.com/maps/api/place/nearbysearch/json?");

        private const string _PrivateKey = "AIzaSyCxTWHUpzXjM1twanD2-wMkYCBRnx7v7DE";

        public MainPage()
        {
            InitializeComponent();

            CenterLabels();

            string completeUrl = String.Format("{0}location={1},{2}&radius={3}&type={4}&key={5}", url, -26.152755799999998, 28.3111148, 10000, "supermarket", _PrivateKey);
            Debug.WriteLine(completeUrl);
        }



        #region Private Helpers

        private void CenterLabels()
        {
            Func<RelativeLayout, double> getVegWidth = (parent) => Veg.Measure(parent.Width, parent.Height).Request.Width;
            Func<RelativeLayout, double> getVegHeight = (parent) => Veg.Measure(parent.Width, parent.Height).Request.Height;

            Func<RelativeLayout, double> getPescWidth = (parent) => Pesc.Measure(parent.Width, parent.Height).Request.Width;
            Func<RelativeLayout, double> getPescHeight = (parent) => Pesc.Measure(parent.Width, parent.Height).Request.Height;

            Func<RelativeLayout, double> getWeightLossWidth = (parent) => WeightLoss.Measure(parent.Width, parent.Height).Request.Width;
            Func<RelativeLayout, double> getWeightLossHeight = (parent) => WeightLoss.Measure(parent.Width, parent.Height).Request.Height;

            Func<RelativeLayout, double> getWeightGainWidth = (parent) => WeightGain.Measure(parent.Width, parent.Height).Request.Width;
            Func<RelativeLayout, double> getWeightGainHeight = (parent) => WeightGain.Measure(parent.Width, parent.Height).Request.Height;

            first.Children.Add(Veg, Constraint.RelativeToParent(parent => parent.Width / 2 - getVegWidth(parent) / 2),
                Constraint.RelativeToParent(parent => parent.Height / 2 - getVegHeight(parent) / 2));

            second.Children.Add(Pesc, Constraint.RelativeToParent(parent => parent.Width / 2 - getPescWidth(parent) / 2),
                Constraint.RelativeToParent(parent => parent.Height / 2 - getPescHeight(parent) / 2));

            third.Children.Add(WeightLoss, Constraint.RelativeToParent(parent => parent.Width / 2 - getWeightLossWidth(parent) / 2),
                Constraint.RelativeToParent(parent => parent.Height / 2 - getWeightLossHeight(parent) / 2));

            fourth.Children.Add(WeightGain, Constraint.RelativeToParent(parent => parent.Width / 2 - getWeightGainWidth(parent) / 2),
                Constraint.RelativeToParent(parent => parent.Height / 2 - getWeightGainHeight(parent) / 2));
        }

        private async void GetLocation()
        {
            try
            {
                var location = await Geolocation.GetLocationAsync();
                if (location != null)
                {
                    await DisplayAlert($"{location.Latitude.ToString()}", $"{location.Longitude.ToString()}", "Coolio");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion

        #region Public Events

        private void PescTapped_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("Pesc", "TAPPED", "okay");
        }

        private void VegTapped_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("Veg", "TAPPED", "okay");
            DisplayAlert(App.MapsResults[0].name, "", "OKAY");
        }

        private void LossTapped_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("Loss", "TAPPED", "okay");
        }

        private void GainTapped_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("Gain", "TAPPED", "okay");
        }

        #endregion

    }
}