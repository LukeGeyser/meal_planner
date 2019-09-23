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
            this.pnlPriceRelations = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.picProductImage = new System.Windows.Forms.PictureBox();
            this.lblCat = new System.Windows.Forms.Label();
            this.blDescribe = new System.Windows.Forms.Label();
            this.blValue = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.txtValue = new System.Windows.Forms.RichTextBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblPriceTitle = new System.Windows.Forms.Label();
            this.btnShopAvailability = new System.Windows.Forms.Button();
            this.lstPrices = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlProductInfo.SuspendLayout();
            this.pnlPriceRelations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProductImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstPrices)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.White;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.InitialImage = null;
            this.pbLogo.Location = new System.Drawing.Point(515, 12);
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
            this.btnBack.Location = new System.Drawing.Point(719, 18);
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
            this.pnlProductInfo.Location = new System.Drawing.Point(12, 12);
            this.pnlProductInfo.Name = "pnlProductInfo";
            this.pnlProductInfo.Size = new System.Drawing.Size(497, 377);
            this.pnlProductInfo.TabIndex = 57;
            // 
            // pnlPriceRelations
            // 
            this.pnlPriceRelations.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPriceRelations.Controls.Add(this.lstPrices);
            this.pnlPriceRelations.Controls.Add(this.btnShopAvailability);
            this.pnlPriceRelations.Controls.Add(this.lblPriceTitle);
            this.pnlPriceRelations.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPriceRelations.Location = new System.Drawing.Point(515, 163);
            this.pnlPriceRelations.Name = "pnlPriceRelations";
            this.pnlPriceRelations.Size = new System.Drawing.Size(295, 226);
            this.pnlPriceRelations.TabIndex = 58;
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
            // picProductImage
            // 
            this.picProductImage.Location = new System.Drawing.Point(344, 12);
            this.picProductImage.Name = "picProductImage";
            this.picProductImage.Size = new System.Drawing.Size(136, 126);
            this.picProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProductImage.TabIndex = 2;
            this.picProductImage.TabStop = false;
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
            // blDescribe
            // 
            this.blDescribe.AutoSize = true;
            this.blDescribe.Location = new System.Drawing.Point(15, 152);
            this.blDescribe.Name = "blDescribe";
            this.blDescribe.Size = new System.Drawing.Size(78, 17);
            this.blDescribe.TabIndex = 4;
            this.blDescribe.Text = "Description:";
            // 
            // blValue
            // 
            this.blValue.AutoSize = true;
            this.blValue.Location = new System.Drawing.Point(15, 245);
            this.blValue.Name = "blValue";
            this.blValue.Size = new System.Drawing.Size(109, 17);
            this.blValue.TabIndex = 5;
            this.blValue.Text = "Nutritional Value:";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(133, 113);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.ReadOnly = true;
            this.txtCategory.Size = new System.Drawing.Size(187, 25);
            this.txtCategory.TabIndex = 6;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(133, 149);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(347, 87);
            this.txtDescription.TabIndex = 7;
            this.txtDescription.Text = "";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(133, 242);
            this.txtValue.Name = "txtValue";
            this.txtValue.ReadOnly = true;
            this.txtValue.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtValue.Size = new System.Drawing.Size(347, 86);
            this.txtValue.TabIndex = 8;
            this.txtValue.Text = "";
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
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(822, 404);
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
            this.pnlPriceRelations.ResumeLayout(false);
            this.pnlPriceRelations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProductImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstPrices)).EndInit();
            this.ResumeLayout(false);

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
    }
}