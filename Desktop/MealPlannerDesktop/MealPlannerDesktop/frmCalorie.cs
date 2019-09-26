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
                double weight = Convert.ToDouble(frmSignIn.weight);
                double height = Convert.ToDouble(frmSignIn.height);
                int age = int.Parse(frmSignIn.age);
                double calorie = ((10 * weight + (6.25 * height) - (5 * age)) - 161);
                txtCal.Text = calorie.ToString();

                double heightMeters = height / 100;

                txtBmiHeight.Text = heightMeters.ToString();
                txtBmiWeight.Text = weight.ToString();
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

        private void BtnBMI_Click(object sender, EventArgs e)
        {
            try
            {
                double height = Convert.ToDouble(txtBmiHeight.Text);
                double weight = Convert.ToDouble(txtBmiWeight.Text);

                double BMI = weight / (height * height);

                lblBMI.Text = string.Format("Your BMI: {0:0.00}", BMI);

                string status = "";
                if (BMI < 18.5)
                { status = "You are underweight!"; lblStatus.ForeColor = Color.Red; }
                else if (BMI >= 18.5 && BMI < 25)
                { status = "You are healthy!"; lblStatus.ForeColor = Color.Green; }
                else if (BMI >= 25 && BMI < 30)
                { status = "You are overweight!"; lblStatus.ForeColor = Color.Blue; }
                else { status = "You are obese!"; lblStatus.ForeColor = Color.Purple; }

                lblStatus.Text = status;
            }
            catch (Exception)
            {
                MessageBox.Show("Please input a valid height and weight.", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
