using System;
using System.Collections.Generic;
using System.Text;

namespace MealPlanner.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        SignIn,
        SignUp
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
