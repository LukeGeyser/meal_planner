using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
            catch (Exception err)
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

        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            try
            {
                User NUser = SecurityService.EncryptNewPassword(new User(frmSignIn.SuccessfulLogin.Username
                    , txtPassword.Text));
                NUser.FirstName = txtName.Text;
                NUser.LastName = txtSurname.Text;
                NUser.Phone = txtPhone.Text;

                if (IsValidEmail(txtEmail.Text))
                {
                    NUser.Email = txtEmail.Text;
                }
                else
                {
                    throw new Exception("Invalid email address entered.");
                }

                NUser.DOB = dtpDOB.Value;
                NUser.Weight = double.Parse(txtWeight.Text);
                NUser.Height = double.Parse(txtHeight.Text);

                if (txtPassword.Text == txtConfirmP.Text)
                {
                    DataHandler.UpdateUserDetails(NUser);
                    txtPassword.Clear();
                    txtConfirmP.Clear();
                    frmSignIn.SuccessfulLogin = NUser;
                }
                else
                {
                    DialogResult w = MessageBox.Show("Passwords do not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (w == DialogResult.OK)
                    {
                        txtPassword.Clear();
                        txtConfirmP.Clear();
                    }


                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool IsValidEmail(string source)
        {
            return new EmailAddressAttribute().IsValid(source);
        }
    }
}
