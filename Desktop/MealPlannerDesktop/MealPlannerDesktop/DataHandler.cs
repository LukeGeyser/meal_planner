using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MealPlannerDesktop
{
    class DataHandler
    {
        //Static connection to database used throughout DataHandler
        public static SqlConnection conn = new SqlConnection("Data Source=meal-planner.database.windows.net"
            + "; User=Luke; Password=Damian64; Initial Catalog=MealPlanner");


        //Return information regarding all saved user profiles
        public static List<User> getUsers()
        {
            List<User> people = new List<User>();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tblUsers", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    people.Add(new User(reader["Username"].ToString(), reader["Password"].ToString()
                        , reader["FirstName"].ToString(), reader["LastName"].ToString()
                        , Convert.ToDateTime(reader["DOB"]), Convert.ToDouble(reader["Weight"])
                        , Convert.ToDouble(reader["Height"]), reader["Email"].ToString(), 
                        reader["Phone"].ToString(), reader["Salt"].ToString()));
                }
                cmd.Dispose();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Database error occurred", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            return people;
        }

        //Insert new user in database when user signs up for application
        public static void SignUpUser(User newPerson)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO tblUsers (Username,Password,FirstName,LastName,"
                    + "DOB,Weight,Height,Email,Phone,Salt) VALUES (@User,@Pass,@Name,@Surname,@DOB,@Weight,@Height,"
                    + "@Email,@Phone,@Salt)", conn);
                cmd.Parameters.AddWithValue("@User", newPerson.Username);
                cmd.Parameters.AddWithValue("@Pass", newPerson.Password);
                cmd.Parameters.AddWithValue("@Name", newPerson.FirstName);
                cmd.Parameters.AddWithValue("@Surname", newPerson.LastName);
                cmd.Parameters.AddWithValue("@DOB", newPerson.DOB);
                cmd.Parameters.AddWithValue("@Weight", newPerson.Weight);
                cmd.Parameters.AddWithValue("@Height", newPerson.Height);
                cmd.Parameters.AddWithValue("@Email", newPerson.Email);
                cmd.Parameters.AddWithValue("@Phone", newPerson.Phone);
                cmd.Parameters.AddWithValue("@Salt", newPerson.Salt);

                cmd.ExecuteNonQuery();
                MessageBox.Show("You are successfully signed up!", "Sign Up", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                cmd.Dispose();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Database error occurred", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        //Update user profile
        public static void UpdateUserDetails(User Person)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE tblUsers SET Password=@pass,FirstName=@name,LastName=@surname,"
                    + "DOB=@dob,Weight=@weight,Height=@height,Email=@email,Phone=@phone,Salt=@salt "+
                    "WHERE Username = @user", conn);
                cmd.Parameters.AddWithValue("@pass", Person.Password);
                cmd.Parameters.AddWithValue("@name", Person.FirstName);
                cmd.Parameters.AddWithValue("@surname", Person.LastName);
                cmd.Parameters.AddWithValue("@dob", Person.DOB);
                cmd.Parameters.AddWithValue("@weight", Person.Weight);
                cmd.Parameters.AddWithValue("@height", Person.Height);
                cmd.Parameters.AddWithValue("@email", Person.Email);
                cmd.Parameters.AddWithValue("@phone", Person.Phone);
                cmd.Parameters.AddWithValue("@salt", Person.Salt);
                cmd.Parameters.AddWithValue("@user", Person.Username);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Profile Successfully Updated.", "Apply Changes"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Database error occurred", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public static List<Allergies> GetAllAllergies()
        {
            List<Allergies> allergies = new List<Allergies>();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tblAllergies", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    allergies.Add(new Allergies(Convert.ToInt32(reader["AllergyID"])
                        , reader["AllergyName"].ToString(), reader["Description"].ToString()));
                }
                cmd.Dispose();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Database error occurred", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            return allergies;

        }

        public static List<UserAllergies> GetSelectedAllergies(string username)
        {
            List<UserAllergies> chosen = new List<UserAllergies>();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tblUsersAllergies WHERE "
                    + "Username = @user", conn);
                cmd.Parameters.AddWithValue("@user", username);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    chosen.Add(new UserAllergies(reader["Username"].ToString()
                        , Convert.ToInt32(reader["AllergyID"])));
                }
                cmd.Dispose();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Database error occurred", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            return chosen;
        }

        public static List<MealPlans> GetAllMealPlans()
        {
            List<MealPlans> plans = new List<MealPlans>();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tblMealPlans", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    plans.Add(new MealPlans(Convert.ToInt32(reader["MealPlanID"]),
                        reader["MealPlanName"].ToString(), reader["Description"].ToString(),
                        reader["Advantages"].ToString(), reader["Disadvantages"].ToString()));
                }
                cmd.Dispose();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Database error occurred", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            return plans;
        }

        public static List<UserMealPlan> GetSelectedMealPlans(string username)
        {
            List<UserMealPlan> plans = new List<UserMealPlan>();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tblUsersMealPlans WHERE "
                    + " Username = @user", conn);
                cmd.Parameters.AddWithValue("@user", username);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    plans.Add(new UserMealPlan(reader["Username"].ToString(),
                        Convert.ToInt32(reader["MealPlanID"])));
                }
                cmd.Dispose();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Database error occurred", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            return plans;
        }

        public static void AddAllergy(Allergies allergie)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO tblAllergies (AllergyName, Description) VALUES (@Name, @Desc)", conn);
                cmd.Parameters.AddWithValue("@Name", allergie.AllergyName);
                cmd.Parameters.AddWithValue("@Desc", allergie.Description);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Allergy Added!", "Add New Allergy", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                cmd.Dispose();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Database error occurred", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public static void AddMealPlan(MealPlans meal)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO tblMealPlans (MealPlanName, Description, Advantages, Disadvantages) VALUES (@Name, @Desc, @Advant, @Disadvant)", conn);
                cmd.Parameters.AddWithValue("@Name", meal.MealPlanName);
                cmd.Parameters.AddWithValue("@Desc", meal.Description);
                cmd.Parameters.AddWithValue("@Advant", meal.Advantages);
                cmd.Parameters.AddWithValue("@Disadvant", meal.Disadvantages);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Meal Plan Added!", "Add New Meal Plan", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                cmd.Dispose();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Database error occurred", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public static void RemoveAllPreferences(string username)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM tblUsersAllergies WHERE Username = @user"
                    , conn);
                cmd.Parameters.AddWithValue("@user", username);
                cmd.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand("DELETE FROM tblUsersMealPlans WHERE Username = @user"
                    , conn);
                cmd2.Parameters.AddWithValue("@user", username);
                cmd2.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Database error occurred", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public static void AddSelectedAllergy(string username,Allergies chosen)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO tblUsersAllergies(Username,AllergyID)"
                    + " VALUES(@user,@allergy)", conn);
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@allergy", chosen.AllergyID);
                cmd.ExecuteNonQuery();
                
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Database error occurred", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public static void AddSelectedMealplans(string username, MealPlans chosen)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO tblUsersMealPlans(Username,MealPlanID)"
                    + " VALUES(@user,@plan)", conn);
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@plan", chosen.MealPlanID);
                cmd.ExecuteNonQuery();

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Database error occurred", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
