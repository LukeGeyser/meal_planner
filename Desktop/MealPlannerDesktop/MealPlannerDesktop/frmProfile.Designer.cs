namespace MealPlannerDesktop
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
            this.lstMealplans = new System.Windows.Forms.CheckedListBox();
            this.btnSavePreferences = new System.Windows.Forms.Button();
            this.btnNewMealPlan = new System.Windows.Forms.Button();
            this.lblDisadvantages = new System.Windows.Forms.Label();
            this.txtAdvantages = new System.Windows.Forms.RichTextBox();
            this.lblAdvantages = new System.Windows.Forms.Label();
            this.txtDisadvantages = new System.Windows.Forms.RichTextBox();
            this.lblMealPlanDescribe = new System.Windows.Forms.Label();
            this.rtxtMealDescription = new System.Windows.Forms.RichTextBox();
            this.lblAllergyDescribe = new System.Windows.Forms.Label();
            this.btnAddAllergy = new System.Windows.Forms.Button();
            this.lblMealPlans = new System.Windows.Forms.Label();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.lblAllergies = new System.Windows.Forms.Label();
            this.lstAllergies = new System.Windows.Forms.CheckedListBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
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
            this.tabProfile.Size = new System.Drawing.Size(580, 440);
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
            this.tabPersonal.Size = new System.Drawing.Size(572, 404);
            this.tabPersonal.TabIndex = 0;
            this.tabPersonal.Text = "Personal Information";
            // 
            // lblPasswordInfo
            // 
            this.lblPasswordInfo.AutoSize = true;
            this.lblPasswordInfo.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordInfo.Location = new System.Drawing.Point(38, 259);
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
            this.btnApply.Location = new System.Drawing.Point(417, 356);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(149, 42);
            this.btnApply.TabIndex = 50;
            this.btnApply.Text = "Apply Changes";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.BtnApply_Click);
            // 
            // txtConfirmP
            // 
            this.txtConfirmP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmP.Location = new System.Drawing.Point(220, 320);
            this.txtConfirmP.Name = "txtConfirmP";
            this.txtConfirmP.PasswordChar = '*';
            this.txtConfirmP.Size = new System.Drawing.Size(296, 26);
            this.txtConfirmP.TabIndex = 47;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(220, 285);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(296, 26);
            this.txtPassword.TabIndex = 46;
            // 
            // lblConfirmP
            // 
            this.lblConfirmP.AutoSize = true;
            this.lblConfirmP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmP.Location = new System.Drawing.Point(38, 323);
            this.lblConfirmP.Name = "lblConfirmP";
            this.lblConfirmP.Size = new System.Drawing.Size(129, 19);
            this.lblConfirmP.TabIndex = 45;
            this.lblConfirmP.Text = "Confirm Password";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(38, 288);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(71, 19);
            this.lblPassword.TabIndex = 44;
            this.lblPassword.Text = "Password";
            // 
            // lblCM
            // 
            this.lblCM.AutoSize = true;
            this.lblCM.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCM.Location = new System.Drawing.Point(457, 219);
            this.lblCM.Name = "lblCM";
            this.lblCM.Size = new System.Drawing.Size(32, 21);
            this.lblCM.TabIndex = 43;
            this.lblCM.Text = "cm";
            // 
            // lblKG
            // 
            this.lblKG.AutoSize = true;
            this.lblKG.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKG.Location = new System.Drawing.Point(456, 187);
            this.lblKG.Name = "lblKG";
            this.lblKG.Size = new System.Drawing.Size(33, 21);
            this.lblKG.TabIndex = 42;
            this.lblKG.Text = "Kg";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(220, 121);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(296, 26);
            this.txtPhone.TabIndex = 41;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(37, 124);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(106, 19);
            this.lblPhone.TabIndex = 40;
            this.lblPhone.Text = "Phone Number";
            // 
            // dtpDOB
            // 
            this.dtpDOB.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOB.Location = new System.Drawing.Point(220, 89);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(296, 26);
            this.dtpDOB.TabIndex = 39;
            // 
            // txtHeight
            // 
            this.txtHeight.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeight.Location = new System.Drawing.Point(220, 217);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(230, 26);
            this.txtHeight.TabIndex = 38;
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(220, 185);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(230, 26);
            this.txtWeight.TabIndex = 37;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(220, 153);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(296, 26);
            this.txtEmail.TabIndex = 36;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.Location = new System.Drawing.Point(38, 220);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(52, 19);
            this.lblHeight.TabIndex = 35;
            this.lblHeight.Text = "Height";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(37, 188);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(53, 19);
            this.lblWeight.TabIndex = 34;
            this.lblWeight.Text = "Weight";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(37, 156);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(101, 19);
            this.lblEmail.TabIndex = 33;
            this.lblEmail.Text = "Email Address";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(37, 95);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(96, 19);
            this.lblDOB.TabIndex = 32;
            this.lblDOB.Text = "Date Of Birth";
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(220, 57);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(296, 26);
            this.txtSurname.TabIndex = 18;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(37, 60);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(79, 19);
            this.lblSurname.TabIndex = 17;
            this.lblSurname.Text = "Last Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(220, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(296, 26);
            this.txtName.TabIndex = 16;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(37, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(82, 19);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "First Name";
            // 
            // tabPreferences
            // 
            this.tabPreferences.Controls.Add(this.lstMealplans);
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
            this.tabPreferences.Controls.Add(this.lblMealPlans);
            this.tabPreferences.Controls.Add(this.rtxtDescription);
            this.tabPreferences.Controls.Add(this.lblAllergies);
            this.tabPreferences.Controls.Add(this.lstAllergies);
            this.tabPreferences.ForeColor = System.Drawing.Color.Black;
            this.tabPreferences.Location = new System.Drawing.Point(4, 32);
            this.tabPreferences.Name = "tabPreferences";
            this.tabPreferences.Padding = new System.Windows.Forms.Padding(3);
            this.tabPreferences.Size = new System.Drawing.Size(572, 404);
            this.tabPreferences.TabIndex = 1;
            this.tabPreferences.Text = "App Preferences";
            this.tabPreferences.UseVisualStyleBackColor = true;
            // 
            // lstMealplans
            // 
            this.lstMealplans.FormattingEnabled = true;
            this.lstMealplans.Location = new System.Drawing.Point(19, 194);
            this.lstMealplans.Name = "lstMealplans";
            this.lstMealplans.Size = new System.Drawing.Size(258, 85);
            this.lstMealplans.TabIndex = 25;
            this.lstMealplans.Click += new System.EventHandler(this.LstMealplans_Click);
            // 
            // btnSavePreferences
            // 
            this.btnSavePreferences.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(183)))), ((int)(((byte)(43)))));
            this.btnSavePreferences.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePreferences.ForeColor = System.Drawing.Color.White;
            this.btnSavePreferences.Location = new System.Drawing.Point(383, 366);
            this.btnSavePreferences.Name = "btnSavePreferences";
            this.btnSavePreferences.Size = new System.Drawing.Size(183, 32);
            this.btnSavePreferences.TabIndex = 24;
            this.btnSavePreferences.Text = "Save Preferences";
            this.btnSavePreferences.UseVisualStyleBackColor = false;
            this.btnSavePreferences.Click += new System.EventHandler(this.BtnSavePreferences_Click);
            // 
            // btnNewMealPlan
            // 
            this.btnNewMealPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(183)))), ((int)(((byte)(43)))));
            this.btnNewMealPlan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewMealPlan.ForeColor = System.Drawing.Color.White;
            this.btnNewMealPlan.Location = new System.Drawing.Point(19, 366);
            this.btnNewMealPlan.Name = "btnNewMealPlan";
            this.btnNewMealPlan.Size = new System.Drawing.Size(146, 32);
            this.btnNewMealPlan.TabIndex = 23;
            this.btnNewMealPlan.Text = "Add new meal plan";
            this.btnNewMealPlan.UseVisualStyleBackColor = false;
            this.btnNewMealPlan.Click += new System.EventHandler(this.btnNewMealPlan_Click);
            // 
            // lblDisadvantages
            // 
            this.lblDisadvantages.AutoSize = true;
            this.lblDisadvantages.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisadvantages.Location = new System.Drawing.Point(283, 282);
            this.lblDisadvantages.Name = "lblDisadvantages";
            this.lblDisadvantages.Size = new System.Drawing.Size(109, 19);
            this.lblDisadvantages.TabIndex = 22;
            this.lblDisadvantages.Text = "Disadvantages:";
            // 
            // txtAdvantages
            // 
            this.txtAdvantages.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdvantages.Location = new System.Drawing.Point(19, 304);
            this.txtAdvantages.Name = "txtAdvantages";
            this.txtAdvantages.ReadOnly = true;
            this.txtAdvantages.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtAdvantages.Size = new System.Drawing.Size(258, 56);
            this.txtAdvantages.TabIndex = 21;
            this.txtAdvantages.Text = "";
            // 
            // lblAdvantages
            // 
            this.lblAdvantages.AutoSize = true;
            this.lblAdvantages.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvantages.Location = new System.Drawing.Point(13, 282);
            this.lblAdvantages.Name = "lblAdvantages";
            this.lblAdvantages.Size = new System.Drawing.Size(90, 19);
            this.lblAdvantages.TabIndex = 20;
            this.lblAdvantages.Text = "Advantages:";
            // 
            // txtDisadvantages
            // 
            this.txtDisadvantages.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisadvantages.Location = new System.Drawing.Point(287, 304);
            this.txtDisadvantages.Name = "txtDisadvantages";
            this.txtDisadvantages.ReadOnly = true;
            this.txtDisadvantages.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtDisadvantages.Size = new System.Drawing.Size(258, 56);
            this.txtDisadvantages.TabIndex = 19;
            this.txtDisadvantages.Text = "";
            // 
            // lblMealPlanDescribe
            // 
            this.lblMealPlanDescribe.AutoSize = true;
            this.lblMealPlanDescribe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMealPlanDescribe.Location = new System.Drawing.Point(283, 194);
            this.lblMealPlanDescribe.Name = "lblMealPlanDescribe";
            this.lblMealPlanDescribe.Size = new System.Drawing.Size(88, 19);
            this.lblMealPlanDescribe.TabIndex = 18;
            this.lblMealPlanDescribe.Text = "Description:";
            // 
            // rtxtMealDescription
            // 
            this.rtxtMealDescription.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtMealDescription.Location = new System.Drawing.Point(287, 217);
            this.rtxtMealDescription.Name = "rtxtMealDescription";
            this.rtxtMealDescription.ReadOnly = true;
            this.rtxtMealDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtxtMealDescription.Size = new System.Drawing.Size(258, 56);
            this.rtxtMealDescription.TabIndex = 17;
            this.rtxtMealDescription.Text = "";
            // 
            // lblAllergyDescribe
            // 
            this.lblAllergyDescribe.AutoSize = true;
            this.lblAllergyDescribe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllergyDescribe.Location = new System.Drawing.Point(283, 35);
            this.lblAllergyDescribe.Name = "lblAllergyDescribe";
            this.lblAllergyDescribe.Size = new System.Drawing.Size(88, 19);
            this.lblAllergyDescribe.TabIndex = 16;
            this.lblAllergyDescribe.Text = "Description:";
            // 
            // btnAddAllergy
            // 
            this.btnAddAllergy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(183)))), ((int)(((byte)(43)))));
            this.btnAddAllergy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAllergy.ForeColor = System.Drawing.Color.White;
            this.btnAddAllergy.Location = new System.Drawing.Point(19, 129);
            this.btnAddAllergy.Name = "btnAddAllergy";
            this.btnAddAllergy.Size = new System.Drawing.Size(146, 32);
            this.btnAddAllergy.TabIndex = 11;
            this.btnAddAllergy.Text = "Add new allergy";
            this.btnAddAllergy.UseVisualStyleBackColor = false;
            this.btnAddAllergy.Click += new System.EventHandler(this.btnAddAllergy_Click);
            // 
            // lblMealPlans
            // 
            this.lblMealPlans.AutoSize = true;
            this.lblMealPlans.Location = new System.Drawing.Point(15, 168);
            this.lblMealPlans.Name = "lblMealPlans";
            this.lblMealPlans.Size = new System.Drawing.Size(409, 23);
            this.lblMealPlans.TabIndex = 3;
            this.lblMealPlans.Text = "Please select any mealplans you wish to folow:";
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtDescription.Location = new System.Drawing.Point(287, 57);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.ReadOnly = true;
            this.rtxtDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtxtDescription.Size = new System.Drawing.Size(258, 66);
            this.rtxtDescription.TabIndex = 2;
            this.rtxtDescription.Text = "";
            // 
            // lblAllergies
            // 
            this.lblAllergies.AutoSize = true;
            this.lblAllergies.Location = new System.Drawing.Point(15, 12);
            this.lblAllergies.Name = "lblAllergies";
            this.lblAllergies.Size = new System.Drawing.Size(247, 23);
            this.lblAllergies.TabIndex = 1;
            this.lblAllergies.Text = "Please select your allergies:";
            // 
            // lstAllergies
            // 
            this.lstAllergies.FormattingEnabled = true;
            this.lstAllergies.Location = new System.Drawing.Point(19, 38);
            this.lstAllergies.Name = "lstAllergies";
            this.lstAllergies.Size = new System.Drawing.Size(258, 85);
            this.lstAllergies.TabIndex = 0;
            this.lstAllergies.Click += new System.EventHandler(this.LstAllergies_Click);
            this.lstAllergies.Enter += new System.EventHandler(this.LstAllergies_Enter);
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
            this.btnBack.Location = new System.Drawing.Point(12, 545);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(137, 41);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // frmProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(604, 589);
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
        private System.Windows.Forms.CheckedListBox lstMealplans;
    }
}