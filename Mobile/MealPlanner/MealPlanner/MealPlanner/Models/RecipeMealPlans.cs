using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPlanner.Models
{
    class RecipeMealPlans
    {
        private int recipeID, mealPlanID;

        public int RecipeID { get => recipeID; set => recipeID = value; }
        public int MealPlanID { get => mealPlanID; set => mealPlanID = value; }

        public RecipeMealPlans()
        {

        }

        public RecipeMealPlans(int recipe, int meal)
        {
            recipeID = recipe;
            mealPlanID = meal;
        }
    }
}
