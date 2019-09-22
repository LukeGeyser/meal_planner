using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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
            if(bs.Count == 0)
            {
                MessageBox.Show("No results for your search. Displaying all recipes.", "Search"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                bs.DataSource = DataHandler.GetAllRecipes();
            }

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

            lblNumRecipes.Text = bs.Count + " Recipes found.";
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
            try
            {
                if (radAll.Checked == true && (txtRecipeName.Text == "All" || txtRecipeName.Text == ""))
                {
                    AllRecipes = DataHandler.GetAllRecipes();
                    CreateBindings(AllRecipes);
                }
                else if (radPreference.Checked == true && (txtRecipeName.Text == "All" || txtRecipeName.Text == ""))
                {

                    string user = frmSignIn.SuccessfulLogin.Username;

                    if (DataHandler.GetSelectedAllergies(user).Count == 0
                        && DataHandler.GetSelectedMealPlans(user).Count == 0)
                    {
                        AllRecipes = DataHandler.GetAllRecipes();
                        CreateBindings(AllRecipes);
                    }
                    else
                    {
                        List<Recipes> Validrec = DataHandler.GetAllRecipes();
                        List<UserAllergies> UserA = DataHandler.GetSelectedAllergies(user);
                        List<RecipeAllergies> recA = DataHandler.GetRecipeAllergiesAll();
                        List<UserMealPlan> userMeals = DataHandler.GetSelectedMealPlans(user);
                        List<RecipeMealPlans> recipeMealPlans = DataHandler.GetAllRecipeMealplans();

                        List<RecipeAllergies> ID = new List<RecipeAllergies>();

                        foreach (var item in recA)
                        {
                            foreach (var un in UserA)
                            {
                                if (item.AllergyID == un.AllergyID)
                                {
                                    Console.WriteLine("Allergy ID:" + item.AllergyID.ToString());
                                    //MessageBox.Show(item.AllergyID.ToString(), "Allergy ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    ID.Add(item);
                                }
                            }
                        }
                        List<Recipes> UserV = new List<Recipes>();
                        foreach (var recipe in Validrec)
                        {
                            if (ID.Count == 0)
                            {
                                UserV.Add(recipe);
                            }
                            else
                            {
                                bool contains = false;
                                foreach (var invalid in ID)
                                {
                                    if(recipe.RecipeID == invalid.RecipeID)
                                    {
                                        contains = true;
                                    }

                                    //if (recipe.RecipeID != invalid.RecipeID)
                                    //{
                                    //    Console.WriteLine("Valid recipe based on allergies: " + recipe.RecipeName);
                                    //    //MessageBox.Show(recipe.RecipeName, "Valid recipe based on allergies", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    //    UserV.Add(recipe);
                                    //}
                                }
                                if(contains == false)
                                {
                                    Console.WriteLine("Valid recipe based on allergies: " + recipe.RecipeName);
                                    UserV.Add(recipe);
                                }
                            }
                        }

                        List<RecipeMealPlans> recM = new List<RecipeMealPlans>();
                        foreach (var meal in recipeMealPlans)
                        {
                            foreach (var userm in userMeals)
                            {
                                if (meal.MealPlanID == userm.MealPlanID)
                                {
                                    Console.WriteLine("Meal Plan ID: " + meal.MealPlanID.ToString());
                                    //MessageBox.Show(meal.MealPlanID.ToString(), "Meal Plan ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    recM.Add(meal);
                                }
                            }
                        }

                        List<Recipes> final = new List<Recipes>();
                        foreach (var frec in Validrec)
                        {
                            foreach (var mealID in recM)
                            {
                                if (frec.RecipeID == mealID.RecipeID)
                                {
                                    Console.WriteLine("Recipe with suitable meal plan: " + frec.RecipeName);
                                    //MessageBox.Show(frec.RecipeName, "Recipe with suitable meal plan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    final.Add(frec);
                                }
                            }
                        }

                        List<Recipes> AllUse = new List<Recipes>();
                        foreach (var v in UserV)
                        {
                            foreach (var r in final)
                            {
                                if (v.RecipeID == r.RecipeID)
                                {
                                    Console.WriteLine("Final recipe to use: " + v.RecipeName);
                                    //MessageBox.Show(v.RecipeName, "Final recipe to use", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    AllUse.Add(v);
                                }
                            }
                        }
                        CreateBindings(AllUse);
                    }
                }
                else
                {
                    AllRecipes = DataHandler.GetAllRecipes();
                    List<Recipes> FoundRecipes = new List<Recipes>();
                    bool found = false;
                    int count = 0;
                    while(found == false && count < AllRecipes.Count)
                    {
                        if(AllRecipes[count].RecipeName.ToUpper() == txtRecipeName.Text.ToUpper()
                            || AllRecipes[count].RecipeName.ToUpper().Contains(txtRecipeName.Text.ToUpper()))
                        {
                            found = true;
                            FoundRecipes.Add(AllRecipes[count]);
                        }
                        else
                        {
                            count++;
                        }
                    }
                    if(found == true)
                    {
                        CreateBindings(FoundRecipes);
                    }
                                       
                }
                MessageBox.Show("Search Complete!", "Search", MessageBoxButtons.OK
                   , MessageBoxIcon.Information);
            }            
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnProducts_Click(object sender, EventArgs e)
        {

        }
    }
}
