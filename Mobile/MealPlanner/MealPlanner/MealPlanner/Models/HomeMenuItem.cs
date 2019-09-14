﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MealPlanner.Models
{
    public enum MenuItemType
    {
        Browse,
        About
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }

        public string IconSource { get; set; }

        public Type TargetType { get; set; }

        public string ColorHex { get; set; }

        public string TextColorHex { get; set; }

        public string RowDefinition { get; set; }
    }
}
