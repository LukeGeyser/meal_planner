using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPlanner.Models
{
    class Recipes
    {
        private int recipeID;
        private string recipeName, shortDescription, instructions, difficulty;
        private int timeToPrepare;

        public int RecipeID { get => recipeID; set => recipeID = value; }
        public string RecipeName { get => recipeName; set => recipeName = value; }
        public string ShortDescription { get => shortDescription; set => shortDescription = value; }
        public string Instructions { get => instructions; set => instructions = value; }
        public string Difficulty { get => difficulty; set => difficulty = value; }
        public int TimeToPrepare { get => timeToPrepare; set => timeToPrepare = value; }

        public Recipes()
        {

        }

        public Recipes(int id, string name, string des, string instruct, string difficult, int time)
        {
            recipeID = id;
            recipeName = name;
            shortDescription = des;
            instructions = instruct;
            difficulty = difficult;
            timeToPrepare = time;
        }
    }
}
