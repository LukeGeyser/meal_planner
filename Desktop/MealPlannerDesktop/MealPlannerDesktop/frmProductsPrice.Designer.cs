namespace MealPlannerDesktop
{
    partial class frmProductsPrice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductsPrice));
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblProd = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.RichTextBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.blValue = new System.Windows.Forms.Label();
            this.blDescribe = new System.Windows.Forms.Label();
            this.lblCat = new System.Windows.Forms.Label();
            this.picProductImage = new System.Windows.Forms.PictureBox();
            this.lstPrices = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.gbResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProductImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstPrices)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.White;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.InitialImage = null;
            this.pbLogo.Location = new System.Drawing.Point(12, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(833, 91);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 12;
            this.pbLogo.TabStop = false;
            // 
            // lblProd
            // 
            this.lblProd.AutoSize = true;
            this.lblProd.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProd.Location = new System.Drawing.Point(223, 124);
            this.lblProd.Name = "lblProd";
            this.lblProd.Size = new System.Drawing.Size(105, 28);
            this.lblProd.TabIndex = 13;
            this.lblProd.Text = "Product: ";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(183)))), ((int)(((byte)(43)))));
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(280, 181);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(114, 67);
            this.btnBack.TabIndex = 57;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(183)))), ((int)(((byte)(43)))));
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(510, 181);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(114, 67);
            this.btnSearch.TabIndex = 58;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtProdName
            // 
            this.txtProdName.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdName.Location = new System.Drawing.Point(354, 119);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(282, 39);
            this.txtProdName.TabIndex = 60;
            // 
            // gbResult
            // 
            this.gbResult.Controls.Add(this.lblProductName);
            this.gbResult.Controls.Add(this.lstPrices);
            this.gbResult.Controls.Add(this.txtValue);
            this.gbResult.Controls.Add(this.picProductImage);
            this.gbResult.Controls.Add(this.txtDescription);
            this.gbResult.Controls.Add(this.lblCat);
            this.gbResult.Controls.Add(this.txtCategory);
            this.gbResult.Controls.Add(this.blDescribe);
            this.gbResult.Controls.Add(this.blValue);
            this.gbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResult.Location = new System.Drawing.Point(13, 254);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(845, 276);
            this.gbResult.TabIndex = 61;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "Search Result";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(5, 40);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(171, 28);
            this.lblProductName.TabIndex = 78;
            this.lblProductName.Text = "{Product Name}";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(534, 174);
            this.txtValue.Name = "txtValue";
            this.txtValue.ReadOnly = true;
            this.txtValue.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtValue.Size = new System.Drawing.Size(305, 96);
            this.txtValue.TabIndex = 77;
            this.txtValue.Text = "";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(534, 64);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(305, 65);
            this.txtDescription.TabIndex = 76;
            this.txtDescription.Text = "";
            // 
            // txtCategory
            // 
            this.txtCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategory.Location = new System.Drawing.Point(222, 104);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.ReadOnly = true;
            this.txtCategory.Size = new System.Drawing.Size(187, 26);
            this.txtCategory.TabIndex = 75;
            // 
            // blValue
            // 
            this.blValue.AutoSize = true;
            this.blValue.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blValue.Location = new System.Drawing.Point(530, 150);
            this.blValue.Name = "blValue";
            this.blValue.Size = new System.Drawing.Size(136, 21);
            this.blValue.TabIndex = 74;
            this.blValue.Text = "Nutritional Value:";
            // 
            // blDescribe
            // 
            this.blDescribe.AutoSize = true;
            this.blDescribe.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blDescribe.Location = new System.Drawing.Point(530, 40);
            this.blDescribe.Name = "blDescribe";
            this.blDescribe.Size = new System.Drawing.Size(100, 21);
            this.blDescribe.TabIndex = 73;
            this.blDescribe.Text = "Description:";
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCat.Location = new System.Drawing.Point(3, 107);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(82, 21);
            this.lblCat.TabIndex = 72;
            this.lblCat.Text = "Category:";
            // 
            // picProductImage
            // 
            this.picProductImage.Location = new System.Drawing.Point(420, 40);
            this.picProductImage.Name = "picProductImage";
            this.picProductImage.Size = new System.Drawing.Size(81, 89);
            this.picProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProductImage.TabIndex = 71;
            this.picProductImage.TabStop = false;
            // 
            // lstPrices
            // 
            this.lstPrices.AllowUserToAddRows = false;
            this.lstPrices.AllowUserToDeleteRows = false;
            this.lstPrices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.lstPrices.BackgroundColor = System.Drawing.Color.White;
            this.lstPrices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstPrices.Location = new System.Drawing.Point(6, 150);
            this.lstPrices.Name = "lstPrices";
            this.lstPrices.ReadOnly = true;
            this.lstPrices.Size = new System.Drawing.Size(504, 120);
            this.lstPrices.TabIndex = 70;
            // 
            // frmProductsPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(865, 534);
            this.Controls.Add(this.gbResult);
            this.Controls.Add(this.txtProdName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblProd);
            this.Controls.Add(this.pbLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProductsPrice";
            this.Text = "Price of Products";
            this.Load += new System.EventHandler(this.frmProductsPrice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.gbResult.ResumeLayout(false);
            this.gbResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProductImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstPrices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblProd;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.DataGridView lstPrices;
        private System.Windows.Forms.RichTextBox txtValue;
        private System.Windows.Forms.PictureBox picProductImage;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label blDescribe;
        private System.Windows.Forms.Label blValue;
    }
}