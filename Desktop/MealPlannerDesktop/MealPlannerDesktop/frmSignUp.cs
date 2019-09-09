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
            check = DataHandler.getUsers();
            User NUser = new User();
            NUser.FirstName = txtName.Text;
            NUser.LastName = txtSurname.Text;
            NUser.Phone = txtPhone.Text;
            NUser.Email = txtEmail.Text;
            NUser.Username = txtUsername.Text;
            NUser.Password = txtPassword.Text;
            NUser.DOB = dtpDOB.Value;
            NUser.Weight = double.Parse(txtWeight.Text);
            NUser.Height = double.Parse(txtHeight.Text);
            string salt = SecurityService.EncryptNewPassword(NUser).Password;
            NUser.Salt = Encoding.ASCII.GetBytes(salt);

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
    }
}
