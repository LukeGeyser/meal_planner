using MealPlanner.Models;
using MealPlanner.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MealPlanner.ViewModels
{
    public class RecipesViewModel : INotifyPropertyChanged
    {
        private int recipeID { get; set; }
        private string recipeName { get; set; }
        private string shortDescription { get; set; }
        private string instructions { get; set; }
        private string difficulty { get; set; }
        private int timeToPrepare { get; set; }
        private string imagePreview { get; set; }

        private List<Products> products { get; set; }

        public int RecipeID
        {
            get { return recipeID; }
            set
            {
                recipeID = value;
                OnPropertyChanged();
            }
        }
        public string RecipeName
        {
            get { return recipeName; }
            set
            {
                recipeName = value;
                OnPropertyChanged();
            }
        }
        public string ShortDescription
        {
            get { return shortDescription; }
            set
            {
                shortDescription = value;
                OnPropertyChanged();
            }
        }
        public string Instructions
        {
            get { return instructions; }
            set
            {
                instructions = value;
                OnPropertyChanged();
            }
        }
        public string Difficulty
        {
            get { return difficulty; }
            set
            {
                difficulty = value;
                OnPropertyChanged();
            }
        }
        public int TimeToPrepare
        {
            get { return timeToPrepare; }
            set
            {
                timeToPrepare = value;
                OnPropertyChanged();
            }
        }
        public string ImagePreview
        {
            get { return imagePreview; }
            set
            {
                imagePreview = value;
                OnPropertyChanged();
            }
        }

        public List<Products> Products
        {
            get { return products; }
            set
            {
                products = value;
                OnPropertyChanged();
            }
        }

        public RecipesViewModel()
        {

        }

        public RecipesViewModel(int id, string name, string des, string instruct, string difficult, int time, string imagePreview)
        {
            recipeID = id;
            recipeName = name;
            shortDescription = des;
            instructions = instruct;
            difficulty = difficult;
            timeToPrepare = time;
            this.imagePreview = imagePreview;
            //GetRecipeProducts();
        }

        public async Task GetRecipeProducts()
        {
            await Task.Run(async () =>
            {
                List<RecipeProducts> temp = await (new DataHandler().GetRecipeProducts(this.recipeID));
                foreach (var item in temp)
                {
                    products.Add(await (new DataHandler().GetSpecificProducts(item.ProductID)));
                }
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
