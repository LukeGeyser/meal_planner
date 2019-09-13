using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPlannerDesktop
{
    class UserAllergies
    {
        private string username;
        private int allergyID;

        public string Username { get => username; set => username = value; }
        public int AllergyID { get => allergyID; set => allergyID = value; }

        public UserAllergies()
        {

        }

        public UserAllergies(string un, int id)
        {
            username = un;
            allergyID = id;
        }
    }
}
