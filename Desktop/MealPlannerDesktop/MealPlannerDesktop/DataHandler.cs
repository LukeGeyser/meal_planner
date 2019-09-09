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
                        reader["Phone"].ToString(), Encoding.ASCII.GetBytes(reader["Salt"].ToString())));
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
    }
}
