using MealPlanner.Models;
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

        public RecipesPage()
        {
            InitializeComponent();
        }
    }
}