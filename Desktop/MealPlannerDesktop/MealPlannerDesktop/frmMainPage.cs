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

        List<Quote> quotes = FileHandler.GetQuotes();

        //Populate array with slideshow image names
        string[] slideshowImages = new string[]
        {
            "slide1.jpg","slide2.jpg","slide3.jpg","slide4.jpg","slide5.jpg"
        };
        int count = 0;
        private void TmrSlideshow_Tick(object sender, EventArgs e)
        {
            //Timer tick interval set to 2000 milliseconds. Will change slideshow image 
            //with every tick
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
            tmrQuotes.Interval = 30000;
            tmrQuotes.Enabled = true;

            //Display username of customer logged in on frmSignIn
            lblWelcome.Text = "Welcome " + frmSignIn.SuccessfulLogin.Username;
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

        private void BrowseRecipesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmBrowseRecipes rep = new frmBrowseRecipes();
                rep.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BrowseShopsMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmFindShops shops = new frmFindShops();
                shops.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void trackMyProgressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmProgress frp = new frmProgress();
                frp.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PricetoolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                frmProducts pds = new frmProducts();
                pds.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        int quoteIndex = 0;
        private void TmrQuotes_Tick(object sender, EventArgs e)
        {
            if(quoteIndex < quotes.Count)
            {
                lblQuote.Text = "\"" + quotes[quoteIndex]._Quote + "\"";
                lblQuoteAuthor.Text = "- " + quotes[quoteIndex]._Author;
            }
            else
            {
                quoteIndex = 0;
                lblQuote.Text = "\"" + quotes[quoteIndex]._Quote + "\"";
                lblQuoteAuthor.Text = "- " + quotes[quoteIndex]._Author;
            }
            quoteIndex++;
        }
    }
}
