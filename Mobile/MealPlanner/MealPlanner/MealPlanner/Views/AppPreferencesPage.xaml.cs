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

            Task.Run(async () =>
            {
                Alergies = new ObservableCollection<AlergieListItem>();
                MealPlans = new ObservableCollection<MealPlanListItem>();
                selectedAllergies = await dh.GetSelectedAllergies(SignInPage.loggedInUser.Username);
                selectedMealPlans = await dh.GetSelectedMealPlans(SignInPage.loggedInUser.Username);
                allAllergies = await dh.GetAllAllergies();
                allMealPlans = await dh.GetAllMealPlans();


                for (int i = 0; i < allAllergies.Count; i++)
                {
                    Alergies.Add(new AlergieListItem()
                    {
                        id = allAllergies[i].AllergyID,
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
                        id = allMealPlans[i].MealPlanID,
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

                MessagingCenter.Subscribe<AddAllergyPage, AlergieListItem>(this, "AddedAllergy", (obj, item) =>
                {
                    var newItem = item as AlergieListItem;
                    Alergies.Add(newItem);
                });

                MessagingCenter.Subscribe<AddMealPlanPage, MealPlanListItem>(this, "AddedMealPlan", (obj, item) =>
                {
                    var newItem = item as MealPlanListItem;
                    MealPlans.Add(newItem);
                });
            });

            BindingContext = this;
        }

        private void AllergiesList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            MealPlanList.SelectedItem = null;

            Task.Run(async () =>
            {

                var item = e.SelectedItem as AlergieListItem;
                if (item != null)
                {
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
            });

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

        private void AllergiesInfo_Tapped(object sender, EventArgs e)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                if (allergyDescription == "") DisplayAlert("Oops", "Please Select an Allergy to Display its Description", "Close");
                else if (allergyDescription != "") DisplayAlert("Allergy Info", $"{allergyDescription}", "Close");
            });
        }

        private void MealPlanList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Task.Run(async () =>
            {
                AllergiesList.SelectedItem = null;
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

        private void MealViewCell_Tapped(object sender, EventArgs e)
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

        async private void AddAllergy_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddAllergyPage());
        }

        async private void AddMealPlan_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddMealPlanPage());
        }

        private void Save_Clicked(object sender, EventArgs e)
        {
            Task.Run(async () =>
            {
                await dh.RemoveAllPreferences(SignInPage.loggedInUser.Username);
                for (int i = 0; i < allergies.Count; i++)
                {
                    if (allergies[i].IsChecked == true)
                    {
                        await dh.AddSelectedAllergy(SignInPage.loggedInUser.Username, new Allergies()
                        {
                            AllergyID = allergies[i].id,
                            AllergyName = allergies[i].Name,
                            Description = allergies[i].Description
                        });
                    }
                }
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
            });
        }

    }
}