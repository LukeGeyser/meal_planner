﻿using System;
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
            try
            {
                weight = Convert.ToDouble(txtWeight.Text);
            }
            catch(Exception)
            {
                MessageBox.Show("Please input a valid weight", "Error", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }

            DataHandler.UpdateUserProgress(frmSignIn.SuccessfulLogin.Username, weight);
            DisplayProgress();
            txtWeight.Clear();
            btnSubmit.Enabled = false;
            MessageBox.Show("Progress Updated", "Submit Weight", MessageBoxButtons.OK
                , MessageBoxIcon.Information);
        }
    }
}
