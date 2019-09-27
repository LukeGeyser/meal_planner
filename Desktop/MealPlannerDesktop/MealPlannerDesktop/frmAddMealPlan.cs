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
    public partial class frmAddMealPlan : Form
    {
        public frmAddMealPlan()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                frmProfile frp = new frmProfile();
                frp.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //Validate whether valid input was provided.
                if (txtName.Text != "")
                {
                    MealPlans meal = new MealPlans();
                    meal.MealPlanID = 0;
                    meal.MealPlanName = txtName.Text;
                    if(rtbDesc.Text != "")
                    {
                        meal.Description = rtbDesc.Text;
                    }
                    else
                    {
                        meal.Description = "None";
                    }
                    if(rtbAdvantage.Text != "")
                    {
                        meal.Advantages = rtbAdvantage.Text;
                    }
                    else
                    {
                        meal.Advantages = "None";
                    }
                    if(rtbDisadvantage.Text != "")
                    {
                        meal.Disadvantages = rtbDisadvantage.Text;
                    }
                    else
                    {
                        meal.Disadvantages = "None";
                    }

                    //Use DataHandler method to insert mealplan into database.
                    DataHandler.AddMealPlan(meal);

                    txtName.Clear();
                    rtbDesc.Clear();
                    rtbDisadvantage.Clear();
                    rtbAdvantage.Clear();

                    frmProfile frp = new frmProfile();
                    frp.Show();
                    this.Hide();
                }
                else
                {
                    throw new CustomException("Please enter a valid mealplan name.");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmAddMealPlan_Load(object sender, EventArgs e)
        {

        }
    }
}
