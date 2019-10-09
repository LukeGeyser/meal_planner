using MealPlanner.Models;
using MealPlanner.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MealPlanner.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InitialMealPlanSetupPage : ContentPage
    {

        private string mealPlanDescription { get; set; } = "";
        private string mealPlanAdvantage { get; set; } = "";
        private string mealPlandisadvantage { get; set; } = "";

        private ObservableCollection<MealPlanListItem> mealPlans;
        public ObservableCollection<MealPlanListItem> MealPlans
        {
            get { return mealPlans; }
            set
            {
                mealPlans = value;
                OnPropertyChanged();
            }
        }

        public List<MealPlans> allMealPlans { get; set; }

        DataHandler dh = new DataHandler();
        ViewCell lastCell;

        public InitialMealPlanSetupPage()
        {
            InitializeComponent();

            Task.Run(async () =>
            {
                MealPlans = new ObservableCollection<MealPlanListItem>();
                allMealPlans = await dh.GetAllMealPlans();

                for (int i = 0; i < allMealPlans.Count; i++)
                {
                    MealPlans.Add(new MealPlanListItem()
                    {
                        id = allMealPlans[i].MealPlanID,
                        Name = allMealPlans[i].MealPlanName,
                        Description = allMealPlans[i].Description,
                        Advantage = allMealPlans[i].Advantages,
                        Disadvantage = allMealPlans[i].Disadvantages
                    });
                }
            });
            BindingContext = this;
        }

        private void ViewCell_Tapped(object sender, EventArgs e)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                if (lastCell != null)
                    lastCell.View.BackgroundColor = Color.Transparent;
                var viewCell = (ViewCell)sender;
                if (viewCell.View != null)
                {
                    viewCell.View.BackgroundColor = Color.FromHex("#d4d4d4");
                    lastCell = viewCell;
                }
            });
        }

        private void MealPlanInfo_Tapped(object sender, EventArgs e)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                if (mealPlanDescription == "") DisplayAlert("Oops", "Please Select an Meal Plan to display its info", "Close");
                else if (mealPlanDescription != "") DisplayAlert("Meal Plan Info", $"{mealPlanDescription}", "Close");
            });
        }

        private void Save_Clicked(object sender, EventArgs e)
        {
            Task.Run(async () =>
            {
                for (int i = 0; i < mealPlans.Count; i++)
                {
                    if (mealPlans[i].IsChecked == true)
                    {
                        await dh.AddSelectedMealplans(SignInPage.loggedInUser.Username, new MealPlans()
                        {
                            MealPlanID = mealPlans[i].id,
                            MealPlanName = mealPlans[i].Name,
                            Description = mealPlans[i].Description,
                            Advantages = mealPlans[i].Advantage,
                            Disadvantages = mealPlans[i].Disadvantage
                        });
                    }
                }
                new DataHandler().UpdateUserProgress(SignInPage.loggedInUser.Username, SignInPage.loggedInUser.Weight);
            });
            Device.BeginInvokeOnMainThread(() =>
            {
                DisplayAlert("Success!", "Account Created successfully", "Got it");
                Application.Current.MainPage = new HomePage();
            });
        }

        private void MealPlanList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Task.Run(async () =>
            {
                var item = e.SelectedItem as MealPlanListItem;
                if (item != null)
                {
                    mealPlanDescription = item.Description;
                    mealPlanAdvantage = item.Advantage;
                    mealPlandisadvantage = item.Disadvantage;
                    if (item.IsChecked == true)
                    {
                        MealPlans[e.SelectedItemIndex].IsChecked = false;
                    }
                    else if (item.IsChecked == false)
                    {
                        MealPlans[e.SelectedItemIndex].IsChecked = true;
                    }
                }
            });
        }

        private void MealPlanAdvantages_Tapped(object sender, EventArgs e)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                if (mealPlanAdvantage == "") DisplayAlert("Oops", "Please Select an Meal Plan to display its advantage", "Close");
                else if (mealPlanAdvantage != "") DisplayAlert("Meal Plan Advantage", $"{mealPlanAdvantage}", "Close");
            });
        }

        private void MealPlanDisadvantages_Tapped(object sender, EventArgs e)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                if (mealPlandisadvantage == "") DisplayAlert("Oops", "Please Select an Meal Plan to display its disadvantage", "Close");
                else if (mealPlandisadvantage != "") DisplayAlert("Meal Plan Disadvantage", $"{mealPlandisadvantage}", "Close");
            });
        }
    }
}