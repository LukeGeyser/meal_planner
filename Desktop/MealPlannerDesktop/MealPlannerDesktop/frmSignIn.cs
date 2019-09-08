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
        List<User> ValidUsers = DataHandler.getUsers();

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

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            bool found = false;
            int count = 0;
            while(found == false && count < ValidUsers.Count)
            {
                User test = new User(txtUser.Text, txtPass.Text, "", "", DateTime.Now, 0, 0, "", "");
                if(test.Username == ValidUsers[count].Username
                    && SecurityService.EncryptNewPassword(test).Password == ValidUsers[count].Password)
                {
                    found = true;
                    MessageBox.Show("You successfully signed in!");
                }
                else
                {
                    found = false;
                    count++;
                }
            }
            if(found == false)
            {
                MessageBox.Show("Invalid login details entered", "Sign in Error", MessageBoxButtons.OKCancel
                    , MessageBoxIcon.Warning);
            }
        }
    }
}
