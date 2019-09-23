using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPlannerDesktop
{
    class Shops
    {
        private int shopID;
        private string shopName, phone, email,website;

        public int ShopID { get => shopID; set => shopID = value; }
        public string ShopName { get => shopName; set => shopName = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public string Website { get => website; set => website = value; }

        public Shops()
        {

        }

        public Shops(int id, string name, string phn, string em,string web)
        {
            shopID = id;
            shopName = name;
            phone = phn;
            email = em;
            website = web;
        }
    }
}
