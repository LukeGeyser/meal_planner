namespace MealPlannerDesktop
{
    partial class frmStoreInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStoreInformation));
            this.picStoreFront = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblStoreName = new System.Windows.Forms.Label();
            this.picRatingStars = new System.Windows.Forms.PictureBox();
            this.lblRatingText = new System.Windows.Forms.Label();
            this.lblOpen = new System.Windows.Forms.Label();
            this.lblLat = new System.Windows.Forms.Label();
            this.lblLong = new System.Windows.Forms.Label();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.lblLongitude = new System.Windows.Forms.Label();
            this.lblPriceRating = new System.Windows.Forms.Label();
            this.lblNear = new System.Windows.Forms.Label();
            this.lblDistance = new System.Windows.Forms.Label();
            this.lblPriceRatingValue = new System.Windows.Forms.Label();
            this.picPhone = new System.Windows.Forms.PictureBox();
            this.picEmail = new System.Windows.Forms.PictureBox();
            this.picInternet = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picStoreFront)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRatingStars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInternet)).BeginInit();
            this.SuspendLayout();
            // 
            // picStoreFront
            // 
            this.picStoreFront.Image = ((System.Drawing.Image)(resources.GetObject("picStoreFront.Image")));
            this.picStoreFront.Location = new System.Drawing.Point(0, -1);
            this.picStoreFront.Name = "picStoreFront";
            this.picStoreFront.Size = new System.Drawing.Size(494, 367);
            this.picStoreFront.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStoreFront.TabIndex = 0;
            this.picStoreFront.TabStop = false;
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.White;
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.InitialImage = null;
            this.pbLogo.Location = new System.Drawing.Point(0, 365);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(835, 87);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 7;
            this.pbLogo.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(183)))), ((int)(((byte)(43)))));
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(741, 408);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(82, 32);
            this.btnBack.TabIndex = 57;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // lblStoreName
            // 
            this.lblStoreName.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoreName.Location = new System.Drawing.Point(500, 9);
            this.lblStoreName.Name = "lblStoreName";
            this.lblStoreName.Size = new System.Drawing.Size(323, 23);
            this.lblStoreName.TabIndex = 58;
            this.lblStoreName.Text = "Woolworths - Boksburg";
            this.lblStoreName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picRatingStars
            // 
            this.picRatingStars.Image = ((System.Drawing.Image)(resources.GetObject("picRatingStars.Image")));
            this.picRatingStars.Location = new System.Drawing.Point(574, 35);
            this.picRatingStars.Name = "picRatingStars";
            this.picRatingStars.Size = new System.Drawing.Size(171, 42);
            this.picRatingStars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRatingStars.TabIndex = 59;
            this.picRatingStars.TabStop = false;
            // 
            // lblRatingText
            // 
            this.lblRatingText.AutoSize = true;
            this.lblRatingText.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRatingText.Location = new System.Drawing.Point(626, 80);
            this.lblRatingText.Name = "lblRatingText";
            this.lblRatingText.Size = new System.Drawing.Size(59, 15);
            this.lblRatingText.TabIndex = 60;
            this.lblRatingText.Text = "Rating: 4,3";
            // 
            // lblOpen
            // 
            this.lblOpen.AutoSize = true;
            this.lblOpen.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpen.ForeColor = System.Drawing.Color.Green;
            this.lblOpen.Location = new System.Drawing.Point(606, 104);
            this.lblOpen.Name = "lblOpen";
            this.lblOpen.Size = new System.Drawing.Size(97, 22);
            this.lblOpen.TabIndex = 61;
            this.lblOpen.Text = "Open Now";
            // 
            // lblLat
            // 
            this.lblLat.AutoSize = true;
            this.lblLat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLat.Location = new System.Drawing.Point(583, 144);
            this.lblLat.Name = "lblLat";
            this.lblLat.Size = new System.Drawing.Size(59, 17);
            this.lblLat.TabIndex = 62;
            this.lblLat.Text = "Latitude:";
            // 
            // lblLong
            // 
            this.lblLong.AutoSize = true;
            this.lblLong.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLong.Location = new System.Drawing.Point(668, 144);
            this.lblLong.Name = "lblLong";
            this.lblLong.Size = new System.Drawing.Size(69, 17);
            this.lblLong.TabIndex = 63;
            this.lblLong.Text = "Longitude:";
            // 
            // lblLatitude
            // 
            this.lblLatitude.AutoSize = true;
            this.lblLatitude.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLatitude.Location = new System.Drawing.Point(562, 171);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(80, 17);
            this.lblLatitude.TabIndex = 64;
            this.lblLatitude.Text = "-26.1818508";
            // 
            // lblLongitude
            // 
            this.lblLongitude.AutoSize = true;
            this.lblLongitude.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLongitude.Location = new System.Drawing.Point(668, 171);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(68, 17);
            this.lblLongitude.TabIndex = 65;
            this.lblLongitude.Text = "28.238615";
            // 
            // lblPriceRating
            // 
            this.lblPriceRating.AutoSize = true;
            this.lblPriceRating.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceRating.Location = new System.Drawing.Point(562, 208);
            this.lblPriceRating.Name = "lblPriceRating";
            this.lblPriceRating.Size = new System.Drawing.Size(88, 17);
            this.lblPriceRating.TabIndex = 66;
            this.lblPriceRating.Text = "Price Rating: ";
            // 
            // lblNear
            // 
            this.lblNear.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNear.Location = new System.Drawing.Point(500, 250);
            this.lblNear.Name = "lblNear";
            this.lblNear.Size = new System.Drawing.Size(335, 23);
            this.lblNear.TabIndex = 67;
            this.lblNear.Text = "Near Rietfontein Rd, Jansen Park, Boksburg";
            this.lblNear.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistance.Location = new System.Drawing.Point(573, 282);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(172, 20);
            this.lblDistance.TabIndex = 68;
            this.lblDistance.Text = "Around 9km from you";
            // 
            // lblPriceRatingValue
            // 
            this.lblPriceRatingValue.AutoSize = true;
            this.lblPriceRatingValue.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceRatingValue.ForeColor = System.Drawing.Color.Green;
            this.lblPriceRatingValue.Location = new System.Drawing.Point(668, 207);
            this.lblPriceRatingValue.Name = "lblPriceRatingValue";
            this.lblPriceRatingValue.Size = new System.Drawing.Size(111, 17);
            this.lblPriceRatingValue.TabIndex = 69;
            this.lblPriceRatingValue.Text = "1 (Inexpensive)";
            // 
            // picPhone
            // 
            this.picPhone.Image = ((System.Drawing.Image)(resources.GetObject("picPhone.Image")));
            this.picPhone.Location = new System.Drawing.Point(560, 316);
            this.picPhone.Name = "picPhone";
            this.picPhone.Size = new System.Drawing.Size(48, 50);
            this.picPhone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPhone.TabIndex = 70;
            this.picPhone.TabStop = false;
            this.picPhone.Click += new System.EventHandler(this.PicPhone_Click);
            // 
            // picEmail
            // 
            this.picEmail.Image = ((System.Drawing.Image)(resources.GetObject("picEmail.Image")));
            this.picEmail.Location = new System.Drawing.Point(629, 316);
            this.picEmail.Name = "picEmail";
            this.picEmail.Size = new System.Drawing.Size(48, 50);
            this.picEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEmail.TabIndex = 71;
            this.picEmail.TabStop = false;
            this.picEmail.Click += new System.EventHandler(this.PicEmail_Click);
            // 
            // picInternet
            // 
            this.picInternet.Image = ((System.Drawing.Image)(resources.GetObject("picInternet.Image")));
            this.picInternet.Location = new System.Drawing.Point(697, 316);
            this.picInternet.Name = "picInternet";
            this.picInternet.Size = new System.Drawing.Size(48, 50);
            this.picInternet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picInternet.TabIndex = 72;
            this.picInternet.TabStop = false;
            this.picInternet.Click += new System.EventHandler(this.PicInternet_Click);
            // 
            // frmStoreInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(835, 452);
            this.Controls.Add(this.picInternet);
            this.Controls.Add(this.picEmail);
            this.Controls.Add(this.picPhone);
            this.Controls.Add(this.lblPriceRatingValue);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.lblNear);
            this.Controls.Add(this.lblPriceRating);
            this.Controls.Add(this.lblLongitude);
            this.Controls.Add(this.lblLatitude);
            this.Controls.Add(this.lblLong);
            this.Controls.Add(this.lblLat);
            this.Controls.Add(this.lblOpen);
            this.Controls.Add(this.lblRatingText);
            this.Controls.Add(this.picRatingStars);
            this.Controls.Add(this.lblStoreName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.picStoreFront);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStoreInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store Information";
            this.Load += new System.EventHandler(this.FrmStoreInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picStoreFront)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRatingStars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInternet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picStoreFront;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblStoreName;
        private System.Windows.Forms.PictureBox picRatingStars;
        private System.Windows.Forms.Label lblRatingText;
        private System.Windows.Forms.Label lblOpen;
        private System.Windows.Forms.Label lblLat;
        private System.Windows.Forms.Label lblLong;
        private System.Windows.Forms.Label lblLatitude;
        private System.Windows.Forms.Label lblLongitude;
        private System.Windows.Forms.Label lblPriceRating;
        private System.Windows.Forms.Label lblNear;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label lblPriceRatingValue;
        private System.Windows.Forms.PictureBox picPhone;
        private System.Windows.Forms.PictureBox picEmail;
        private System.Windows.Forms.PictureBox picInternet;
    }
}