using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPlanner.Models
{
    class RecipeProducts
    {
        private int recipeID, productID;

        public int RecipeID { get => recipeID; set => recipeID = value; }
        public int ProductID { get => productID; set => productID = value; }

        public RecipeProducts()
        {

        }

        public RecipeProducts(int recipe, int product)
        {
            recipeID = recipe;
            productID = product;
        }
    }
}
