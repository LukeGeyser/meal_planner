using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPlannerDesktop
{
    class MealPlans
    {
        private int mealPlanID;
        private string mealPlanName, description, advantages, disadvantages;

        public int MealPlanID { get => mealPlanID; set => mealPlanID = value; }
        public string MealPlanName { get => mealPlanName; set => mealPlanName = value; }
        public string Description { get => description; set => description = value; }
        public string Advantages { get => advantages; set => advantages = value; }
        public string Disadvantages { get => disadvantages; set => disadvantages = value; }

        public MealPlans()
        {

        }

        public MealPlans(int id, string name, string des, string advantage, string disadvantage)
        {
            mealPlanID = id;
            mealPlanName = name;
            description = des;
            advantages = advantage;
            disadvantages = disadvantage;
        }
    }
}
