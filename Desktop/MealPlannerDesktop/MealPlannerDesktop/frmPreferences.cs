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
    public partial class frmPreferences : Form
    {
        public frmPreferences()
        {
            InitializeComponent();
        }
        List<Allergies> allergies;
        List<MealPlans> mealplans;

        private void frmPreferences_Load(object sender, EventArgs e)
        {

            //Populate lists with allergies and mealplans from database
            try
            {
                allergies = DataHandler.GetAllAllergies();
                lstAllergies.Items.Clear();
                for (int i = 0; i < allergies.Count; i++)
                {
                    lstAllergies.Items.Add(allergies[i].AllergyName);
                }

                mealplans = DataHandler.GetAllMealPlans();
                lstMealplans.Items.Clear();
                for (int i = 0; i < mealplans.Count; i++)
                {
                    lstMealplans.Items.Add(mealplans[i].MealPlanName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //Remove any previous preferences and save selected allergy and mealplan preferences
            //to database

            try
            {
                DataHandler.RemoveAllPreferences(frmSignUp.username);
                for (int i = 0; i < lstAllergies.Items.Count; i++)
                {
                    if (Convert.ToBoolean(lstAllergies.GetItemCheckState(i)) == true)
                    {
                        DataHandler.AddSelectedAllergy(frmSignUp.username
                            , allergies[i]);
                    }
                }
                for (int i = 0; i < lstMealplans.Items.Count; i++)
                {
                    if (Convert.ToBoolean(lstMealplans.GetItemCheckState(i)) == true)
                    {
                        DataHandler.AddSelectedMealplans(frmSignUp.username
                            , mealplans[i]);
                    }
                }
                DialogResult r= MessageBox.Show("Your preferences have been saved.", "Saved", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                if (r==DialogResult.OK)
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

        private void lstMealplans_Click(object sender, EventArgs e)
        {

            //Display mealplan description, advantages and disadvantages when 
            //mealplan is selected in listbox
            try
            {
                if (lstMealplans.SelectedIndex < mealplans.Count &&
                lstMealplans.SelectedIndex > -1)
                {
                    rtxtMealDescription.Text = mealplans[lstMealplans.SelectedIndex].Description;
                    txtAdvantages.Text = mealplans[lstMealplans.SelectedIndex].Advantages;
                    txtDisadvantages.Text = mealplans[lstMealplans.SelectedIndex].Disadvantages;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstAllergies_Click(object sender, EventArgs e)
        {
            //Display allergy description when allergy is selected in listbox
            try
            {
                if (lstAllergies.SelectedIndex < allergies.Count && lstAllergies.SelectedIndex > -1)
                {
                    rtxtDescription.Text = allergies[lstAllergies.SelectedIndex].Description;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
