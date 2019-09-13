using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPlannerDesktop
{
    class ShopProducts
    {
        private int shopID, productID;
        private double price;

        public int ShopID { get => shopID; set => shopID = value; }
        public int ProductID { get => productID; set => productID = value; }
        public double Price { get => price; set => price = value; }

        public ShopProducts()
        {

        }

        public ShopProducts(int shop, int prod, double price)
        {
            shopID = shop;
            productID = prod;
            this.price = price;
        }
    }
}
