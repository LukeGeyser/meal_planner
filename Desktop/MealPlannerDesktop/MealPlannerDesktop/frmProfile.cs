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
    public partial class frmProfile : Form
    {
        public frmProfile()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            try
            {
                frmMainPage main = new frmMainPage();
                main.Show();
                this.Close();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmProfile_Load(object sender, EventArgs e)
        {
            txtName.Text = frmSignIn.SuccessfulLogin.FirstName;
            txtSurname.Text = frmSignIn.SuccessfulLogin.LastName;
            dtpDOB.Value = frmSignIn.SuccessfulLogin.DOB;
            txtPhone.Text = frmSignIn.SuccessfulLogin.Phone;
            txtEmail.Text = frmSignIn.SuccessfulLogin.Email;
            txtWeight.Text = frmSignIn.SuccessfulLogin.Weight.ToString();
            txtHeight.Text = frmSignIn.SuccessfulLogin.Height.ToString();
            txtUsername.Text = frmSignIn.SuccessfulLogin.Username;
        }
    }
}
