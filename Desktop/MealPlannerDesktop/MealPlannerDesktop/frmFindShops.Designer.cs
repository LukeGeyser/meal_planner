namespace MealPlannerDesktop
{
    partial class frmFindShops
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFindShops));
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.cbxStoreName = new System.Windows.Forms.ComboBox();
            this.lblSelect = new System.Windows.Forms.Label();
            this.txtNearYou = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pbStoreLogo = new System.Windows.Forms.PictureBox();
            this.dgvStoresDisplay = new System.Windows.Forms.DataGridView();
            this.btnMore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStoreLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoresDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.White;
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.InitialImage = null;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(777, 84);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 6;
            this.pbLogo.TabStop = false;
            // 
            // cbxStoreName
            // 
            this.cbxStoreName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStoreName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxStoreName.FormattingEnabled = true;
            this.cbxStoreName.Items.AddRange(new object[] {
            "Woolworths",
            "Pick n Pay",
            "Spar",
            "Checkers"});
            this.cbxStoreName.Location = new System.Drawing.Point(222, 104);
            this.cbxStoreName.Name = "cbxStoreName";
            this.cbxStoreName.Size = new System.Drawing.Size(503, 27);
            this.cbxStoreName.TabIndex = 7;
            this.cbxStoreName.SelectedIndexChanged += new System.EventHandler(this.CbxStoreName_SelectedIndexChanged);
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect.Location = new System.Drawing.Point(45, 106);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(122, 22);
            this.lblSelect.TabIndex = 8;
            this.lblSelect.Text = "Select a Store:";
            // 
            // txtNearYou
            // 
            this.txtNearYou.AutoSize = true;
            this.txtNearYou.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNearYou.Location = new System.Drawing.Point(49, 152);
            this.txtNearYou.Name = "txtNearYou";
            this.txtNearYou.Size = new System.Drawing.Size(131, 19);
            this.txtNearYou.TabIndex = 9;
            this.txtNearYou.Text = "Please select a store";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(183)))), ((int)(((byte)(43)))));
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(643, 382);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(82, 32);
            this.btnBack.TabIndex = 56;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // pbStoreLogo
            // 
            this.pbStoreLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbStoreLogo.Image")));
            this.pbStoreLogo.Location = new System.Drawing.Point(39, 189);
            this.pbStoreLogo.Name = "pbStoreLogo";
            this.pbStoreLogo.Size = new System.Drawing.Size(177, 165);
            this.pbStoreLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStoreLogo.TabIndex = 58;
            this.pbStoreLogo.TabStop = false;
            // 
            // dgvStoresDisplay
            // 
            this.dgvStoresDisplay.AllowUserToAddRows = false;
            this.dgvStoresDisplay.AllowUserToDeleteRows = false;
            this.dgvStoresDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvStoresDisplay.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvStoresDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStoresDisplay.Location = new System.Drawing.Point(222, 189);
            this.dgvStoresDisplay.Name = "dgvStoresDisplay";
            this.dgvStoresDisplay.Size = new System.Drawing.Size(503, 165);
            this.dgvStoresDisplay.TabIndex = 59;
            this.dgvStoresDisplay.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvStoresDisplay_CellEnter);
            // 
            // btnMore
            // 
            this.btnMore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(183)))), ((int)(((byte)(43)))));
            this.btnMore.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMore.ForeColor = System.Drawing.Color.White;
            this.btnMore.Location = new System.Drawing.Point(467, 382);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(170, 32);
            this.btnMore.TabIndex = 60;
            this.btnMore.Text = "More Information";
            this.btnMore.UseVisualStyleBackColor = false;
            this.btnMore.Click += new System.EventHandler(this.BtnMore_Click);
            // 
            // frmFindShops
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(777, 426);
            this.Controls.Add(this.btnMore);
            this.Controls.Add(this.dgvStoresDisplay);
            this.Controls.Add(this.pbStoreLogo);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtNearYou);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.cbxStoreName);
            this.Controls.Add(this.pbLogo);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFindShops";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find Nearby Stores";
            this.Load += new System.EventHandler(this.FrmFindShops_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStoreLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoresDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.ComboBox cbxStoreName;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Label txtNearYou;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pbStoreLogo;
        private System.Windows.Forms.DataGridView dgvStoresDisplay;
        private System.Windows.Forms.Button btnMore;
    }
}