using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPlannerDesktop
{
    class Products
    {
        private int productID;
        private string productName, category, description, nutritionalValue, productImage;

        public int ProductID { get => productID; set => productID = value; }
        public string ProductName { get => productName; set => productName = value; }
        public string Category { get => category; set => category = value; }
        public string Description { get => description; set => description = value; }
        public string NutritionalValue { get => nutritionalValue; set => nutritionalValue = value; }
        public string ProductImage { get => productImage; set => productImage = value; }

        public Products()
        {

        }

        public Products(int id, string name, string cat, string des, string nutrition, string image)
        {
            productID = id;
            productName = name;
            category = cat;
            description = des;
            nutritionalValue = nutrition;
            productImage = image;
        }
    }
}
