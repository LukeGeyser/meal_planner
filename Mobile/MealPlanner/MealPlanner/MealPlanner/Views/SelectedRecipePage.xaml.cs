using MealPlanner.ViewModels;
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
    public partial class SelectedRecipePage : ContentPage
    {

        public RecipesViewModel RecipeInfoViewModel { get; set; }

        public SelectedRecipePage(RecipesViewModel viewModel)
        {
            InitializeComponent();
            RecipeInfoViewModel = viewModel;

            BindingContext = this;
        }

    }
}