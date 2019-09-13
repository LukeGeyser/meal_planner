﻿namespace MealPlannerDesktop
{
    partial class frmProfile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProfile));
            this.tabProfile = new System.Windows.Forms.TabControl();
            this.tabPersonal = new System.Windows.Forms.TabPage();
            this.lblPasswordInfo = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.txtConfirmP = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmP = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblCM = new System.Windows.Forms.Label();
            this.lblKG = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tabPreferences = new System.Windows.Forms.TabPage();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lstAllergies = new System.Windows.Forms.CheckedListBox();
            this.lblAllergies = new System.Windows.Forms.Label();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.lblMealPlans = new System.Windows.Forms.Label();
            this.cbxMealplan = new System.Windows.Forms.ComboBox();
            this.btnAddAllergy = new System.Windows.Forms.Button();
            this.lblAllergyDescribe = new System.Windows.Forms.Label();
            this.lblMealPlanDescribe = new System.Windows.Forms.Label();
            this.rtxtMealDescription = new System.Windows.Forms.RichTextBox();
            this.lblAdvantages = new System.Windows.Forms.Label();
            this.txtDisadvantages = new System.Windows.Forms.RichTextBox();
            this.lblDisadvantages = new System.Windows.Forms.Label();
            this.txtAdvantages = new System.Windows.Forms.RichTextBox();
            this.btnNewMealPlan = new System.Windows.Forms.Button();
            this.btnSavePreferences = new System.Windows.Forms.Button();
            this.tabProfile.SuspendLayout();
            this.tabPersonal.SuspendLayout();
            this.tabPreferences.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabProfile
            // 
            this.tabProfile.Controls.Add(this.tabPersonal);
            this.tabProfile.Controls.Add(this.tabPreferences);
            this.tabProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabProfile.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabProfile.Location = new System.Drawing.Point(12, 99);
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.SelectedIndex = 0;
            this.tabProfile.Size = new System.Drawing.Size(580, 419);
            this.tabProfile.TabIndex = 0;
            // 
            // tabPersonal
            // 
            this.tabPersonal.BackColor = System.Drawing.Color.White;
            this.tabPersonal.Controls.Add(this.lblPasswordInfo);
            this.tabPersonal.Controls.Add(this.btnApply);
            this.tabPersonal.Controls.Add(this.txtConfirmP);
            this.tabPersonal.Controls.Add(this.txtPassword);
            this.tabPersonal.Controls.Add(this.lblConfirmP);
            this.tabPersonal.Controls.Add(this.lblPassword);
            this.tabPersonal.Controls.Add(this.lblCM);
            this.tabPersonal.Controls.Add(this.lblKG);
            this.tabPersonal.Controls.Add(this.txtPhone);
            this.tabPersonal.Controls.Add(this.lblPhone);
            this.tabPersonal.Controls.Add(this.dtpDOB);
            this.tabPersonal.Controls.Add(this.txtHeight);
            this.tabPersonal.Controls.Add(this.txtWeight);
            this.tabPersonal.Controls.Add(this.txtEmail);
            this.tabPersonal.Controls.Add(this.lblHeight);
            this.tabPersonal.Controls.Add(this.lblWeight);
            this.tabPersonal.Controls.Add(this.lblEmail);
            this.tabPersonal.Controls.Add(this.lblDOB);
            this.tabPersonal.Controls.Add(this.txtSurname);
            this.tabPersonal.Controls.Add(this.lblSurname);
            this.tabPersonal.Controls.Add(this.txtName);
            this.tabPersonal.Controls.Add(this.lblName);
            this.tabPersonal.Location = new System.Drawing.Point(4, 32);
            this.tabPersonal.Name = "tabPersonal";
            this.tabPersonal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersonal.Size = new System.Drawing.Size(572, 383);
            this.tabPersonal.TabIndex = 0;
            this.tabPersonal.Text = "Personal Information";
            // 
            // lblPasswordInfo
            // 
            this.lblPasswordInfo.AutoSize = true;
            this.lblPasswordInfo.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordInfo.Location = new System.Drawing.Point(42, 238);
            this.lblPasswordInfo.Name = "lblPasswordInfo";
            this.lblPasswordInfo.Size = new System.Drawing.Size(384, 19);
            this.lblPasswordInfo.TabIndex = 51;
            this.lblPasswordInfo.Text = "Enter new Password or retype old Password to continue:";
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(183)))), ((int)(((byte)(43)))));
            this.btnApply.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.ForeColor = System.Drawing.Color.White;
            this.btnApply.Location = new System.Drawing.Point(383, 331);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(137, 32);
            this.btnApply.TabIndex = 50;
            this.btnApply.Text = "Apply Changes";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.BtnApply_Click);
            // 
            // txtConfirmP
            // 
            this.txtConfirmP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmP.Location = new System.Drawing.Point(224, 299);
            this.txtConfirmP.Name = "txtConfirmP";
            this.txtConfirmP.PasswordChar = '*';
            this.txtConfirmP.Size = new System.Drawing.Size(296, 26);
            this.txtConfirmP.TabIndex = 47;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(224, 264);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(296, 26);
            this.txtPassword.TabIndex = 46;
            // 
            // lblConfirmP
            // 
            this.lblConfirmP.AutoSize = true;
            this.lblConfirmP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmP.Location = new System.Drawing.Point(42, 302);
            this.lblConfirmP.Name = "lblConfirmP";
            this.lblConfirmP.Size = new System.Drawing.Size(129, 19);
            this.lblConfirmP.TabIndex = 45;
            this.lblConfirmP.Text = "Confirm Password";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(42, 267);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(71, 19);
            this.lblPassword.TabIndex = 44;
            this.lblPassword.Text = "Password";
            // 
            // lblCM
            // 
            this.lblCM.AutoSize = true;
            this.lblCM.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCM.Location = new System.Drawing.Point(461, 208);
            this.lblCM.Name = "lblCM";
            this.lblCM.Size = new System.Drawing.Size(32, 21);
            this.lblCM.TabIndex = 43;
            this.lblCM.Text = "cm";
            // 
            // lblKG
            // 
            this.lblKG.AutoSize = true;
            this.lblKG.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKG.Location = new System.Drawing.Point(460, 176);
            this.lblKG.Name = "lblKG";
            this.lblKG.Size = new System.Drawing.Size(33, 21);
            this.lblKG.TabIndex = 42;
            this.lblKG.Text = "Kg";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(224, 110);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(296, 26);
            this.txtPhone.TabIndex = 41;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(41, 113);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(106, 19);
            this.lblPhone.TabIndex = 40;
            this.lblPhone.Text = "Phone Number";
            // 
            // dtpDOB
            // 
            this.dtpDOB.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOB.Location = new System.Drawing.Point(224, 78);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(296, 26);
            this.dtpDOB.TabIndex = 39;
            // 
            // txtHeight
            // 
            this.txtHeight.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeight.Location = new System.Drawing.Point(224, 206);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(230, 26);
            this.txtHeight.TabIndex = 38;
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(224, 174);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(230, 26);
            this.txtWeight.TabIndex = 37;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(224, 142);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(296, 26);
            this.txtEmail.TabIndex = 36;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.Location = new System.Drawing.Point(42, 209);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(52, 19);
            this.lblHeight.TabIndex = 35;
            this.lblHeight.Text = "Height";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(41, 177);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(53, 19);
            this.lblWeight.TabIndex = 34;
            this.lblWeight.Text = "Weight";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(41, 145);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(101, 19);
            this.lblEmail.TabIndex = 33;
            this.lblEmail.Text = "Email Address";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(41, 84);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(96, 19);
            this.lblDOB.TabIndex = 32;
            this.lblDOB.Text = "Date Of Birth";
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(224, 46);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(296, 26);
            this.txtSurname.TabIndex = 18;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(41, 49);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(79, 19);
            this.lblSurname.TabIndex = 17;
            this.lblSurname.Text = "Last Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(224, 14);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(296, 26);
            this.txtName.TabIndex = 16;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(41, 17);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(82, 19);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "First Name";
            // 
            // tabPreferences
            // 
            this.tabPreferences.Controls.Add(this.btnSavePreferences);
            this.tabPreferences.Controls.Add(this.btnNewMealPlan);
            this.tabPreferences.Controls.Add(this.lblDisadvantages);
            this.tabPreferences.Controls.Add(this.txtAdvantages);
            this.tabPreferences.Controls.Add(this.lblAdvantages);
            this.tabPreferences.Controls.Add(this.txtDisadvantages);
            this.tabPreferences.Controls.Add(this.lblMealPlanDescribe);
            this.tabPreferences.Controls.Add(this.rtxtMealDescription);
            this.tabPreferences.Controls.Add(this.lblAllergyDescribe);
            this.tabPreferences.Controls.Add(this.btnAddAllergy);
            this.tabPreferences.Controls.Add(this.cbxMealplan);
            this.tabPreferences.Controls.Add(this.lblMealPlans);
            this.tabPreferences.Controls.Add(this.rtxtDescription);
            this.tabPreferences.Controls.Add(this.lblAllergies);
            this.tabPreferences.Controls.Add(this.lstAllergies);
            this.tabPreferences.ForeColor = System.Drawing.Color.Black;
            this.tabPreferences.Location = new System.Drawing.Point(4, 32);
            this.tabPreferences.Name = "tabPreferences";
            this.tabPreferences.Padding = new System.Windows.Forms.Padding(3);
            this.tabPreferences.Size = new System.Drawing.Size(572, 383);
            this.tabPreferences.TabIndex = 1;
            this.tabPreferences.Text = "App Preferences";
            this.tabPreferences.UseVisualStyleBackColor = true;
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.White;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.InitialImage = null;
            this.pbLogo.Location = new System.Drawing.Point(12, 3);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(576, 90);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 9;
            this.pbLogo.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(183)))), ((int)(((byte)(43)))));
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(455, 524);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(137, 32);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // lstAllergies
            // 
            this.lstAllergies.FormattingEnabled = true;
            this.lstAllergies.Location = new System.Drawing.Point(19, 39);
            this.lstAllergies.Name = "lstAllergies";
            this.lstAllergies.Size = new System.Drawing.Size(222, 85);
            this.lstAllergies.TabIndex = 0;
            // 
            // lblAllergies
            // 
            this.lblAllergies.AutoSize = true;
            this.lblAllergies.Location = new System.Drawing.Point(15, 13);
            this.lblAllergies.Name = "lblAllergies";
            this.lblAllergies.Size = new System.Drawing.Size(428, 23);
            this.lblAllergies.TabIndex = 1;
            this.lblAllergies.Text = "Please select allergies to take into consideration:";
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Location = new System.Drawing.Point(265, 58);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.ReadOnly = true;
            this.rtxtDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtxtDescription.Size = new System.Drawing.Size(280, 66);
            this.rtxtDescription.TabIndex = 2;
            this.rtxtDescription.Text = "";
            // 
            // lblMealPlans
            // 
            this.lblMealPlans.AutoSize = true;
            this.lblMealPlans.Location = new System.Drawing.Point(15, 169);
            this.lblMealPlans.Name = "lblMealPlans";
            this.lblMealPlans.Size = new System.Drawing.Size(381, 23);
            this.lblMealPlans.TabIndex = 3;
            this.lblMealPlans.Text = "Please select a mealplan you wish to folow:";
            // 
            // cbxMealplan
            // 
            this.cbxMealplan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMealplan.FormattingEnabled = true;
            this.cbxMealplan.Location = new System.Drawing.Point(19, 204);
            this.cbxMealplan.Name = "cbxMealplan";
            this.cbxMealplan.Size = new System.Drawing.Size(222, 31);
            this.cbxMealplan.TabIndex = 4;
            // 
            // btnAddAllergy
            // 
            this.btnAddAllergy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(183)))), ((int)(((byte)(43)))));
            this.btnAddAllergy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAllergy.ForeColor = System.Drawing.Color.White;
            this.btnAddAllergy.Location = new System.Drawing.Point(19, 130);
            this.btnAddAllergy.Name = "btnAddAllergy";
            this.btnAddAllergy.Size = new System.Drawing.Size(133, 32);
            this.btnAddAllergy.TabIndex = 11;
            this.btnAddAllergy.Text = "Add new allergy";
            this.btnAddAllergy.UseVisualStyleBackColor = false;
            // 
            // lblAllergyDescribe
            // 
            this.lblAllergyDescribe.AutoSize = true;
            this.lblAllergyDescribe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllergyDescribe.Location = new System.Drawing.Point(261, 39);
            this.lblAllergyDescribe.Name = "lblAllergyDescribe";
            this.lblAllergyDescribe.Size = new System.Drawing.Size(88, 19);
            this.lblAllergyDescribe.TabIndex = 16;
            this.lblAllergyDescribe.Text = "Description:";
            // 
            // lblMealPlanDescribe
            // 
            this.lblMealPlanDescribe.AutoSize = true;
            this.lblMealPlanDescribe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMealPlanDescribe.Location = new System.Drawing.Point(15, 242);
            this.lblMealPlanDescribe.Name = "lblMealPlanDescribe";
            this.lblMealPlanDescribe.Size = new System.Drawing.Size(88, 19);
            this.lblMealPlanDescribe.TabIndex = 18;
            this.lblMealPlanDescribe.Text = "Description:";
            // 
            // rtxtMealDescription
            // 
            this.rtxtMealDescription.Location = new System.Drawing.Point(19, 261);
            this.rtxtMealDescription.Name = "rtxtMealDescription";
            this.rtxtMealDescription.ReadOnly = true;
            this.rtxtMealDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtxtMealDescription.Size = new System.Drawing.Size(222, 66);
            this.rtxtMealDescription.TabIndex = 17;
            this.rtxtMealDescription.Text = "";
            // 
            // lblAdvantages
            // 
            this.lblAdvantages.AutoSize = true;
            this.lblAdvantages.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvantages.Location = new System.Drawing.Point(261, 192);
            this.lblAdvantages.Name = "lblAdvantages";
            this.lblAdvantages.Size = new System.Drawing.Size(90, 19);
            this.lblAdvantages.TabIndex = 20;
            this.lblAdvantages.Text = "Advantages:";
            // 
            // txtDisadvantages
            // 
            this.txtDisadvantages.Location = new System.Drawing.Point(265, 283);
            this.txtDisadvantages.Name = "txtDisadvantages";
            this.txtDisadvantages.ReadOnly = true;
            this.txtDisadvantages.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtDisadvantages.Size = new System.Drawing.Size(280, 44);
            this.txtDisadvantages.TabIndex = 19;
            this.txtDisadvantages.Text = "";
            // 
            // lblDisadvantages
            // 
            this.lblDisadvantages.AutoSize = true;
            this.lblDisadvantages.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisadvantages.Location = new System.Drawing.Point(261, 261);
            this.lblDisadvantages.Name = "lblDisadvantages";
            this.lblDisadvantages.Size = new System.Drawing.Size(109, 19);
            this.lblDisadvantages.TabIndex = 22;
            this.lblDisadvantages.Text = "Disadvantages:";
            // 
            // txtAdvantages
            // 
            this.txtAdvantages.Location = new System.Drawing.Point(265, 214);
            this.txtAdvantages.Name = "txtAdvantages";
            this.txtAdvantages.ReadOnly = true;
            this.txtAdvantages.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtAdvantages.Size = new System.Drawing.Size(280, 44);
            this.txtAdvantages.TabIndex = 21;
            this.txtAdvantages.Text = "";
            // 
            // btnNewMealPlan
            // 
            this.btnNewMealPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(183)))), ((int)(((byte)(43)))));
            this.btnNewMealPlan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewMealPlan.ForeColor = System.Drawing.Color.White;
            this.btnNewMealPlan.Location = new System.Drawing.Point(19, 333);
            this.btnNewMealPlan.Name = "btnNewMealPlan";
            this.btnNewMealPlan.Size = new System.Drawing.Size(133, 32);
            this.btnNewMealPlan.TabIndex = 23;
            this.btnNewMealPlan.Text = "Add new mealplan";
            this.btnNewMealPlan.UseVisualStyleBackColor = false;
            // 
            // btnSavePreferences
            // 
            this.btnSavePreferences.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(183)))), ((int)(((byte)(43)))));
            this.btnSavePreferences.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePreferences.ForeColor = System.Drawing.Color.White;
            this.btnSavePreferences.Location = new System.Drawing.Point(383, 345);
            this.btnSavePreferences.Name = "btnSavePreferences";
            this.btnSavePreferences.Size = new System.Drawing.Size(183, 32);
            this.btnSavePreferences.TabIndex = 24;
            this.btnSavePreferences.Text = "Save Preferences";
            this.btnSavePreferences.UseVisualStyleBackColor = false;
            // 
            // frmProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(604, 568);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.tabProfile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Profile";
            this.Load += new System.EventHandler(this.FrmProfile_Load);
            this.tabProfile.ResumeLayout(false);
            this.tabPersonal.ResumeLayout(false);
            this.tabPersonal.PerformLayout();
            this.tabPreferences.ResumeLayout(false);
            this.tabPreferences.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabProfile;
        private System.Windows.Forms.TabPage tabPersonal;
        private System.Windows.Forms.TabPage tabPreferences;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblCM;
        private System.Windows.Forms.Label lblKG;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.TextBox txtConfirmP;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblConfirmP;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label lblPasswordInfo;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.Label lblAllergies;
        private System.Windows.Forms.CheckedListBox lstAllergies;
        private System.Windows.Forms.ComboBox cbxMealplan;
        private System.Windows.Forms.Label lblMealPlans;
        private System.Windows.Forms.Button btnAddAllergy;
        private System.Windows.Forms.Label lblAllergyDescribe;
        private System.Windows.Forms.Label lblMealPlanDescribe;
        private System.Windows.Forms.RichTextBox rtxtMealDescription;
        private System.Windows.Forms.Label lblDisadvantages;
        private System.Windows.Forms.RichTextBox txtAdvantages;
        private System.Windows.Forms.Label lblAdvantages;
        private System.Windows.Forms.RichTextBox txtDisadvantages;
        private System.Windows.Forms.Button btnNewMealPlan;
        private System.Windows.Forms.Button btnSavePreferences;
    }
}