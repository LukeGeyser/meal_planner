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
    public partial class frmAddAllergy : Form
    {
        public frmAddAllergy()
        {
            InitializeComponent();
        }

        private void btnAddAllergy_Click(object sender, EventArgs e)
        {
            try
            {
                //Validate whether valid information was provided
                if (txtName.Text != "")
                {
                    Allergies allergie = new Allergies();
                    allergie.AllergyID = 0;
                    allergie.AllergyName = txtName.Text;
                    if (rtbDesc.Text != "")
                    {
                        allergie.Description = rtbDesc.Text;
                    }
                    else
                    {
                        allergie.Description = "None";
                    }
                    //Call DataHandler method to insert allergy into database
                    DataHandler.AddAllergy(allergie);

                    txtName.Clear();
                    rtbDesc.Clear();

                    frmProfile frp = new frmProfile();
                    frp.Show();
                    this.Hide();
                }
                else
                {
                    throw new CustomException("Please enter a valid allergy name.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmAddAllergy_Load(object sender, EventArgs e)
        {

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
    }
}
