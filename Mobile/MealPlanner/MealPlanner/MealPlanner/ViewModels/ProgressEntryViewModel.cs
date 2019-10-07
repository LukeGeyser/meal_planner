using MealPlanner.Models;
using MealPlanner.Services;
using MealPlanner.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MealPlanner.ViewModels
{
    class ProgressEntryViewModel : BaseViewModel
    {
        public List<ProgressEntry> progress { get; set; }
        public List<ProgressEntry> Progress
        {
            get { return progress; }
            set
            {
                progress = value;
                OnPropertyChanged();
            }
        }

        public ProgressEntryViewModel()
        {
            //Progress = new List<ProgressEntry>();

            //Progress.Add(new ProgressEntry { Username = "Test", Weight = 10, Dob = DateTime.Now});
            //Progress.Add(new ProgressEntry { Username = "Test", Weight = 11, Dob = DateTime.Now.AddDays(1) });
            //Progress.Add(new ProgressEntry { Username = "Test", Weight = 14, Dob = DateTime.Now.AddDays(5) });
            //Progress.Add(new ProgressEntry { Username = "Test", Weight = 17, Dob = DateTime.Now.AddDays(7) });

            progress = new DataHandler().GetProgress(SignInPage.loggedInUser);
        }

    }
}
