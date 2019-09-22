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
        public static string username = "";

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

                if (string.IsNullOrEmpty(txtName.Text) || (string.IsNullOrEmpty(txtSurname.Text)|| string.IsNullOrEmpty(txtWeight.Text)|| string.IsNullOrEmpty(txtHeight.Text) ||
                    string.IsNullOrEmpty(txtPassword.Text)|| string.IsNullOrEmpty(txtConfirmP.Text)|| string.IsNullOrEmpty(txtName.Text)|| string.IsNullOrEmpty(txtPhone.Text)||
                    string.IsNullOrEmpty(txtEmail.Text)))
                {
                    MessageBox.Show("Please enter all your details.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    foreach (var item in check)
                    {
                        if (item.Username == txtUsername.Text)
                        {
                            DialogResult r = MessageBox.Show("Username already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            if (r == DialogResult.OK)
                            {
                                txtUsername.Clear();
                            }
                            break;
                        }
                        else if (txtPassword.Text == txtConfirmP.Text)
                        {
                            username = txtUsername.Text;
                            DataHandler.UpdateUserProgress(NUser.Username, NUser.Weight);
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
                            frmPreferences frm = new frmPreferences();
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
