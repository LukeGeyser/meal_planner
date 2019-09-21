using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MealPlannerDesktop
{
    public partial class frmProgress : Form
    {
        public frmProgress()
        {
            InitializeComponent();
        }

        private void frmProgress_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=meal-planner.database.windows.net"
           + "; User=Luke; Password=Damian64; Initial Catalog=MealPlanner");
            try
            {
                DataSet ds = new DataSet();
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM tblProgress WHERE Username=@user", conn))
                {
                    cmd.Parameters.AddWithValue("@User", frmSignIn.SuccessfulLogin.Username);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {

                        adapter.Fill(ds);
                    }
                }
                chProgress.DataSource = ds;
                chProgress.Series["Series1"].XValueMember = "Username";
                chProgress.Series["Series1"].YValueMembers = "Weight";
                chProgress.Series["Series1"].ChartType = SeriesChartType.Line;
                conn.Close();
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
