using MealPlanner.Models;
using MealPlanner.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MealPlanner.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppPreferencesPage : ContentPage
    {
        private ObservableCollection<AlergieListItem> allergies;
        public ObservableCollection<AlergieListItem> Alergies
        {
            get { return allergies; }
            set
            {
                allergies = value;
                OnPropertyChanged();
            }
        }
        public List<UserAllergies> selectedAllergies { get; set; }
        public List<Allergies> allAllergies { get; set; }
        DataHandler dh = new DataHandler();
        ViewCell lastCell;

        public AppPreferencesPage()
        {
            InitializeComponent();
            Alergies = new ObservableCollection<AlergieListItem>();
            selectedAllergies = dh.GetSelectedAllergies(SignInPage.loggedInUser.Username);
            allAllergies = dh.GetAllAllergies();


            for (int i = 0; i < allAllergies.Count; i++)
            {
                Alergies.Add(new AlergieListItem()
                {
                    Name = allAllergies[i].AllergyName,
                    Description = allAllergies[i].Description
                });
                bool found = false;
                int count = 0;
                while (found == false && count < selectedAllergies.Count)
                {
                    if (selectedAllergies[count].AllergyID == allAllergies[i].AllergyID)
                    {
                        found = true;
                        Alergies[i].IsChecked = true;
                    }
                    else
                    {
                        found = false;
                        count++;
                    }
                }
            }

            BindingContext = this;
        }

        private void AllergiesList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as AlergieListItem;
            Description.Text = item.Description;
            if (item.IsChecked == true)
            {
                Alergies[e.SelectedItemIndex].IsChecked = false;
            }
            else if (item.IsChecked == false)
            {
                Alergies[e.SelectedItemIndex].IsChecked = true;
            }
        }

        private void ViewCell_Tapped(object sender, EventArgs e)
        {
            if (lastCell != null)
                lastCell.View.BackgroundColor = Color.Transparent;
            var viewCell = (ViewCell)sender;
            if (viewCell.View != null)
            {
                viewCell.View.BackgroundColor = Color.FromHex("#d4d4d4");
                lastCell = viewCell;
            }
        }

        
    }
}