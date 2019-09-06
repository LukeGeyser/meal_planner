using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

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

    }
}
