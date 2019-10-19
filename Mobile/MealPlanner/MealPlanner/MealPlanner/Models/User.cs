using MealPlanner.Services;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MealPlanner.Models
{
    public class User
    {
        #region Private Members

        /// <summary>
        /// Private User Username
        /// </summary>
        private string username;

        /// <summary>
        /// Private User Password
        /// </summary>
        private string password;

        /// <summary>
        /// Private User Firstname
        /// </summary>
        private string firstname;

        /// <summary>
        /// Private User Lastname
        /// </summary>
        private string lastname;

        /// <summary>
        /// Private User Email
        /// </summary>
        private string email;

        /// <summary>
        /// Private User PhoneNumber
        /// </summary>
        private string phoneNumber;

        /// <summary>
        /// Private User Date Of Birth
        /// </summary>
        private DateTime dob;

        /// <summary>
        /// Private User Weight
        /// </summary>
        private double weight;

        /// <summary>
        /// Private User Height
        /// </summary>
        private double height;

        /// <summary>
        /// Private User Salt, for encrypting password
        /// </summary>
        private string salt;

        /// <summary>
        /// Private User Previous Weight Update
        /// </summary>
        private DateTime previousWeightUpdate;

        /// <summary>
        /// Private List of User Allergies
        /// </summary>
        private List<UserAllergies> allergies;

        /// <summary>
        /// Private List of User Meal Plans
        /// </summary>
        private List<UserMealPlan> mealPlans;

        #endregion

        #region Public Properties

        /// <summary>
        /// Private User Username
        /// </summary>
        public string Username
        {
            get => username;
            set => username = value;
        }

        /// <summary>
        /// Private User Password
        /// </summary>
        public string Password
        {
            get => password;
            set => password = value;
        }

        /// <summary>
        /// Private User Firstname
        /// </summary>
        public string Firstname
        {
            get => firstname;
            set => firstname = value;
        }

        /// <summary>
        /// Private User Lastname
        /// </summary>
        public string Lastname
        {
            get => lastname;
            set => lastname = value;
        }

        /// <summary>
        /// Private User Email
        /// </summary>
        public string Email
        {
            get => email;
            set => email = value;
        }

        /// <summary>
        /// Private User PhoneNumber
        /// </summary>
        public string PhoneNumber
        {
            get => phoneNumber;
            set => phoneNumber = value;
        }

        /// <summary>
        /// Private User Date Of Birth
        /// </summary>
        public DateTime Dob
        {
            get => dob;
            set => dob = value;
        }

        /// <summary>
        /// Private User Weight
        /// </summary>
        public double Weight
        {
            get => weight;
            set => weight = value;
        }

        /// <summary>
        /// Private User Height
        /// </summary>
        public double Height
        {
            get => height;
            set => height = value;
        }

        /// <summary>
        /// Public User Salt, for encrypting the Password
        /// </summary>
        public string Salt
        {
            get => salt;
            set => salt = value;
        }

        public DateTime PreviousWeightUpdate
        {
            get => previousWeightUpdate;
            set => previousWeightUpdate = value;
        }

        /// <summary>
        /// Public List of User Allergies
        /// </summary>
        public List<UserAllergies> Allergies
        {
            get => allergies;
            set => allergies = value;
        }

        /// <summary>
        /// Public List of User Meal Plans
        /// </summary>
        public List<UserMealPlan> MealPlans
        {
            get => mealPlans;
            set => mealPlans = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default Contructor
        /// </summary>
        public User()
        {

        }

        /// <summary>
        /// Used when creating a brand new User
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="firstname"></param>
        /// <param name="lastname"></param>
        /// <param name="email"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="dob"></param>
        /// <param name="weight"></param>
        /// <param name="height"></param>
        /// <param name="salt"></param>
        public User(string username, string password, string firstname, string lastname, string email,
            string phoneNumber, DateTime dob, double weight, double height)
        {
            this.username = username;
            this.password = password;
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.dob = dob;
            this.weight = weight;
            this.height = height;
        }

        /// <summary>
        /// Used when creating a brand new User
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="firstname"></param>
        /// <param name="lastname"></param>
        /// <param name="email"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="dob"></param>
        /// <param name="weight"></param>
        /// <param name="height"></param>
        /// <param name="salt"></param>
        public User(string username, string password, string firstname, string lastname, string email,
            string phoneNumber, DateTime dob, double weight, double height, string salt)
        {
            this.username = username;
            this.password = password;
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.dob = dob;
            this.weight = weight;
            this.height = height;
            this.salt = salt;
        }

        /// <summary>
        /// Used when needed to validate and Log user into Application
        /// </summary>
        /// <param name="username">Username recieved when logging into Application</param>
        /// <param name="password">Password recieved when logging into Application</param>
        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        #endregion

        #region Helper Functions

        public int GetAge()
        {
            TimeSpan diff = DateTime.Now.Subtract(this.dob);
            int days = (int)diff.TotalDays;

            int age = Convert.ToInt32(Math.Floor(days / 365.25));

            return age;
        }

        public async Task GetUserMealPlanAllergies()
        {
            Allergies = await new DataHandler().GetSelectedAllergies(username);
            MealPlans = await new DataHandler().GetSelectedMealPlans(username);
        }

        #endregion
    }
}
