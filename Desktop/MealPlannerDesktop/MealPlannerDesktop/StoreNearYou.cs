using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPlannerDesktop
{
    class StoreNearYou
    {
        private string name;
        private string distance;
        private string status;

        public StoreNearYou(string name, string distance, string status)
        {
            this.Name = name;
            this.Distance = distance;
            this.Status = status;
        }

        public string Name { get => name; set => name = value; }
        public string Distance { get => distance; set => distance = value; }
        public string Status { get => status; set => status = value; }
    }
}
