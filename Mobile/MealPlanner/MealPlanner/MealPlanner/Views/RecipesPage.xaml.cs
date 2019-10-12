using MealPlanner.Models;
using MealPlanner.Services;
using MealPlanner.ViewModels;
using Syncfusion.SfKanban.XForms;
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
    public partial class RecipesPage : ContentPage
    {

        List<RecipesViewModel> allRecipes { get; set; }
        List<RecipeMealPlans> recipeMealPlans { get; set; }
        List<RecipeAllergies> recipeAllergies { get; set; }
        List<Products> products { get; set; }

        public RecipesPage()
        {
            InitializeComponent();
            Task.Run(async () =>
            {
                allRecipes = await(new DataHandler().GetAllRecipes());
            });

            Task.Run(async () =>
            {
                foreach (var item in allRecipes)
                {
                    await item.GetRecipeProducts();
                }
            });

            //DisplayAlert($"{allRecipes[0].Products[0].ProductID}", $"{allRecipes.Count}", "k");

            BindingContext = this;
        }

        #region Private Helpers

        private void AllRecipes()
        {
            //allRecipes = new DataHandler().GetAllRecipes();
        }

        #endregion

    }
}