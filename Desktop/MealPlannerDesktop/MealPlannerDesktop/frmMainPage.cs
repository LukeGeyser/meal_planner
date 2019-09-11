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
            "slide1.jpg","slide2.jpg"
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
                frmSignIn frs = new frmSignIn();
                frs.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
