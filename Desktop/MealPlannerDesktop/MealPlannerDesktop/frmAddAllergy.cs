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

        private void button1_Click(object sender, EventArgs e)
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

        private void btnAddAllergy_Click(object sender, EventArgs e)
        {
            try
            {
                Allergies allergie = new Allergies();
                allergie.AllergyID = 0;
                allergie.AllergyName = txtName.Text;
                allergie.Description = rtbDesc.Text;

                DataHandler.AddAllergy(allergie);

                txtName.Clear();
                rtbDesc.Clear();

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
