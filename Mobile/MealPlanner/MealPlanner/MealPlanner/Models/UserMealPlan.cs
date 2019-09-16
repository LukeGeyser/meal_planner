using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPlanner.Models
{
    public class UserMealPlan
    {
        private string username;
        private int mealPlanID;

        public string Username { get => username; set => username = value; }
        public int MealPlanID { get => mealPlanID; set => mealPlanID = value; }

        public UserMealPlan()
        {

        }

        public UserMealPlan(string un, int id)
        {
            username = un;
            mealPlanID = id;
        }
    }
}
