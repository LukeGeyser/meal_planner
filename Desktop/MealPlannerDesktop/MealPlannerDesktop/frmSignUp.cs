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
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void frmSignUp_Load(object sender, EventArgs e)
        {
            dtpDOB.MaxDate = DateTime.Today;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            frmSignIn frm = new frmSignIn();
            frm.Show();
            this.Close();
        }
        List<User> check = new List<User>();
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                check = DataHandler.getUsers();
                User NUser = SecurityService.EncryptNewPassword(new User(txtUsername.Text,txtPassword.Text));
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

                foreach (var item in check)
                {
                    if (item.Username == txtUsername.Text)
                    {
                        DialogResult r = MessageBox.Show("Username already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (r == DialogResult.OK)
                        {
                            txtUsername.Clear();
                        }
                        break;
                    }
                    else if (txtPassword.Text == txtConfirmP.Text)
                    {
                        DataHandler.SignUpUser(NUser);
                        txtConfirmP.Clear();
                        txtEmail.Clear();
                        txtHeight.Clear();
                        txtName.Clear();
                        txtPassword.Clear();
                        txtPhone.Clear();
                        txtSurname.Clear();
                        txtUsername.Clear();
                        txtWeight.Clear();
                        frmSignIn frm = new frmSignIn();
                        frm.Show();
                        this.Close();
                        break;
                    }
                    else
                    {
                        DialogResult w = MessageBox.Show("Passwords do not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (w == DialogResult.OK)
                        {
                            txtPassword.Clear();
                            txtConfirmP.Clear();
                        }
                        break;
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
