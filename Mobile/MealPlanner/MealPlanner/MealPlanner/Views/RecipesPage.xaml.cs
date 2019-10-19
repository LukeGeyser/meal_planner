﻿using MealPlanner.Models;
using MealPlanner.Services;
using MealPlanner.ViewModels;
using Syncfusion.SfKanban.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Settings;
using Plugin.Settings.Abstractions;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Diagnostics;

namespace MealPlanner.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecipesPage : ContentPage
    {

        static ISettings AppSettings
        {
            get { return CrossSettings.Current; }
        }

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

        public bool PreferencesEnabled
        {
            get => AppSettings.GetValueOrDefault("PreferencesEnabled", false);
            set
            {
                AppSettings.AddOrUpdateValue("PreferencesEnabled", value);
                OnPropertyChanged();
            }
        }

        private List<Products> allProducts { get; set; }
        List<RecipeMealPlans> recipeMealPlans { get; set; }
        List<RecipeAllergies> recipeAllergiesList { get; set; }


        public RecipesPage()
        {
            InitializeComponent();
            PreferencesEnabled = false;
            AllRecipes = new ObservableCollection<RecipesViewModel>();
            Task.Run(async () =>
            {
                if (PreferencesEnabled == true)
                {
                    await PrepareUserPreferences();
                }
                else if (PreferencesEnabled == false)
                {
                    await PrepareWithoutUserPreferences();
                }
            });
            BindingContext = this;
        }

        #region Private Helpers

        private void AddToObservableRecipes(List<RecipesViewModel> recipes)
        {
            AllRecipes.Clear();
            foreach (var item in recipes)
            {
                AllRecipes.Add(item);
            }
            int d = 2;
        }

        private async Task<List<Products>> GetRecipeProducts(int recipeID)
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

        private async Task PrepareUserPreferences()
        {
            recipeAllergiesList = await new DataHandler().GetRecipeAllergiesAll();
            recipeMealPlans = await new DataHandler().GetAllRecipeMealplans();

            List<RecipesViewModel> recipes = new List<RecipesViewModel>();

            if (AllRecipes.Count != 0) recipes = AllRecipes.ToList();
            else recipes = await GetRecipes();

            for (int i = 0; i < recipeAllergiesList.Count; i++)
            {
                for (int j = 0; j < SignInPage.loggedInUser.Allergies.Count; j++)
                {
                    if (recipeAllergiesList[i].AllergyID == SignInPage.loggedInUser.Allergies[j].AllergyID)
                    {
                        recipes.RemoveAt(recipes.FindIndex(res => res.RecipeID == recipeAllergiesList[i].RecipeID));
                    }
                }
            }

            AddToObservableRecipes(recipes);
        }

        private async Task PrepareWithoutUserPreferences()
        {
            List<RecipesViewModel> recipes = await new DataHandler().GetAllRecipes();
            AddToObservableRecipes(recipes);
            allProducts = await new DataHandler().GetAllProducts();

            foreach (var item in allRecipes)
            {
                item.Products = await GetRecipeProducts(item.RecipeID);
            }
        }

        private async Task<List<RecipesViewModel>> GetRecipes()
        {
            List<RecipesViewModel> recipes = await new DataHandler().GetAllRecipes();
            allProducts = await new DataHandler().GetAllProducts();

            foreach (var item in allRecipes)
            {
                item.Products = await GetRecipeProducts(item.RecipeID);
            }
            return recipes;
        }

        #endregion

        private async void Preferences_StateChanging(object sender, Syncfusion.XForms.Buttons.SwitchStateChangingEventArgs e)
        {
            Preferences.IsBusy = true;
            PreferencesEnabled = Convert.ToBoolean(e.NewValue);
            if (PreferencesEnabled == true)
            {
                await PrepareUserPreferences();
                await DisplayAlert("Preferences Enabled!", "Now displaying Recipes fit for your user preferences", "Got It!");
            }
            else if (PreferencesEnabled == false)
            {
                await PrepareWithoutUserPreferences();
                await DisplayAlert("Preferences Disabled!", "Now displaying all Recipes", "Got It!");
            }
            Preferences.IsBusy = false;
        }

        
    }
}