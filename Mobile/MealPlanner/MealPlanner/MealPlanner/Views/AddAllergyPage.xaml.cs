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
    public partial class AddAllergyPage : ContentPage
    {
        AlergieListItem allergies { get; set; }
        DataHandler dh = new DataHandler();

        public AddAllergyPage()
        {
            InitializeComponent();
        }

        async private void AddAllergy_Clicked(object sender, EventArgs e)
        {
            allergies = new AlergieListItem()
            {
                Name = AllergyName.Text,
                Description = AllergyDescription.Text,
                IsChecked = true
            };
            if (allergies != null)
            {
                dh.AddAllergy(new Allergies()
                {
                    AllergyName = allergies.Name,
                    Description = allergies.Description
                });
                dh.GetSelectedAllergie(allergies.Name);
                allergies.id = dh.GetSelectedAllergie(allergies.Name).AllergyID;
                MessagingCenter.Send(this, "AddedAllergy", allergies);
                DisplayAlert("Success", "Allergy Added", "Close");
                await Navigation.PopAsync();
            }
        }
    }
}