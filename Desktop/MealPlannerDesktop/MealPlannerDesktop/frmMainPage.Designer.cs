namespace MealPlannerDesktop
{
    partial class frmMainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainPage));
            this.menuChoices = new System.Windows.Forms.MenuStrip();
            this.myProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseRecipesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priceCheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.picSlideShow = new System.Windows.Forms.PictureBox();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuChoices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSlideShow)).BeginInit();
            this.SuspendLayout();
            // 
            // menuChoices
            // 
            this.menuChoices.BackColor = System.Drawing.Color.White;
            this.menuChoices.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuChoices.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myProfileToolStripMenuItem,
            this.browseRecipesToolStripMenuItem,
            this.priceCheckToolStripMenuItem,
            this.toolStripMenuItem1,
            this.signOutToolStripMenuItem});
            this.menuChoices.Location = new System.Drawing.Point(0, 0);
            this.menuChoices.Name = "menuChoices";
            this.menuChoices.Size = new System.Drawing.Size(866, 32);
            this.menuChoices.TabIndex = 0;
            this.menuChoices.Text = "menuStrip1";
            // 
            // myProfileToolStripMenuItem
            // 
            this.myProfileToolStripMenuItem.Name = "myProfileToolStripMenuItem";
            this.myProfileToolStripMenuItem.Size = new System.Drawing.Size(114, 28);
            this.myProfileToolStripMenuItem.Text = "My Profile";
            // 
            // browseRecipesToolStripMenuItem
            // 
            this.browseRecipesToolStripMenuItem.Name = "browseRecipesToolStripMenuItem";
            this.browseRecipesToolStripMenuItem.Size = new System.Drawing.Size(156, 28);
            this.browseRecipesToolStripMenuItem.Text = "Browse Recipes";
            // 
            // priceCheckToolStripMenuItem
            // 
            this.priceCheckToolStripMenuItem.Name = "priceCheckToolStripMenuItem";
            this.priceCheckToolStripMenuItem.Size = new System.Drawing.Size(127, 28);
            this.priceCheckToolStripMenuItem.Text = "Price Check";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(55, 28);
            this.toolStripMenuItem1.Text = "???";
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.White;
            this.pbLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.InitialImage = null;
            this.pbLogo.Location = new System.Drawing.Point(0, 384);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(866, 109);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 5;
            this.pbLogo.TabStop = false;
            // 
            // picSlideShow
            // 
            this.picSlideShow.Image = ((System.Drawing.Image)(resources.GetObject("picSlideShow.Image")));
            this.picSlideShow.Location = new System.Drawing.Point(284, 35);
            this.picSlideShow.Name = "picSlideShow";
            this.picSlideShow.Size = new System.Drawing.Size(582, 343);
            this.picSlideShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSlideShow.TabIndex = 6;
            this.picSlideShow.TabStop = false;
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(101, 28);
            this.signOutToolStripMenuItem.Text = "Sign Out";
            // 
            // frmMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(199)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(866, 493);
            this.Controls.Add(this.picSlideShow);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.menuChoices);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuChoices;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMainPage";
            this.Text = "Eat Right, Pay Light";
            this.menuChoices.ResumeLayout(false);
            this.menuChoices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSlideShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuChoices;
        private System.Windows.Forms.ToolStripMenuItem myProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browseRecipesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem priceCheckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.PictureBox picSlideShow;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
    }
}