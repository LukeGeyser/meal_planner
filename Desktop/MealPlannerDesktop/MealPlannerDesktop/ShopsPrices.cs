using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPlannerDesktop
{
    class ShopsPrices
    {
        private string shopname;
        private double productprice;

        public ShopsPrices(string shopname, double productprice)
        {
            this.Shopname = shopname;
            this.Productprice = productprice;
        }

        public string Shopname { get => shopname; set => shopname = value; }
        public double Productprice { get => productprice; set => productprice = value; }
    }
}
