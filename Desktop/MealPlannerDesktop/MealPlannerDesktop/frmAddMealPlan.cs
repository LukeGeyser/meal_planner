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
                MealPlans meal = new MealPlans(0, txtName.Text, rtbDesc.Text, rtbAdvantage.Text, rtbDisadvantage.Text);

                DataHandler.AddMealPlan(meal);

                txtName.Clear();
                rtbDesc.Clear();
                rtbDisadvantage.Clear();
                rtbAdvantage.Clear();

                frmProfile frp = new frmProfile();
                frp.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
