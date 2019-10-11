using Syncfusion.SfKanban.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MealPlanner.ViewModels
{
    class ViewModel
    {
        public ObservableCollection<KanbanModel> Cards { get; set; }
        public ViewModel()
        {
            Cards = new ObservableCollection<KanbanModel>();
            Cards.Add(new KanbanModel()
            {
                ID = 1,
                Title = "iOS - 1002",
                ImageURL = "Image1.png",
                Category = "Open",
                Description = "Analyze customer requirements",
                ColorKey = "Red",
                Tags = new string[] { "Incident", "Customer" }
            });
            Cards.Add(new KanbanModel()
            {
                ID = 6,
                Title = "Xamarin - 4576",
                ImageURL = "Image2.png",
                Category = "Open",
                Description = "Show the retrieved data from the server in grid control",
                ColorKey = "Green",
                Tags = new string[] { "Story", "Customer" }
            });
            Cards.Add(new KanbanModel()
            {
                ID = 13,
                Title = "UWP - 13",
                ImageURL = "Image4.png",
                Category = "In Progress",
                Description = "Add responsive support to application",
                ColorKey = "Brown",
                Tags = new string[] { "Story", "Customer" }
            });
            Cards.Add(new KanbanModel()
            {
                ID = 2543,
                Title = "Xamarin_iOS - 2543",
                Category = "Code Review",
                ImageURL = "Image3.png",
                Description = "Check login page validation",
                ColorKey = "Brown",
                Tags = new string[] { "Story", "Customer" }
            });
        }
    }
}
