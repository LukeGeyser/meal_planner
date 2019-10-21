using MealPlanner.Models;
using MealPlanner.Services;
using MealPlanner.ViewModels;
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
    public partial class SelectedRecipePage : ContentPage
    {

        public RecipesViewModel RecipeInfoViewModel { get; set; }

        private List<Products> allProducts { get; set; }

        private ObservableCollection<Products> displayProducts { get; set; }
        public ObservableCollection<Products> DisplayProducts
        {
            get { return displayProducts; }
            set
            {
                displayProducts = value;
                OnPropertyChanged();
            }
        }

        public SelectedRecipePage(RecipesViewModel viewModel)
        {
            InitializeComponent();
            RecipeInfoViewModel = viewModel;
            DisplayProducts = new ObservableCollection<Products>();
            AddToDisplayingProducts(RecipeInfoViewModel.Products);

            BindingContext = this;
        }

        #region Private Helpers

        private void AddToDisplayingProducts(List<Products> products)
        {
            foreach (var item in products)
            {
                DisplayProducts.Add(item);
            }
        }

        #endregion

        private void ProductNutritionInfo_Tapped(object sender, EventArgs e)
        {

        }
    }
}