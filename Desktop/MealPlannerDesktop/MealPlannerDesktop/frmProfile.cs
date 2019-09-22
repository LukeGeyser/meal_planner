using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MealPlannerDesktop
{
    public partial class frmProfile : Form
    {
        public frmProfile()
        {
            InitializeComponent();
        }

        List<Allergies> allergies;
        List<UserAllergies> selectedAllegies;
        List<MealPlans> mealplans;
        List<UserMealPlan> selectedMealPlans;

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

        private void FrmProfile_Load(object sender, EventArgs e)
        {
            try
            {
                txtName.Text = frmSignIn.SuccessfulLogin.FirstName;
                txtSurname.Text = frmSignIn.SuccessfulLogin.LastName;
                dtpDOB.Value = frmSignIn.SuccessfulLogin.DOB;
                txtPhone.Text = frmSignIn.SuccessfulLogin.Phone;
                txtEmail.Text = frmSignIn.SuccessfulLogin.Email;
                txtWeight.Text = frmSignIn.SuccessfulLogin.Weight.ToString();
                txtHeight.Text = frmSignIn.SuccessfulLogin.Height.ToString();

                allergies = DataHandler.GetAllAllergies();
                selectedAllegies = DataHandler.GetSelectedAllergies(frmSignIn.SuccessfulLogin.Username);
                lstAllergies.Items.Clear();
                for (int i = 0; i < allergies.Count; i++)
                {
                    lstAllergies.Items.Add(allergies[i].AllergyName);
                    bool found = false;
                    int count = 0;
                    while(found == false && count < selectedAllegies.Count)
                    {
                        if (selectedAllegies[count].AllergyID == allergies[i].AllergyID)
                        {
                            found = true;
                            lstAllergies.SetItemChecked(i, true);
                        }
                        else
                        {
                            found = false;
                            count++;
                        }
                    }                    
                }

                mealplans = DataHandler.GetAllMealPlans();
                selectedMealPlans = DataHandler.GetSelectedMealPlans(frmSignIn.SuccessfulLogin.Username);
                lstMealplans.Items.Clear();
                for (int i = 0; i < mealplans.Count; i++)
                {
                    lstMealplans.Items.Add(mealplans[i].MealPlanName);
                    bool found = false;
                    int count = 0;
                    while (found == false && count < selectedMealPlans.Count)
                    {
                        if (selectedMealPlans[count].MealPlanID == mealplans[i].MealPlanID)
                        {
                            found = true;
                            lstMealplans.SetItemChecked(i, true);
                        }
                        else
                        {
                            found = false;
                            count++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtName.Text) || (string.IsNullOrEmpty(txtSurname.Text) || string.IsNullOrEmpty(txtWeight.Text) || string.IsNullOrEmpty(txtHeight.Text) ||
                   string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtConfirmP.Text) || string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPhone.Text) ||
                   string.IsNullOrEmpty(txtEmail.Text)))
                {
                    MessageBox.Show("Please make sure all details are entered.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    User NUser = SecurityService.EncryptNewPassword(new User(frmSignIn.SuccessfulLogin.Username
                    , txtPassword.Text));
                    NUser.FirstName = txtName.Text;
                    NUser.LastName = txtSurname.Text;
                    NUser.Phone = txtPhone.Text;

                    if (IsValidEmail(txtEmail.Text))
                    {
                        NUser.Email = txtEmail.Text;
                    }
                    else
                    {
                        throw new Exception("Invalid email address entered.");
                    }

                    NUser.DOB = dtpDOB.Value;
                    NUser.Weight = double.Parse(txtWeight.Text);
                    NUser.Height = double.Parse(txtHeight.Text);

                    if (txtPassword.Text == txtConfirmP.Text)
                    {
                        DataHandler.UpdateUserDetails(NUser);
                        DataHandler.UpdateUserProgress(NUser.Username, double.Parse(txtWeight.Text));
                        txtPassword.Clear();
                        txtConfirmP.Clear();
                        frmSignIn.SuccessfulLogin = NUser;
                    }
                    else
                    {
                        DialogResult w = MessageBox.Show("Passwords do not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (w == DialogResult.OK)
                        {
                            txtPassword.Clear();
                            txtConfirmP.Clear();
                        }
                    }
                }                   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool IsValidEmail(string source)
        {
            return new EmailAddressAttribute().IsValid(source);
        }

        private void LstAllergies_Enter(object sender, EventArgs e)
        {
            

        }

        private void LstAllergies_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstAllergies.SelectedIndex < allergies.Count &&
               lstAllergies.SelectedIndex > -1)
                {
                    rtxtDescription.Text = allergies[lstAllergies.SelectedIndex].Description;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LstMealplans_Click(object sender, EventArgs e)
        {
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

        private void btnAddAllergy_Click(object sender, EventArgs e)
        {
            try
            {
                frmAddAllergy fra = new frmAddAllergy();
                fra.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void btnNewMealPlan_Click(object sender, EventArgs e)
        {
            try
            {
                frmAddMealPlan frm = new frmAddMealPlan();
                frm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSavePreferences_Click(object sender, EventArgs e)
        {
            try
            {
                DataHandler.RemoveAllPreferences(frmSignIn.SuccessfulLogin.Username);
                for(int i = 0; i < lstAllergies.Items.Count; i++)
                {
                    if(Convert.ToBoolean(lstAllergies.GetItemCheckState(i)) == true)
                    {
                        DataHandler.AddSelectedAllergy(frmSignIn.SuccessfulLogin.Username
                            , allergies[i]);
                    }
                }
                for (int i = 0; i < lstMealplans.Items.Count; i++)
                {
                    if (Convert.ToBoolean(lstMealplans.GetItemCheckState(i)) == true)
                    {
                        DataHandler.AddSelectedMealplans(frmSignIn.SuccessfulLogin.Username
                            , mealplans[i]);
                    }
                }
                MessageBox.Show("Your preferences have been saved.", "Saved", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
