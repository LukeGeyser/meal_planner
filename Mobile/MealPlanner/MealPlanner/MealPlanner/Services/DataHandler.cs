using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using MealPlanner.Models;
using System.Diagnostics;

namespace MealPlanner.Services
{
    class DataHandler
    {

        private SqlConnection conn;
        private SqlDataReader dr = null;

        public DataHandler()
        {
            var cb = new SqlConnectionStringBuilder();
            cb.DataSource = "meal-planner.database.windows.net";
            cb.UserID = "Luke";
            cb.Password = "Damian64";
            cb.InitialCatalog = "MealPlanner";

            conn = new SqlConnection(cb.ConnectionString);
        }

        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            try
            {
                conn.Open();
                SqlCommand cmdSelectAll = new SqlCommand("SELECT * FROM tblUsers", conn);
                dr = cmdSelectAll.ExecuteReader();

                while (dr.Read())
                {
                    users.Add(new User(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[7].ToString(),
                        dr[8].ToString(), Convert.ToDateTime(dr[4].ToString()), double.Parse(dr[5].ToString()), double.Parse(dr[6].ToString()), dr[9].ToString()));
                }
                cmdSelectAll.Dispose();
            }
            catch (Exception e)
            {
                // Throw an Error
                Debug.WriteLine(e.Message);
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
            Debug.WriteLine(users.Count);
            return users;
        }

        public void AddSingleUser(User user)
        {
            try
            {
                conn.Open();
                SqlCommand cmdInsert = new SqlCommand("INSERT INTO tblUsers (Username,Password,FirstName,LastName,DOB,Weight,Height,Email,Phone,Salt)" +
                    "VALUES(@uname,@pwd,@fname,@sname,@dob,@weight,@height,@email,@phone,@salt)", conn);
                using (cmdInsert)
                {
                    cmdInsert.Parameters.AddWithValue("@uname", user.Username);
                    cmdInsert.Parameters.AddWithValue("@pwd", user.Password);
                    cmdInsert.Parameters.AddWithValue("@fname", user.Firstname);
                    cmdInsert.Parameters.AddWithValue("@sname", user.Lastname);
                    cmdInsert.Parameters.AddWithValue("@dob", user.Dob);
                    cmdInsert.Parameters.AddWithValue("@weight", user.Weight);
                    cmdInsert.Parameters.AddWithValue("@height", user.Height);
                    cmdInsert.Parameters.AddWithValue("@email", user.Email);
                    cmdInsert.Parameters.AddWithValue("@phone", user.PhoneNumber);
                    cmdInsert.Parameters.AddWithValue("@salt", user.Salt);
                    cmdInsert.ExecuteNonQuery();
                }
                cmdInsert.Dispose();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

        public void UpdateUserDetails(User Person)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE tblUsers SET Password=@pass,FirstName=@name,LastName=@surname,"
                    + "DOB=@dob,Weight=@weight,Height=@height,Email=@email,Phone=@phone,Salt=@salt " +
                    "WHERE Username = @user", conn);
                cmd.Parameters.AddWithValue("@pass", Person.Password);
                cmd.Parameters.AddWithValue("@name", Person.Firstname);
                cmd.Parameters.AddWithValue("@surname", Person.Lastname);
                cmd.Parameters.AddWithValue("@dob", Person.Dob);
                cmd.Parameters.AddWithValue("@weight", Person.Weight);
                cmd.Parameters.AddWithValue("@height", Person.Height);
                cmd.Parameters.AddWithValue("@email", Person.Email);
                cmd.Parameters.AddWithValue("@phone", Person.PhoneNumber);
                cmd.Parameters.AddWithValue("@salt", Person.Salt);
                cmd.Parameters.AddWithValue("@user", Person.Username);
                cmd.ExecuteNonQuery();
            }
            catch (Exception error)
            {

            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

        public List<Allergies> GetAllAllergies()
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
            catch (Exception)
            {
                
            }
            finally
            {
                conn.Close();
            }
            return allergies;

        }

        public Allergies GetSelectedAllergie(string AllergyName)
        {
            Allergies allergies = null;
            try
            {
                conn.Open();
                
                SqlCommand cmd = new SqlCommand("SELECT * FROM tblAllergies WHERE AllergyName=@name", conn);
                cmd.Parameters.AddWithValue("@name", AllergyName);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    allergies = new Allergies(Convert.ToInt32(reader["AllergyID"])
                        , reader["AllergyName"].ToString(), reader["Description"].ToString());
                }
                cmd.Dispose();
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }
            return allergies;

        }

        public List<UserAllergies> GetSelectedAllergies(string username)
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
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }
            return chosen;
        }

        public List<MealPlans> GetAllMealPlans()
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
            catch (Exception)
            {
            }
            finally
            {
                conn.Close();
            }
            return plans;
        }

        public MealPlans GetSelectedMealPlan(string MealPlanName)
        {
            MealPlans plan = null;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tblMealPlans WHERE MealPlanName=@name", conn);
                cmd.Parameters.AddWithValue("@name", MealPlanName);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    plan = new MealPlans(Convert.ToInt32(reader["MealPlanID"]),
                        reader["MealPlanName"].ToString(), reader["Description"].ToString(),
                        reader["Advantages"].ToString(), reader["Disadvantages"].ToString());
                }
                cmd.Dispose();
            }
            catch (Exception)
            {
            }
            finally
            {
                conn.Close();
            }
            return plan;
        }

        public List<UserMealPlan> GetSelectedMealPlans(string username)
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
            catch (Exception)
            {
            }
            finally
            {
                conn.Close();
            }
            return plans;
        }

        public void AddAllergy(Allergies allergie)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO tblAllergies (AllergyName, Description) VALUES (@Name, @Desc)", conn);
                cmd.Parameters.AddWithValue("@Name", allergie.AllergyName);
                cmd.Parameters.AddWithValue("@Desc", allergie.Description);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception)
            {
            }
            finally
            {
                conn.Close();
            }
        }

        public  void AddMealPlan(MealPlans meal)
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
                cmd.Dispose();
            }
            catch (Exception)
            {
            }
            finally
            {
                conn.Close();
            }
        }

        public void RemoveAllPreferences(string username)
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
            catch (Exception)
            {
            }
            finally
            {
                conn.Close();
            }
        }

        public void AddSelectedAllergy(string username, Allergies chosen)
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
            catch (Exception)
            {
            }
            finally
            {
                conn.Close();
            }
        }

        public void AddSelectedMealplans(string username, MealPlans chosen)
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
            catch (Exception)
            {
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
