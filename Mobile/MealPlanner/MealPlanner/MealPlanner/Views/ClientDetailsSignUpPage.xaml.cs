using MealPlanner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MealPlanner.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ClientDetailsSignUpPage : ContentPage
    {

        public static User signUpUser = SignUpPage.signUpUser;

        public ClientDetailsSignUpPage()
        {
            InitializeComponent();
        }

        private void Back_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new SignUpPage();
        }

        private void Next_Clicked(object sender, EventArgs e)
        {
            if (FName.Text == null || LName.Text == null ||  Email.Text == null)
            {
                DisplayAlert("Not filled In", "Not all field are filled in...", "Got it!");
            }
            else if (FName.Text != null && LName.Text != null && Email.Text != null)
            {
                if (IsValidEmail(Email.Text) == false)
                    DisplayAlert("Email Not Correct", "Please use a valid Email...", "Got it!");
                else if (IsValidEmail(Email.Text) == true)
                {
                    signUpUser = new User() {
                        Username = signUpUser.Username,
                        Password = signUpUser.Password,
                        Salt = signUpUser.Salt,
                        Firstname = FName.Text,
                        Lastname = LName.Text,
                        Email = Email.Text,
                        PhoneNumber = Phone.Text
                    };
                    Application.Current.MainPage = new AdditionalInfoSignUpPage();
                }

            }
        }

        public bool IsValidEmail(string source)
        {
            return new EmailAddressAttribute().IsValid(source);
        }

    }
}