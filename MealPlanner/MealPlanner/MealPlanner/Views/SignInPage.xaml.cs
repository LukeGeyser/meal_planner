using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MealPlanner.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignInPage : ContentPage
    {
        public SignInPage()
        {
            InitializeComponent();
        }

        private void Sign_In_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("URGENT ALERT", $"Username: {Username.Text}, Password: {Password.Text}", "Coolio");
        }
    }
}