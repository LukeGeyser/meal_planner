using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPlanner.Models
{
    class Location
    {
        private string username, address;
        private int shopID;

        public string Username { get => username; set => username = value; }
        public string Address { get => address; set => address = value; }
        public int ShopID { get => shopID; set => shopID = value; }

        public Location()
        {

        }

        public Location(string Un, string add, int id)
        {
            username = Un;
            address = add;
            shopID = id;
        }
    }
}
