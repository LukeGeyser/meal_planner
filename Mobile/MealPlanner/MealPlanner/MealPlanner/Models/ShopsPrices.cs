using System;
using System.Collections.Generic;
using System.Text;

namespace MealPlanner.Models
{
    public class ShopsPrices
    {
        private string shopname;
        private double productprice;

        public string Shopname { get => shopname; set => shopname = value; }
        public double Productprice { get => productprice; set => productprice = value; }

        public ShopsPrices(string shopname, double productprice)
        {
            this.Shopname = shopname;
            this.Productprice = productprice;
        }
    }
}
