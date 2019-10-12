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

        private ObservableCollection<RecipesViewModel> allRecipes { get; set; }
        public ObservableCollection<RecipesViewModel> AllRecipes
        {
            get { return allRecipes; }
            set
            {
                allRecipes = value;
                OnPropertyChanged();
            }
        }

        private List<Products> allProducts { get; set; }
        List<RecipeMealPlans> recipeMealPlans { get; set; }
        List<RecipeAllergies> recipeAllergies { get; set; }

        public RecipesPage()
        {
            InitializeComponent();
            AllRecipes = new ObservableCollection<RecipesViewModel>();
            Task.Run(async () =>
            {
                List<RecipesViewModel> recipes = await new DataHandler().GetAllRecipes();
                AddToObservableRecipes(recipes);
                allProducts = await new DataHandler().GetAllProducts();

                foreach (var item in allRecipes)
                {
                    item.Products = await GetRecipeProducts(item.RecipeID);
                }

                Device.BeginInvokeOnMainThread(() =>
                {
                    DisplayAlert("", $"{allRecipes.Count}", "k");
                });


                BindingContext = this;
            });
        }

        private void AddToObservableRecipes(List<RecipesViewModel> recipes)
        {
            foreach (var item in recipes)
            {
                AllRecipes.Add(item);
            }
        }

        #region Private Helpers


        public async Task<List<Products>> GetRecipeProducts(int recipeID)
        {
            List<Products> p = new List<Products>();
            await Task.Run(async () =>
            {
                List<RecipeProducts> temp = await new DataHandler().GetRecipeProducts(recipeID);
                
                foreach (var prod in allProducts)
                {
                    foreach (var item in temp)
                    {
                        if (prod.ProductID == item.ProductID)
                        {
                            p.Add(prod);
                        }
                    }
                }
            });
            return p;
        }

        #endregion

    }
}