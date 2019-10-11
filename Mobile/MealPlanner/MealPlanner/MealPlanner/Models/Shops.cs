using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPlanner.Models
{
    public class Shops
    {
        private int shopID;
        private string shopName, website, phone, email;

        public int ShopID { get => shopID; set => shopID = value; }
        public string ShopName { get => shopName; set => shopName = value; }
        public string Website { get => website; set => website = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }

        public Shops()
        {

        }

        public Shops(int id, string name, string website, string phn, string em)
        {
            shopID = id;
            shopName = name;
            this.website = website;
            phone = phn;
            email = em;
        }
    }
}
