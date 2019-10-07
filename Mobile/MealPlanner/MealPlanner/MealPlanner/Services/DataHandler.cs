﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using MealPlanner.Models;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

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
         
        public async Task GetAllUsers(List<User> users)
        {
            try
            {
                await conn.OpenAsync();
                SqlCommand cmdSelectAll = new SqlCommand("SELECT * FROM tblUsers", conn);
                dr = await cmdSelectAll.ExecuteReaderAsync();

                while (await dr.ReadAsync())
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
        }

        public async Task AddSingleUser(User user)
        {
            try
            {
                await conn.OpenAsync();
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

        public async Task UpdateUserDetails(User Person)
        {
            try
            {
                await conn.OpenAsync();
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
            catch (Exception)
            {

            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

        public async Task<List<Allergies>> GetAllAllergies()
        {
            List<Allergies> allergies = new List<Allergies>();
            try
            {
                await conn.OpenAsync();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tblAllergies", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (await reader.ReadAsync())
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

        public async Task<List<UserAllergies>> GetSelectedAllergies(string username)
        {
            List<UserAllergies> chosen = new List<UserAllergies>();
            try
            {
                await conn.OpenAsync();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tblUsersAllergies WHERE "
                    + "Username = @user", conn);
                cmd.Parameters.AddWithValue("@user", username);
                SqlDataReader reader = cmd.ExecuteReader();
                while (await reader.ReadAsync())
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

        public async Task<List<MealPlans>> GetAllMealPlans()
        {
            List<MealPlans> plans = new List<MealPlans>();
            try
            {
                await conn.OpenAsync();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tblMealPlans", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (await reader.ReadAsync())
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

        public async Task<List<UserMealPlan>> GetSelectedMealPlans(string username)
        {
            List<UserMealPlan> plans = new List<UserMealPlan>();
            try
            {
                await conn.OpenAsync();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tblUsersMealPlans WHERE "
                    + " Username = @user", conn);
                cmd.Parameters.AddWithValue("@user", username);
                SqlDataReader reader = cmd.ExecuteReader();
                while (await reader.ReadAsync())
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

        public async Task RemoveAllPreferences(string username)
        {
            try
            {
                await conn.OpenAsync();
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

        public async Task AddSelectedAllergy(string username, Allergies chosen)
        {
            try
            {
                await conn.OpenAsync();
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

        public async Task AddSelectedMealplans(string username, MealPlans chosen)
        {
            try
            {
                await conn.OpenAsync();
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

        public void UpdateUserProgress(string username, double weight)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO tblProgress(Username, Weight,Date) Values(@user, @weight,@date)", conn);
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@weight", weight);
                cmd.Parameters.AddWithValue("@date", DateTime.Now);
                cmd.ExecuteNonQuery();
            }
            catch (Exception error)
            {

            }
            finally
            {
                conn.Close();
            }
        }

        public List<Products> GetAllProducts()
        {
            List<Products> products = new List<Products>();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tblProducts", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    products.Add(new Products(Convert.ToInt32(reader["ProductID"])
                        , reader["ProductName"].ToString(), reader["Category"].ToString()
                        , reader["Description"].ToString(), reader["NutritionalValue"].ToString()
                        , reader["ProductImage"].ToString()));
                }
                cmd.Dispose();
            }
            catch (Exception error)
            {
            }
            finally
            {
                conn.Close();
            }
            return products;
        }

        //Returns a list of all the shops where a particular product is available and 
        //the price of the product at that shop
        public List<ShopsPrices> GetPriceComparison(int ProductID)
        {
            List<ShopsPrices> prices = new List<ShopsPrices>();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT tblShops.ShopName, tblShopProducts.Price" +
                    " FROM tblShops INNER JOIN(tblShopProducts INNER JOIN tblProducts" +
                    " ON tblShopProducts.ProductID = tblProducts.ProductID) ON" +
                    " tblShops.ShopID = tblShopProducts.ShopID WHERE tblProducts.ProductID = @ID", conn);
                cmd.Parameters.AddWithValue("@ID", ProductID);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    prices.Add(new ShopsPrices(reader["ShopName"].ToString()
                        , Convert.ToDouble(reader["Price"])));
                }
                cmd.Dispose();
            }
            catch (Exception error)
            {
            }
            finally
            {
                conn.Close();
            }
            return prices;
        }

        //Return a list of all products required for a particular recipe
        public List<RecipeProducts> GetRecipeProducts(int recipeID)
        {
            List<RecipeProducts> products = new List<RecipeProducts>();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT tblRecipes.RecipeID,tblRecipeProducts.ProductID" +
                    " FROM tblRecipes INNER JOIN tblRecipeProducts ON tblRecipes.RecipeID ="
                    + " tblRecipeProducts.RecipeID WHERE tblRecipeProducts.RecipeID = @ID", conn);
                cmd.Parameters.AddWithValue("@ID", recipeID);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    products.Add(new RecipeProducts(Convert.ToInt32(reader["RecipeID"])
                        , Convert.ToInt32(reader["ProductID"])));
                }
                cmd.Dispose();
            }
            catch (Exception error)
            {
            }
            finally
            {
                conn.Close();
            }
            return products;
        }

    }
}
