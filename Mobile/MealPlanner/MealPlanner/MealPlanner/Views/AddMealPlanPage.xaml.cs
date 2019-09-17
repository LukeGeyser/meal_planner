using MealPlanner.Models;
using MealPlanner.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MealPlanner.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddMealPlanPage : ContentPage
    {

        MealPlanListItem mealPlan { get; set; }
        DataHandler dh = new DataHandler();

        public AddMealPlanPage()
        {
            InitializeComponent();
        }

        async private void AddMealPlan_Clicked(object sender, EventArgs e)
        {
            mealPlan = new MealPlanListItem()
            {
                Name = MealPlanName.Text,
                Description = MealPlanDescription.Text,
                Advantage = MealPlanAdvantage.Text,
                Disadvantage = MealPlanDisadvantages.Text,
                IsChecked = true
            };
            if (mealPlan != null)
            {
                dh.AddMealPlan(new MealPlans()
                {
                    MealPlanName = mealPlan.Name,
                    Description = mealPlan.Description,
                    Advantages = mealPlan.Advantage,
                    Disadvantages = mealPlan.Disadvantage
                });
                mealPlan.id = dh.GetSelectedMealPlan(mealPlan.Name).MealPlanID;
                MessagingCenter.Send(this, "AddedMealPlan", mealPlan);
                DisplayAlert("Success", "Meal Plan Added", "Close");
                await Navigation.PopAsync();
            }
        }
    }
}