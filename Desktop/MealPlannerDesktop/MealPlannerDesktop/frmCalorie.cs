using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MealPlannerDesktop
{
    public partial class frmCalorie : Form
    {
        public frmCalorie()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                int count = Convert.ToInt32(nudMeal.Value);
                // Changed this so it doesnt Display Infinity, Can remove comment
                // just wanted to show where I changed the code 
                if (count != 0) txtCalMeal.Text = Math.Round(double.Parse(txtCal.Text) / count, 2).ToString();
                else txtCalMeal.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        private void frmCalorie_Load(object sender, EventArgs e)
        {
            try
            {
                int weight = int.Parse(frmSignIn.weight);
                int height = int.Parse(frmSignIn.height);
                int age = int.Parse(frmSignIn.age);
                double calorie = ((10 * weight + (6.25 * height) - (5 * age)) - 161);
                txtCal.Text = calorie.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
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
    }
}
