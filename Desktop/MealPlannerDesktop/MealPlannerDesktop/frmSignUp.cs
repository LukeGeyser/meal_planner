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
    }
}
