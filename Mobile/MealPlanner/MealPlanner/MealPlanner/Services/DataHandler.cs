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

    }
}
