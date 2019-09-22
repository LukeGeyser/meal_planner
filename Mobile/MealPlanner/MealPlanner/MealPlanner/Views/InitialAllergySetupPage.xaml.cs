using MealPlanner.Models;
using MealPlanner.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MealPlanner.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InitialAllergySetupPage : ContentPage
    {

        private string allergyDescription { get; set; } = "";

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

        public InitialAllergySetupPage()
        {
            InitializeComponent();

            Task.Run(async () =>
            {
                Alergies = new ObservableCollection<AlergieListItem>();

                allAllergies = await dh.GetAllAllergies();

                for (int i = 0; i < allAllergies.Count; i++)
                {
                    Alergies.Add(new AlergieListItem()
                    {
                        id = allAllergies[i].AllergyID,
                        Name = allAllergies[i].AllergyName,
                        Description = allAllergies[i].Description
                    });
                }
            });
            BindingContext = this;
        }

        private void AllergiesList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Task.Run(async () =>
            {
                var item = e.SelectedItem as AlergieListItem;
                if (item != null)
                {
                    allergyDescription = item.Description;
                    if (item.IsChecked == true)
                    {
                        Alergies[e.SelectedItemIndex].IsChecked = false;
                    }
                    else if (item.IsChecked == false)
                    {
                        Alergies[e.SelectedItemIndex].IsChecked = true;
                    }
                }
            });
            
        }

        private void AllergiesInfo_Tapped(object sender, EventArgs e)
        {
            Task.Run(async () =>
            {
                if (allergyDescription == "") await DisplayAlert("Oops", "Please Select an Allergy to Display its Description", "Close");
                else if (allergyDescription != "") await DisplayAlert("Allergy Info", $"{allergyDescription}", "Close");
            });
        }

        private void ViewCell_Tapped(object sender, EventArgs e)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                if (lastCell != null)
                    lastCell.View.BackgroundColor = Color.Transparent;
                var viewCell = (ViewCell)sender;
                if (viewCell.View != null)
                {
                    viewCell.View.BackgroundColor = Color.FromHex("#d4d4d4");
                    lastCell = viewCell;
                }
            });
        }

        private void Save_Clicked(object sender, EventArgs e)
        {
            Task.Run(async () =>
            {
                await dh.RemoveAllPreferences(SignInPage.loggedInUser.Username);
                for (int i = 0; i < allergies.Count; i++)
                {
                    if (allergies[i].IsChecked == true)
                    {
                        await dh.AddSelectedAllergy(SignInPage.loggedInUser.Username, new Allergies()
                        {
                            AllergyID = allergies[i].id,
                            AllergyName = allergies[i].Name,
                            Description = allergies[i].Description
                        });
                    }
                }
            });
        }
    }
}