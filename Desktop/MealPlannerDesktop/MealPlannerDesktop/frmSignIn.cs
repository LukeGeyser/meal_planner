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
    public partial class frmSignIn : Form
    {
        List<User> userList = DataHandler.getUsers();
        User loggedInUser;

        public frmSignIn()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            frmSignUp frs = new frmSignUp();
            frs.Show();
            this.Hide();
        }

        private void FrmSignIn_Load(object sender, EventArgs e)
        {
            
        }
        public static string weight="";
        public static string height="";
        public static string age = "";
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            User attemptLogin = new User(txtUser.Text, txtPass.Text);

            // Check if user input credentials are valid inputs

            if (userList.Any(user => user.Username == txtUser.Text))
            {
                loggedInUser = userList.Find(user => user.Username == txtUser.Text);
                attemptLogin.Salt = loggedInUser.Salt;
                attemptLogin = SecurityService.EncryptPassword(attemptLogin);

                if (loggedInUser.Password == attemptLogin.Password)
                {
                    MessageBox.Show("Welcome!", "Sign in successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    weight = Convert.ToString(loggedInUser.Weight);
                    height = Convert.ToString(loggedInUser.Height);
                    age = Convert.ToString(loggedInUser.GetAge());
                    frmMainPage main = new frmMainPage();
                    main.Show();
                    this.Hide();
                }
                else if (loggedInUser.Password != attemptLogin.Password)
                {
                    MessageBox.Show("Invalid sign in details", "Sign in failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPass.Clear();
                    txtUser.Clear();
                }
            }
            else if (!userList.Any(user => user.Username == txtUser.Text && user.Password == txtPass.Text))
            {
                MessageBox.Show("An unexpected error occurred. Please try again", "Sign in failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Clear();
                txtUser.Clear();
            }
        }
    }
}
