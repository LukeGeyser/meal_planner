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

        private void DisplayProgress()
        {
            //Obtain previous weight values from database and display values on chart
            //according to date
            try
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
                    chProgress.Series["Series1"].XValueMember = "Date";
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmProgress_Load(object sender, EventArgs e)
        {
            DisplayProgress();
            btnSubmit.Enabled = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                frmMainPage frm = new frmMainPage();
                frm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            double weight = 0;
            //Check whether valid weight has been entered
            try
            {
                weight = Convert.ToDouble(txtWeight.Text);
            }
            catch(Exception)
            {
                MessageBox.Show("Please input a valid weight", "Error", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }

            List<string> dates = DataHandler.GetUserDates(frmSignIn.SuccessfulLogin.Username);

            if (dates.Contains(Convert.ToString(DateTime.Today)))
            {
                //checks if user had already udated their weight that day
                MessageBox.Show("Cannot update weight more than once a day", "Submit Weight", MessageBoxButtons.OK
                , MessageBoxIcon.Error);
                txtWeight.Clear();
                btnSubmit.Enabled = false;
            }
            else
            {
                //Save new progress in database and update chart
                DataHandler.UpdateUserProgress(frmSignIn.SuccessfulLogin.Username, weight);
                DataHandler.UpdateUserWeight(weight, frmSignIn.SuccessfulLogin.Username);
                DisplayProgress();
                txtWeight.Clear();
                btnSubmit.Enabled = false;
                MessageBox.Show("Progress Updated", "Submit Weight", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
            }            
        }
    }
}
