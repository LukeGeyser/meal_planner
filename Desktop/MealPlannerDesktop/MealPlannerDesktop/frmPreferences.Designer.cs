namespace MealPlannerDesktop
{
    partial class frmPreferences
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPreferences));
            this.lstMealplans = new System.Windows.Forms.CheckedListBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblDisadvantages = new System.Windows.Forms.Label();
            this.txtAdvantages = new System.Windows.Forms.RichTextBox();
            this.lblAdvantages = new System.Windows.Forms.Label();
            this.txtDisadvantages = new System.Windows.Forms.RichTextBox();
            this.lblMealPlanDescribe = new System.Windows.Forms.Label();
            this.rtxtMealDescription = new System.Windows.Forms.RichTextBox();
            this.lblAllergyDescribe = new System.Windows.Forms.Label();
            this.lblMealPlans = new System.Windows.Forms.Label();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.lblAllergies = new System.Windows.Forms.Label();
            this.lstAllergies = new System.Windows.Forms.CheckedListBox();
            this.lblEdit = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lstMealplans
            // 
            this.lstMealplans.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMealplans.FormattingEnabled = true;
            this.lstMealplans.Location = new System.Drawing.Point(254, 181);
            this.lstMealplans.Name = "lstMealplans";
            this.lstMealplans.Size = new System.Drawing.Size(258, 88);
            this.lstMealplans.TabIndex = 40;
            this.lstMealplans.Click += new System.EventHandler(this.lstMealplans_Click);
            this.lstMealplans.SelectedIndexChanged += new System.EventHandler(this.lstMealplans_SelectedIndexChanged);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(183)))), ((int)(((byte)(43)))));
            this.btnCreate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(593, 393);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(195, 49);
            this.btnCreate.TabIndex = 39;
            this.btnCreate.Text = "Create Account";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblDisadvantages
            // 
            this.lblDisadvantages.AutoSize = true;
            this.lblDisadvantages.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisadvantages.Location = new System.Drawing.Point(522, 284);
            this.lblDisadvantages.Name = "lblDisadvantages";
            this.lblDisadvantages.Size = new System.Drawing.Size(109, 19);
            this.lblDisadvantages.TabIndex = 37;
            this.lblDisadvantages.Text = "Disadvantages:";
            // 
            // txtAdvantages
            // 
            this.txtAdvantages.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdvantages.Location = new System.Drawing.Point(254, 306);
            this.txtAdvantages.Name = "txtAdvantages";
            this.txtAdvantages.ReadOnly = true;
            this.txtAdvantages.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtAdvantages.Size = new System.Drawing.Size(258, 78);
            this.txtAdvantages.TabIndex = 36;
            this.txtAdvantages.Text = "";
            // 
            // lblAdvantages
            // 
            this.lblAdvantages.AutoSize = true;
            this.lblAdvantages.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvantages.Location = new System.Drawing.Point(250, 284);
            this.lblAdvantages.Name = "lblAdvantages";
            this.lblAdvantages.Size = new System.Drawing.Size(90, 19);
            this.lblAdvantages.TabIndex = 35;
            this.lblAdvantages.Text = "Advantages:";
            // 
            // txtDisadvantages
            // 
            this.txtDisadvantages.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisadvantages.Location = new System.Drawing.Point(524, 306);
            this.txtDisadvantages.Name = "txtDisadvantages";
            this.txtDisadvantages.ReadOnly = true;
            this.txtDisadvantages.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtDisadvantages.Size = new System.Drawing.Size(258, 75);
            this.txtDisadvantages.TabIndex = 34;
            this.txtDisadvantages.Text = "";
            // 
            // lblMealPlanDescribe
            // 
            this.lblMealPlanDescribe.AutoSize = true;
            this.lblMealPlanDescribe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMealPlanDescribe.Location = new System.Drawing.Point(520, 172);
            this.lblMealPlanDescribe.Name = "lblMealPlanDescribe";
            this.lblMealPlanDescribe.Size = new System.Drawing.Size(88, 19);
            this.lblMealPlanDescribe.TabIndex = 33;
            this.lblMealPlanDescribe.Text = "Description:";
            // 
            // rtxtMealDescription
            // 
            this.rtxtMealDescription.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtMealDescription.Location = new System.Drawing.Point(524, 194);
            this.rtxtMealDescription.Name = "rtxtMealDescription";
            this.rtxtMealDescription.ReadOnly = true;
            this.rtxtMealDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtxtMealDescription.Size = new System.Drawing.Size(258, 75);
            this.rtxtMealDescription.TabIndex = 32;
            this.rtxtMealDescription.Text = "";
            // 
            // lblAllergyDescribe
            // 
            this.lblAllergyDescribe.AutoSize = true;
            this.lblAllergyDescribe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllergyDescribe.Location = new System.Drawing.Point(520, 21);
            this.lblAllergyDescribe.Name = "lblAllergyDescribe";
            this.lblAllergyDescribe.Size = new System.Drawing.Size(88, 19);
            this.lblAllergyDescribe.TabIndex = 31;
            this.lblAllergyDescribe.Text = "Description:";
            // 
            // lblMealPlans
            // 
            this.lblMealPlans.AutoSize = true;
            this.lblMealPlans.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMealPlans.Location = new System.Drawing.Point(250, 148);
            this.lblMealPlans.Name = "lblMealPlans";
            this.lblMealPlans.Size = new System.Drawing.Size(380, 22);
            this.lblMealPlans.TabIndex = 29;
            this.lblMealPlans.Text = "Please select any mealplans you wish to folow:";
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtDescription.Location = new System.Drawing.Point(524, 43);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.ReadOnly = true;
            this.rtxtDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtxtDescription.Size = new System.Drawing.Size(258, 87);
            this.rtxtDescription.TabIndex = 28;
            this.rtxtDescription.Text = "";
            // 
            // lblAllergies
            // 
            this.lblAllergies.AutoSize = true;
            this.lblAllergies.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllergies.Location = new System.Drawing.Point(254, 9);
            this.lblAllergies.Name = "lblAllergies";
            this.lblAllergies.Size = new System.Drawing.Size(227, 22);
            this.lblAllergies.TabIndex = 27;
            this.lblAllergies.Text = "Please select your allergies:";
            // 
            // lstAllergies
            // 
            this.lstAllergies.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAllergies.FormattingEnabled = true;
            this.lstAllergies.Location = new System.Drawing.Point(254, 43);
            this.lstAllergies.Name = "lstAllergies";
            this.lstAllergies.Size = new System.Drawing.Size(258, 88);
            this.lstAllergies.TabIndex = 26;
            this.lstAllergies.Click += new System.EventHandler(this.lstAllergies_Click);
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdit.Location = new System.Drawing.Point(254, 416);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(323, 22);
            this.lblEdit.TabIndex = 41;
            this.lblEdit.Text = "*These can be edited under \'My profile\'";
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.White;
            this.pbLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.InitialImage = null;
            this.pbLogo.Location = new System.Drawing.Point(3, 9);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(245, 436);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 42;
            this.pbLogo.TabStop = false;
            // 
            // frmPreferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lblEdit);
            this.Controls.Add(this.lstMealplans);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblDisadvantages);
            this.Controls.Add(this.txtAdvantages);
            this.Controls.Add(this.lblAdvantages);
            this.Controls.Add(this.txtDisadvantages);
            this.Controls.Add(this.lblMealPlanDescribe);
            this.Controls.Add(this.rtxtMealDescription);
            this.Controls.Add(this.lblAllergyDescribe);
            this.Controls.Add(this.lblMealPlans);
            this.Controls.Add(this.rtxtDescription);
            this.Controls.Add(this.lblAllergies);
            this.Controls.Add(this.lstAllergies);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPreferences";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App Preferences";
            this.Load += new System.EventHandler(this.frmPreferences_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox lstMealplans;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblDisadvantages;
        private System.Windows.Forms.RichTextBox txtAdvantages;
        private System.Windows.Forms.Label lblAdvantages;
        private System.Windows.Forms.RichTextBox txtDisadvantages;
        private System.Windows.Forms.Label lblMealPlanDescribe;
        private System.Windows.Forms.RichTextBox rtxtMealDescription;
        private System.Windows.Forms.Label lblAllergyDescribe;
        private System.Windows.Forms.Label lblMealPlans;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.Label lblAllergies;
        private System.Windows.Forms.CheckedListBox lstAllergies;
        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}