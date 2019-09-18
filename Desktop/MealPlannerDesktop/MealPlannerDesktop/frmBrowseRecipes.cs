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

        List<Recipes> AllRecipes;
        BindingSource bs = new BindingSource();

        private void CreateBindings(List<Recipes> rec)
        {
            // AllRecipes = DataHandler.GetAllRecipes();
            // bs.DataSource = AllRecipes;
            bs.DataSource = rec;
            lblRecipeNameValue.DataBindings.Clear();
            lblRecipeNameValue.DataBindings.Add("Text", bs, "RecipeName");
            rtxtDescription.DataBindings.Clear();
            rtxtDescription.DataBindings.Add("Text", bs, "ShortDescription");
            rtxtInstructions.DataBindings.Clear();
            rtxtInstructions.DataBindings.Add("Text", bs, "Instructions");
            picPreview.DataBindings.Clear();
            picPreview.DataBindings.Add("ImageLocation", bs, "ImagePreview");
            lblTimeToPrepare.DataBindings.Clear();
            lblTimeToPrepare.DataBindings.Add("Text", bs, "TimeToPrepare");
            lblDifficultyValue.DataBindings.Clear();
            lblDifficultyValue.DataBindings.Add("Text", bs, "Difficulty");

        }

        private void LinkData()
        {
            
            Recipes current = (Recipes)bs.Current;
            List<RecipeMealPlans> mealplans = DataHandler.GetRecipeMealplans(current.RecipeID);
            lstMealplans.Items.Clear();
            for(int i = 0; i < mealplans.Count; i++)
            {
                lstMealplans.Items.Add(SearchMealPlan(mealplans[i].MealPlanID).MealPlanName);
            }

            List<RecipeAllergies> allergies = DataHandler.GetRecipeAllergies(current.RecipeID);
            lstAllergies.Items.Clear();
            for(int i = 0; i < allergies.Count; i++)
            {
                lstAllergies.Items.Add(SearchAllergy(allergies[i].AllergyID).AllergyName);
            }
        }

        private MealPlans SearchMealPlan(int mealPlanID)
        {
            List<MealPlans> plans = DataHandler.GetAllMealPlans();
            MealPlans foundPlan = null;
            bool found = false;
            int count = 0;
            while(found == false && count < plans.Count)
            {
                if(plans[count].MealPlanID == mealPlanID)
                {
                    found = true;
                    foundPlan = plans[count];
                }
                else
                {
                    count++;
                }
            }
            return foundPlan;
        }

        private Allergies SearchAllergy(int allergyID)
        {
            List<Allergies> allergies = DataHandler.GetAllAllergies();
            Allergies foundAllergy = null;
            bool found = false;
            int count = 0;
            while (found == false && count < allergies.Count)
            {
                if (allergies[count].AllergyID == allergyID)
                {
                    found = true;
                    foundAllergy = allergies[count];
                }
                else
                {
                    count++;
                }
            }
            return foundAllergy;
        }

        private void FrmBrowseRecipes_Load(object sender, EventArgs e)
        {
            AllRecipes = DataHandler.GetAllRecipes();
            CreateBindings(AllRecipes);
            LinkData();
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

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
            LinkData();
        }

        private void TnNext_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
            LinkData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("AY", "Valid Recipe", MessageBoxButtons.OK, MessageBoxIcon.Information);

            string user = frmSignIn.SuccessfulLogin.Username;
            List<Recipes> Validrec = DataHandler.GetAllRecipes();
            List<UserAllergies> UserA = DataHandler.GetSelectedAllergies(user);
            List<RecipeAllergies> recA = DataHandler.GetRecipeAllergiesAll();

            List<RecipeAllergies> ID = new List<RecipeAllergies>();

            for (int i = 0; i < UserA.Count; i++)
            {
                if (UserA[i].AllergyID == recA[i].AllergyID)
                {
                    MessageBox.Show(recA[i].AllergyID.ToString(), "INvalid Recipe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ID.Add(recA[i]);
                }
            }

            // for (int j = 0; j < Validrec.Count; j++)
            // {
            //     if (recA[j].RecipeID== Validrec[j].RecipeID)
            //     {
            //         Validrec.RemoveAt(j);
            //     }
            // }
            //CreateBindings(Validrec);
        }
    }
}
