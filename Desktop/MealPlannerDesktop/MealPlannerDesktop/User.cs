using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPlannerDesktop
{
    class User
    {
        //Class consisting of all information for users to sign in or sign up
        //to use application. Class fields correspond to fields of tblUsers in  
        //the meal-planning database

        private string username;
        private string password;
        private string firstname;
        private string lastname;
        private DateTime dob;
        private double weight;
        private double height;
        private string email;
        private string phone;
        private string salt;

        public User()
        {

        }
        public User(string username, string password, string firstname, 
            string lastname, DateTime dob, double weight, double height, 
            string email, string phone, string salt)
        {
            this.username = username;
            this.password = password;
            this.firstname = firstname;
            this.lastname = lastname;
            this.dob = dob;
            this.weight = weight;
            this.height = height;
            this.email = email;
            this.phone = phone;
            this.salt = salt;
        }

        public string Salt
        {
            get { return salt; }
            set { salt = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public DateTime DOB
        {
            get { return dob; }
            set { dob = value; }
        }
        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public string FirstName
        {
            get { return firstname; }
            set { firstname = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        //Method to return current age of user based on date of birth
        public int GetAge()
        {
            TimeSpan diff = DateTime.Now.Subtract(this.DOB);
            int days = (int)diff.TotalDays;

            int age = Convert.ToInt32(Math.Floor(days / 365.25));

            return age;
        }

        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
    }
}
