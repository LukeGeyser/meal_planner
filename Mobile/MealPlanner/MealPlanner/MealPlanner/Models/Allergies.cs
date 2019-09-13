using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPlannerDesktop
{
    class Allergies
    {
        private int allergyID;
        private string allergyName, description;

        public int AllergyID { get => allergyID; set => allergyID = value; }
        public string AllergyName { get => allergyName; set => allergyName = value; }
        public string Description { get => description; set => description = value; }

        public Allergies()
        {

        }

        public Allergies(int id, string name, string des)
        {
            allergyID = id;
            allergyName = name;
            description = des;
        }
    }
}
