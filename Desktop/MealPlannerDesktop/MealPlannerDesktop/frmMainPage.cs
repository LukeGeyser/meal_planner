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
    public partial class frmMainPage : Form
    {
        public frmMainPage()
        {
            InitializeComponent();
        }

        string[] slideshowImages = new string[]
        {
            "slide1.jpg","slide2.jpg","slide3.jpg","slide4.jpg","slide5.jpg"
        };
        int count = 0;
        private void TmrSlideshow_Tick(object sender, EventArgs e)
        {
          
            if(count < slideshowImages.Length)
            {
                picSlideShow.ImageLocation = slideshowImages[count];
                count++;
            }
            else
            {
                count = 0;
                picSlideShow.ImageLocation = slideshowImages[count];
            }
           
        }

        private void CalorietoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                frmCalorie frc = new frmCalorie();
                frc.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to sign out?"
                    , "Sign Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    frmSignIn frs = new frmSignIn();
                    frs.Show();
                    this.Hide();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmMainPage_Load(object sender, EventArgs e)
        {
            tmrSlideshow.Interval = 2000;
            tmrSlideshow.Enabled = true;
        }

        private void UpdateMyDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmProfile pf = new frmProfile();
                pf.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
