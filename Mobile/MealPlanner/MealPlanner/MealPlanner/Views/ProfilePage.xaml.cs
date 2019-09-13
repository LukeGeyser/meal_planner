using MealPlanner.Models;
using MealPlanner.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MealPlanner.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : TabbedPage
    {

        DataHandler dh = new DataHandler();

        public ProfilePage()
        {
            InitializeComponent();
            FName.Text += SignInPage.loggedInUser.Firstname + " " + SignInPage.loggedInUser.Lastname;
            UName.Text += SignInPage.loggedInUser.Username;
            DOB.MaximumDate = DateTime.Today;
            Email.Text = SignInPage.loggedInUser.Email;
            DOB.Date = SignInPage.loggedInUser.Dob;
            Phone.Text = SignInPage.loggedInUser.PhoneNumber;
            Height.Text = SignInPage.loggedInUser.Height.ToString();
            Weight.Text = SignInPage.loggedInUser.Weight.ToString();
        }

        private void Save_Changes_Clicked(object sender, EventArgs e)
        {
            if (Email.Text == null || Phone.Text == null || DOB.Date == null || Weight.Text == null || Height.Text == null || Password.Text == null)
            {
                DisplayAlert("Not filled In", "Not all field are filled in...", "Got it!");
            }
            else if (Email.Text != null || Phone.Text != null || DOB.Date != null || Weight.Text != null || Height.Text != null || Password.Text != null)
            {
                if (IsValidEmail(Email.Text) == false) DisplayAlert("Email Not Correct", "Please use a valid Email...", "Got it!");
                else if (IsValidEmail(Email.Text) == true)
                {
                    if (Regex.IsMatch(Height.Text, @"^\d+$") == false || Regex.IsMatch(Weight.Text, @"^\d+$") == false)
                        DisplayAlert("Field Input Invalid", "Weight or Height input is incorrect...", "Got it!");
                    else if (Regex.IsMatch(Height.Text, @"^\d+$") == true || Regex.IsMatch(Weight.Text, @"^\d+$") == true)
                    {
                        dh.UpdateUserDetails(SignInPage.loggedInUser = SecurityService.EncryptNewPassword(new User()
                        {
                            Firstname = SignInPage.loggedInUser.Firstname,
                            Lastname = SignInPage.loggedInUser.Lastname,
                            Username = SignInPage.loggedInUser.Username,
                            Password = Password.Text,
                            Email = Email.Text,
                            Dob = DOB.Date,
                            PhoneNumber = Phone.Text,
                            Height = double.Parse(Height.Text),
                            Weight = double.Parse(Weight.Text)
                        }));
                    }
                }
            }
        }

        #region Private Helpers

        public bool IsValidEmail(string source)
        {
            return new EmailAddressAttribute().IsValid(source);
        }

        #endregion

    }
}