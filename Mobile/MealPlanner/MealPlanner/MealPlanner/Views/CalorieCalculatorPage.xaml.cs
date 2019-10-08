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
    public partial class CalorieCalculatorPage : ContentPage
    {

        private int mealsPerDay = 0;

        public CalorieCalculatorPage()
        {
            InitializeComponent();
            MealsPerDay.Text = mealsPerDay.ToString();
            Minus.IsEnabled = false;
            CalorieNeed.Text = GetCalories().ToString();
        }

        private void Minus_Clicked(object sender, EventArgs e)
        {
            if ((mealsPerDay == 1))
            {
                MealsPerDay.Text = "0";
                mealsPerDay = 0;
                Minus.IsEnabled = false;
            }
            else
            {
                mealsPerDay--;
                MealsPerDay.Text = mealsPerDay.ToString();
            }
        }

        private void Add_Clicked(object sender, EventArgs e)
        {
            if (MealsPerDay.Text == "0")
            {
                Minus.IsEnabled = true;
                mealsPerDay++;
                MealsPerDay.Text = mealsPerDay.ToString();
            }
            else
            {
                mealsPerDay++;
                MealsPerDay.Text = mealsPerDay.ToString();
            }
                
        }


        private void Calculate_Clicked(object sender, EventArgs e)
        {
            if (MealsPerDay.Text != "0") CalPerMeal.Text = Math.Round(double.Parse(CalorieNeed.Text) / int.Parse(MealsPerDay.Text), 2).ToString();
            else CalPerMeal.Text = "0";
        }

        #region Helper Functions

        private double GetCalories()
        {
            double weight = SignInPage.loggedInUser.Weight;
            double height = SignInPage.loggedInUser.Height;
            int age = SignInPage.loggedInUser.GetAge();
            return ((10 * weight + (6.25 * height) - (5 * age)) - 161);
        }

        #endregion

    }
}