using Android.Content;
using MealPlanner.Models;
using MealPlanner.Services;
using Syncfusion.SfChart.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MealPlanner.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TrackProgressPage : ContentPage
    {

        public List<ProgressEntry> progress { get; set; }
        public List<ProgressEntry> Progress
        {
            get { return progress; }
            set
            {
                progress = value;
                OnPropertyChanged();
            }
        }

        public TrackProgressPage()
        {
            InitializeComponent();

            //Progress = new List<ProgressEntry>();

            //Progress.Add(new ProgressEntry { Username = "Test", Weight = 10, Dob = DateTime.Now });
            //Progress.Add(new ProgressEntry { Username = "Test", Weight = 11, Dob = DateTime.Now.AddDays(1) });
            //Progress.Add(new ProgressEntry { Username = "Test", Weight = 14, Dob = DateTime.Now.AddDays(5) });
            //Progress.Add(new ProgressEntry { Username = "Test", Weight = 17, Dob = DateTime.Now.AddDays(7) });

            progress = new DataHandler().GetProgress(SignInPage.loggedInUser);

            BindingContext = this;
        }

        private void Update_Clicked(object sender, EventArgs e)
        {
            if (SignInPage.loggedInUser.PreviousWeightUpdate == null || (DateTime.Now.Subtract(SignInPage.loggedInUser.PreviousWeightUpdate).TotalDays) >= 1)
            {
                double weight = 0;
                try
                {
                    weight = Convert.ToDouble(Weight.Text);
                }
                catch (Exception)
                {
                    DisplayAlert("Oops", "Please Enter a Numeric value for Weight", "Got it!");
                }
                new DataHandler().UpdateUserProgress(SignInPage.loggedInUser.Username, weight);
                Task.Run(async () =>
                {
                    await new DataHandler().UpdateUserPreviosWeight(SignInPage.loggedInUser, DateTime.Now);
                });
                SignInPage.loggedInUser.PreviousWeightUpdate = DateTime.Now;
                SignInPage.loggedInUser.Weight = weight;
                new DataHandler().UpdateUserWeight(SignInPage.loggedInUser);

                Progress = new DataHandler().GetProgress(SignInPage.loggedInUser);
            }
            else if ((DateTime.Now.Subtract(SignInPage.loggedInUser.PreviousWeightUpdate).TotalDays) < 1)
            {
                DisplayAlert("Oops...", "You can only update your Wight every 24 hours", "Got it!");
            }
            
        }
    }
}