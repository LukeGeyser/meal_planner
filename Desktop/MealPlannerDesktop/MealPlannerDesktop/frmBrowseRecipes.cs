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
    public partial class frmBrowseRecipes : Form
    {
        public frmBrowseRecipes()
        {
            InitializeComponent();
        }

        List<Recipes> AllRecipes = DataHandler.GetAllRecipes();
        private void FrmBrowseRecipes_Load(object sender, EventArgs e)
        {
            lblRecipeNameValue.Text = AllRecipes[0].RecipeName;
            rtxtDescription.Text = AllRecipes[0].ShortDescription;
            rtxtInstructions.Text = AllRecipes[0].Instructions;
            picPreview.ImageLocation = AllRecipes[0].Imagepreview;
            lblTimeToPrepare.Text = AllRecipes[0].TimeToPrepare.ToString() + " mins";
            lblDifficultyValue.Text = AllRecipes[0].Difficulty;
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
    }
}
