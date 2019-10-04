namespace MealPlannerDesktop
{
    partial class frmProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducts));
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlProductInfo = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.RichTextBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.blValue = new System.Windows.Forms.Label();
            this.blDescribe = new System.Windows.Forms.Label();
            this.lblCat = new System.Windows.Forms.Label();
            this.picProductImage = new System.Windows.Forms.PictureBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlPriceRelations = new System.Windows.Forms.Panel();
            this.lstPrices = new System.Windows.Forms.DataGridView();
            this.btnShopAvailability = new System.Windows.Forms.Button();
            this.lblPriceTitle = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.cbxRecipeFilter = new System.Windows.Forms.ComboBox();
            this.lblProductsFound = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlProductInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProductImage)).BeginInit();
            this.pnlPriceRelations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstPrices)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.White;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.InitialImage = null;
            this.pbLogo.Location = new System.Drawing.Point(515, 54);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(295, 145);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 11;
            this.pbLogo.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(183)))), ((int)(((byte)(43)))));
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(728, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(82, 32);
            this.btnBack.TabIndex = 56;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // pnlProductInfo
            // 
            this.pnlProductInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlProductInfo.Controls.Add(this.btnNext);
            this.pnlProductInfo.Controls.Add(this.btnPrevious);
            this.pnlProductInfo.Controls.Add(this.txtValue);
            this.pnlProductInfo.Controls.Add(this.txtDescription);
            this.pnlProductInfo.Controls.Add(this.txtCategory);
            this.pnlProductInfo.Controls.Add(this.blValue);
            this.pnlProductInfo.Controls.Add(this.blDescribe);
            this.pnlProductInfo.Controls.Add(this.lblCat);
            this.pnlProductInfo.Controls.Add(this.picProductImage);
            this.pnlProductInfo.Controls.Add(this.lblProductName);
            this.pnlProductInfo.Controls.Add(this.lblTitle);
            this.pnlProductInfo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlProductInfo.Location = new System.Drawing.Point(12, 54);
            this.pnlProductInfo.Name = "pnlProductInfo";
            this.pnlProductInfo.Size = new System.Drawing.Size(497, 377);
            this.pnlProductInfo.TabIndex = 57;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(183)))), ((int)(((byte)(43)))));
            this.btnNext.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(312, 339);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(168, 31);
            this.btnNext.TabIndex = 55;
            this.btnNext.Text = "Next Product >";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(183)))), ((int)(((byte)(43)))));
            this.btnPrevious.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Location = new System.Drawing.Point(13, 339);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(168, 31);
            this.btnPrevious.TabIndex = 54;
            this.btnPrevious.Text = "< Previous Product";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(133, 209);
            this.txtValue.Name = "txtValue";
            this.txtValue.ReadOnly = true;
            this.txtValue.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtValue.Size = new System.Drawing.Size(347, 119);
            this.txtValue.TabIndex = 8;
            this.txtValue.Text = "";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(133, 149);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(347, 54);
            this.txtDescription.TabIndex = 7;
            this.txtDescription.Text = "";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(133, 113);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.ReadOnly = true;
            this.txtCategory.Size = new System.Drawing.Size(187, 25);
            this.txtCategory.TabIndex = 6;
            // 
            // blValue
            // 
            this.blValue.AutoSize = true;
            this.blValue.Location = new System.Drawing.Point(15, 212);
            this.blValue.Name = "blValue";
            this.blValue.Size = new System.Drawing.Size(109, 17);
            this.blValue.TabIndex = 5;
            this.blValue.Text = "Nutritional Value:";
            // 
            // blDescribe
            // 
            this.blDescribe.AutoSize = true;
            this.blDescribe.Location = new System.Drawing.Point(15, 152);
            this.blDescribe.Name = "blDescribe";
            this.blDescribe.Size = new System.Drawing.Size(78, 17);
            this.blDescribe.TabIndex = 4;
            this.blDescribe.Text = "Description:";
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Location = new System.Drawing.Point(15, 116);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(65, 17);
            this.lblCat.TabIndex = 3;
            this.lblCat.Text = "Category:";
            // 
            // picProductImage
            // 
            this.picProductImage.Location = new System.Drawing.Point(344, 12);
            this.picProductImage.Name = "picProductImage";
            this.picProductImage.Size = new System.Drawing.Size(136, 126);
            this.picProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProductImage.TabIndex = 2;
            this.picProductImage.TabStop = false;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(10, 44);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(171, 28);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "{Product Name}";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(144, 17);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Product Information:";
            // 
            // pnlPriceRelations
            // 
            this.pnlPriceRelations.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPriceRelations.Controls.Add(this.lstPrices);
            this.pnlPriceRelations.Controls.Add(this.btnShopAvailability);
            this.pnlPriceRelations.Controls.Add(this.lblPriceTitle);
            this.pnlPriceRelations.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPriceRelations.Location = new System.Drawing.Point(515, 205);
            this.pnlPriceRelations.Name = "pnlPriceRelations";
            this.pnlPriceRelations.Size = new System.Drawing.Size(295, 226);
            this.pnlPriceRelations.TabIndex = 58;
            // 
            // lstPrices
            // 
            this.lstPrices.AllowUserToAddRows = false;
            this.lstPrices.AllowUserToDeleteRows = false;
            this.lstPrices.BackgroundColor = System.Drawing.Color.White;
            this.lstPrices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstPrices.Location = new System.Drawing.Point(18, 45);
            this.lstPrices.Name = "lstPrices";
            this.lstPrices.ReadOnly = true;
            this.lstPrices.Size = new System.Drawing.Size(254, 127);
            this.lstPrices.TabIndex = 58;
            // 
            // btnShopAvailability
            // 
            this.btnShopAvailability.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(183)))), ((int)(((byte)(43)))));
            this.btnShopAvailability.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShopAvailability.ForeColor = System.Drawing.Color.White;
            this.btnShopAvailability.Location = new System.Drawing.Point(18, 178);
            this.btnShopAvailability.Name = "btnShopAvailability";
            this.btnShopAvailability.Size = new System.Drawing.Size(254, 32);
            this.btnShopAvailability.TabIndex = 57;
            this.btnShopAvailability.Text = "View Stores in your Area";
            this.btnShopAvailability.UseVisualStyleBackColor = false;
            this.btnShopAvailability.Click += new System.EventHandler(this.BtnShopAvailability_Click);
            // 
            // lblPriceTitle
            // 
            this.lblPriceTitle.AutoSize = true;
            this.lblPriceTitle.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceTitle.Location = new System.Drawing.Point(15, 12);
            this.lblPriceTitle.Name = "lblPriceTitle";
            this.lblPriceTitle.Size = new System.Drawing.Size(130, 17);
            this.lblPriceTitle.TabIndex = 1;
            this.lblPriceTitle.Text = "Price Comparison:";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(8, 19);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(89, 19);
            this.lblSearch.TabIndex = 59;
            this.lblSearch.Text = "Products of:";
            // 
            // cbxRecipeFilter
            // 
            this.cbxRecipeFilter.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxRecipeFilter.FormattingEnabled = true;
            this.cbxRecipeFilter.Location = new System.Drawing.Point(103, 18);
            this.cbxRecipeFilter.Name = "cbxRecipeFilter";
            this.cbxRecipeFilter.Size = new System.Drawing.Size(406, 25);
            this.cbxRecipeFilter.TabIndex = 60;
            this.cbxRecipeFilter.Text = "All Recipes";
            this.cbxRecipeFilter.SelectedIndexChanged += new System.EventHandler(this.CbxRecipeFilter_SelectedIndexChanged);
            // 
            // lblProductsFound
            // 
            this.lblProductsFound.AutoSize = true;
            this.lblProductsFound.Location = new System.Drawing.Point(512, 23);
            this.lblProductsFound.Name = "lblProductsFound";
            this.lblProductsFound.Size = new System.Drawing.Size(99, 13);
            this.lblProductsFound.TabIndex = 61;
            this.lblProductsFound.Text = "{#} products found.";
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(822, 443);
            this.Controls.Add(this.lblProductsFound);
            this.Controls.Add(this.cbxRecipeFilter);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.pnlPriceRelations);
            this.Controls.Add(this.pnlProductInfo);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pbLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.Load += new System.EventHandler(this.FrmProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlProductInfo.ResumeLayout(false);
            this.pnlProductInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProductImage)).EndInit();
            this.pnlPriceRelations.ResumeLayout(false);
            this.pnlPriceRelations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstPrices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlProductInfo;
        private System.Windows.Forms.PictureBox picProductImage;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlPriceRelations;
        private System.Windows.Forms.Label blValue;
        private System.Windows.Forms.Label blDescribe;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.RichTextBox txtValue;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label lblPriceTitle;
        private System.Windows.Forms.Button btnShopAvailability;
        private System.Windows.Forms.DataGridView lstPrices;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox cbxRecipeFilter;
        private System.Windows.Forms.Label lblProductsFound;
    }
}