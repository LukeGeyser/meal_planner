namespace MealPlannerDesktop
{
    partial class frmBrowseRecipes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBrowseRecipes));
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.lblRecipeName = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlRecipe = new System.Windows.Forms.Panel();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.tnNext = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRecipeNameValue = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.rtxtInstructions = new System.Windows.Forms.RichTextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblTimeToPrepare = new System.Windows.Forms.Label();
            this.lblDifficult = new System.Windows.Forms.Label();
            this.lblDifficultyValue = new System.Windows.Forms.Label();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.lblMealplans = new System.Windows.Forms.Label();
            this.lblAllergies = new System.Windows.Forms.Label();
            this.lstMealplans = new System.Windows.Forms.ListBox();
            this.lstAllergies = new System.Windows.Forms.ListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.radAll = new System.Windows.Forms.RadioButton();
            this.radPreference = new System.Windows.Forms.RadioButton();
            this.btnProducts = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlRecipe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.gbxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.White;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.InitialImage = null;
            this.pbLogo.Location = new System.Drawing.Point(1, 2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(136, 90);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 10;
            this.pbLogo.TabStop = false;
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecipeName.Location = new System.Drawing.Point(313, 48);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(296, 26);
            this.txtRecipeName.TabIndex = 18;
            this.txtRecipeName.Text = "All";
            // 
            // lblRecipeName
            // 
            this.lblRecipeName.AutoSize = true;
            this.lblRecipeName.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipeName.Location = new System.Drawing.Point(204, 51);
            this.lblRecipeName.Name = "lblRecipeName";
            this.lblRecipeName.Size = new System.Drawing.Size(97, 19);
            this.lblRecipeName.TabIndex = 17;
            this.lblRecipeName.Text = "Recipe Name";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(183)))), ((int)(((byte)(43)))));
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(656, 44);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(103, 32);
            this.btnSearch.TabIndex = 51;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // pnlRecipe
            // 
            this.pnlRecipe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlRecipe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlRecipe.Controls.Add(this.btnProducts);
            this.pnlRecipe.Controls.Add(this.lstAllergies);
            this.pnlRecipe.Controls.Add(this.lstMealplans);
            this.pnlRecipe.Controls.Add(this.lblAllergies);
            this.pnlRecipe.Controls.Add(this.lblMealplans);
            this.pnlRecipe.Controls.Add(this.picPreview);
            this.pnlRecipe.Controls.Add(this.lblDifficultyValue);
            this.pnlRecipe.Controls.Add(this.lblDifficult);
            this.pnlRecipe.Controls.Add(this.lblTimeToPrepare);
            this.pnlRecipe.Controls.Add(this.lblTime);
            this.pnlRecipe.Controls.Add(this.rtxtInstructions);
            this.pnlRecipe.Controls.Add(this.lblInstructions);
            this.pnlRecipe.Controls.Add(this.rtxtDescription);
            this.pnlRecipe.Controls.Add(this.lblDescription);
            this.pnlRecipe.Controls.Add(this.lblRecipeNameValue);
            this.pnlRecipe.Controls.Add(this.lblName);
            this.pnlRecipe.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlRecipe.Location = new System.Drawing.Point(12, 98);
            this.pnlRecipe.Name = "pnlRecipe";
            this.pnlRecipe.Size = new System.Drawing.Size(835, 296);
            this.pnlRecipe.TabIndex = 52;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(183)))), ((int)(((byte)(43)))));
            this.btnPrevious.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Location = new System.Drawing.Point(12, 400);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(168, 32);
            this.btnPrevious.TabIndex = 53;
            this.btnPrevious.Text = "< Previous Recipe";
            this.btnPrevious.UseVisualStyleBackColor = false;
            // 
            // tnNext
            // 
            this.tnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(183)))), ((int)(((byte)(43)))));
            this.tnNext.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tnNext.ForeColor = System.Drawing.Color.White;
            this.tnNext.Location = new System.Drawing.Point(679, 400);
            this.tnNext.Name = "tnNext";
            this.tnNext.Size = new System.Drawing.Size(168, 32);
            this.tnNext.TabIndex = 54;
            this.tnNext.Text = "Next Recipe >";
            this.tnNext.UseVisualStyleBackColor = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(15, 17);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(92, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Recipe Name:";
            // 
            // lblRecipeNameValue
            // 
            this.lblRecipeNameValue.AutoSize = true;
            this.lblRecipeNameValue.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipeNameValue.Location = new System.Drawing.Point(124, 17);
            this.lblRecipeNameValue.Name = "lblRecipeNameValue";
            this.lblRecipeNameValue.Size = new System.Drawing.Size(112, 17);
            this.lblRecipeNameValue.TabIndex = 1;
            this.lblRecipeNameValue.Text = "Name of Recipe";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(18, 44);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(78, 17);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description:";
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Location = new System.Drawing.Point(127, 44);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.ReadOnly = true;
            this.rtxtDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtxtDescription.Size = new System.Drawing.Size(340, 61);
            this.rtxtDescription.TabIndex = 3;
            this.rtxtDescription.Text = "";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(18, 114);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(79, 17);
            this.lblInstructions.TabIndex = 4;
            this.lblInstructions.Text = "Instructions:";
            // 
            // rtxtInstructions
            // 
            this.rtxtInstructions.Location = new System.Drawing.Point(127, 114);
            this.rtxtInstructions.Name = "rtxtInstructions";
            this.rtxtInstructions.ReadOnly = true;
            this.rtxtInstructions.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtxtInstructions.Size = new System.Drawing.Size(340, 155);
            this.rtxtInstructions.TabIndex = 5;
            this.rtxtInstructions.Text = "";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(486, 200);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(104, 17);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "Time to prepare:";
            // 
            // lblTimeToPrepare
            // 
            this.lblTimeToPrepare.AutoSize = true;
            this.lblTimeToPrepare.Location = new System.Drawing.Point(596, 200);
            this.lblTimeToPrepare.Name = "lblTimeToPrepare";
            this.lblTimeToPrepare.Size = new System.Drawing.Size(33, 17);
            this.lblTimeToPrepare.TabIndex = 7;
            this.lblTimeToPrepare.Text = "time";
            // 
            // lblDifficult
            // 
            this.lblDifficult.AutoSize = true;
            this.lblDifficult.Location = new System.Drawing.Point(486, 228);
            this.lblDifficult.Name = "lblDifficult";
            this.lblDifficult.Size = new System.Drawing.Size(66, 17);
            this.lblDifficult.TabIndex = 8;
            this.lblDifficult.Text = "Difficulty:";
            // 
            // lblDifficultyValue
            // 
            this.lblDifficultyValue.AutoSize = true;
            this.lblDifficultyValue.Location = new System.Drawing.Point(596, 228);
            this.lblDifficultyValue.Name = "lblDifficultyValue";
            this.lblDifficultyValue.Size = new System.Drawing.Size(35, 17);
            this.lblDifficultyValue.TabIndex = 9;
            this.lblDifficultyValue.Text = "easy";
            // 
            // picPreview
            // 
            this.picPreview.Location = new System.Drawing.Point(489, 37);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(157, 148);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPreview.TabIndex = 10;
            this.picPreview.TabStop = false;
            // 
            // lblMealplans
            // 
            this.lblMealplans.AutoSize = true;
            this.lblMealplans.Location = new System.Drawing.Point(662, 17);
            this.lblMealplans.Name = "lblMealplans";
            this.lblMealplans.Size = new System.Drawing.Size(142, 17);
            this.lblMealplans.TabIndex = 11;
            this.lblMealplans.Text = "Suitable for Mealplans:";
            // 
            // lblAllergies
            // 
            this.lblAllergies.Location = new System.Drawing.Point(662, 136);
            this.lblAllergies.Name = "lblAllergies";
            this.lblAllergies.Size = new System.Drawing.Size(156, 41);
            this.lblAllergies.TabIndex = 12;
            this.lblAllergies.Text = "Not suitable for people with following allergies:";
            // 
            // lstMealplans
            // 
            this.lstMealplans.FormattingEnabled = true;
            this.lstMealplans.ItemHeight = 17;
            this.lstMealplans.Location = new System.Drawing.Point(665, 37);
            this.lstMealplans.Name = "lstMealplans";
            this.lstMealplans.Size = new System.Drawing.Size(153, 89);
            this.lstMealplans.TabIndex = 13;
            // 
            // lstAllergies
            // 
            this.lstAllergies.FormattingEnabled = true;
            this.lstAllergies.ItemHeight = 17;
            this.lstAllergies.Location = new System.Drawing.Point(665, 180);
            this.lstAllergies.Name = "lstAllergies";
            this.lstAllergies.Size = new System.Drawing.Size(153, 89);
            this.lstAllergies.TabIndex = 14;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(183)))), ((int)(((byte)(43)))));
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(765, 44);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(82, 32);
            this.btnBack.TabIndex = 55;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // gbxSearch
            // 
            this.gbxSearch.Controls.Add(this.radPreference);
            this.gbxSearch.Controls.Add(this.radAll);
            this.gbxSearch.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSearch.Location = new System.Drawing.Point(208, 3);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(401, 45);
            this.gbxSearch.TabIndex = 56;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Search Options:";
            // 
            // radAll
            // 
            this.radAll.AutoSize = true;
            this.radAll.Checked = true;
            this.radAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.radAll.Location = new System.Drawing.Point(25, 18);
            this.radAll.Name = "radAll";
            this.radAll.Size = new System.Drawing.Size(90, 21);
            this.radAll.TabIndex = 0;
            this.radAll.TabStop = true;
            this.radAll.Text = "Search All";
            this.radAll.UseVisualStyleBackColor = true;
            // 
            // radPreference
            // 
            this.radPreference.AutoSize = true;
            this.radPreference.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.radPreference.Location = new System.Drawing.Point(188, 21);
            this.radPreference.Name = "radPreference";
            this.radPreference.Size = new System.Drawing.Size(195, 21);
            this.radPreference.TabIndex = 1;
            this.radPreference.Text = "Search by own Preferences";
            this.radPreference.UseVisualStyleBackColor = true;
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(183)))), ((int)(((byte)(43)))));
            this.btnProducts.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.ForeColor = System.Drawing.Color.White;
            this.btnProducts.Location = new System.Drawing.Point(474, 248);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(185, 32);
            this.btnProducts.TabIndex = 52;
            this.btnProducts.Text = "View Products Required";
            this.btnProducts.UseVisualStyleBackColor = false;
            // 
            // frmBrowseRecipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(859, 443);
            this.Controls.Add(this.gbxSearch);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.tnNext);
            this.Controls.Add(this.pnlRecipe);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtRecipeName);
            this.Controls.Add(this.lblRecipeName);
            this.Controls.Add(this.pbLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBrowseRecipes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Browse Recipes";
            this.Load += new System.EventHandler(this.FrmBrowseRecipes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlRecipe.ResumeLayout(false);
            this.pnlRecipe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.TextBox txtRecipeName;
        private System.Windows.Forms.Label lblRecipeName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pnlRecipe;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button tnNext;
        private System.Windows.Forms.Label lblDifficultyValue;
        private System.Windows.Forms.Label lblDifficult;
        private System.Windows.Forms.Label lblTimeToPrepare;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.RichTextBox rtxtInstructions;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblRecipeNameValue;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.ListBox lstAllergies;
        private System.Windows.Forms.ListBox lstMealplans;
        private System.Windows.Forms.Label lblAllergies;
        private System.Windows.Forms.Label lblMealplans;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.RadioButton radPreference;
        private System.Windows.Forms.RadioButton radAll;
        private System.Windows.Forms.Button btnProducts;
    }
}