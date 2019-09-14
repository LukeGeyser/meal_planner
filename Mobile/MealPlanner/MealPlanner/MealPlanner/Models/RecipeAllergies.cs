using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPlanner.Models
{
    class RecipeAllergies
    {
        private int recipeID, allergyID;

        public int RecipeID { get => recipeID; set => recipeID = value; }
        public int AllergyID { get => allergyID; set => allergyID = value; }

        public RecipeAllergies()
        {

        }

        public RecipeAllergies(int recipe, int allergy)
        {
            recipeID = recipe;
            allergyID = allergy;
        }
    }
}
