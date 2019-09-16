using MealPlanner.Models;
using MealPlanner.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MealPlanner.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppPreferencesPage : ContentPage
    {

        private string allergyDescription { get; set; } = "";
        private string mealPlanDescription { get; set; } = "";
        private string mealPlanAdvantage { get; set; } = "";
        private string mealPlandisadvantage { get; set; } = "";

        private ObservableCollection<AlergieListItem> allergies;
        public ObservableCollection<AlergieListItem> Alergies
        {
            get { return allergies; }
            set
            {
                allergies = value;
                OnPropertyChanged();
            }
        }

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

        public List<UserAllergies> selectedAllergies { get; set; }
        public List<UserMealPlan> selectedMealPlans { get; set; }
        public List<Allergies> allAllergies { get; set; }
        public List<MealPlans> allMealPlans { get; set; }

        DataHandler dh = new DataHandler();
        ViewCell lastCell;

        public AppPreferencesPage()
        {
            InitializeComponent();
            Alergies = new ObservableCollection<AlergieListItem>();
            MealPlans = new ObservableCollection<MealPlanListItem>();
            selectedAllergies = dh.GetSelectedAllergies(SignInPage.loggedInUser.Username);
            selectedMealPlans = dh.GetSelectedMealPlans(SignInPage.loggedInUser.Username);
            allAllergies = dh.GetAllAllergies();
            allMealPlans = dh.GetAllMealPlans();


            for (int i = 0; i < allAllergies.Count; i++)
            {
                Alergies.Add(new AlergieListItem()
                {
                    Name = allAllergies[i].AllergyName,
                    Description = allAllergies[i].Description
                });
                bool found = false;
                int count = 0;
                while (found == false && count < selectedAllergies.Count)
                {
                    if (selectedAllergies[count].AllergyID == allAllergies[i].AllergyID)
                    {
                        found = true;
                        Alergies[i].IsChecked = true;
                    }
                    else
                    {
                        found = false;
                        count++;
                    }
                }
            }

            for (int i = 0; i < allMealPlans.Count; i++)
            {
                MealPlans.Add(new MealPlanListItem()
                {
                    Name = allMealPlans[i].MealPlanName,
                    Description = allMealPlans[i].Description,
                    Advantage = allMealPlans[i].Advantages,
                    Disadvantage = allMealPlans[i].Disadvantages
                });
                bool found = false;
                int count = 0;
                while (found == false && count < selectedMealPlans.Count)
                {
                    if (selectedMealPlans[count].MealPlanID == allMealPlans[i].MealPlanID)
                    {
                        found = true;
                        MealPlans[i].IsChecked = true;
                    }
                    else
                    {
                        found = false;
                        count++;
                    }
                }
            }

            BindingContext = this;
        }

        private void AllergiesList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as AlergieListItem;
            allergyDescription = item.Description;
            if (item.IsChecked == true)
            {
                Alergies[e.SelectedItemIndex].IsChecked = false;
            }
            else if (item.IsChecked == false)
            {
                Alergies[e.SelectedItemIndex].IsChecked = true;
            }
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

        private void AllergiesInfo_Tapped(object sender, EventArgs e)
        {
            if (allergyDescription == "") DisplayAlert("Oops", "Please Select an Allergy to Display its Description", "Close");
            else if (allergyDescription != "") DisplayAlert("Allergy Info", $"{allergyDescription}", "Close");
        }

        private void MealPlanList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MealPlanListItem;
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

        private void MealViewCell_Tapped(object sender, EventArgs e)
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

        private void MealPlanInfo_Tapped(object sender, EventArgs e)
        {
            if (mealPlanDescription == "") DisplayAlert("Oops", "Please Select an Meal Plan to display its info", "Close");
            else if (mealPlanDescription != "") DisplayAlert("Meal Plan Info", $"{mealPlanDescription}", "Close");
        }

        private void MealPlanAdvantages_Tapped(object sender, EventArgs e)
        {
            if (mealPlanAdvantage == "") DisplayAlert("Oops", "Please Select an Meal Plan to display its advantage", "Close");
            else if (mealPlanAdvantage != "") DisplayAlert("Meal Plan Advantage", $"{mealPlanAdvantage}", "Close");
        }

        private void MealPlanDisadvantages_Tapped(object sender, EventArgs e)
        {
            if (mealPlandisadvantage == "") DisplayAlert("Oops", "Please Select an Meal Plan to display its disadvantage", "Close");
            else if (mealPlandisadvantage != "") DisplayAlert("Meal Plan Disadvantage", $"{mealPlandisadvantage}", "Close");
        }

        
    }
}