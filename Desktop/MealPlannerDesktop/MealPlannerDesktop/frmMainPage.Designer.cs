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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainPage));
            this.menuChoices = new System.Windows.Forms.MenuStrip();
            this.myProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseRecipesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priceCheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CalorietoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.picSlideShow = new System.Windows.Forms.PictureBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblQuote = new System.Windows.Forms.Label();
            this.lblQuoteTitle = new System.Windows.Forms.Label();
            this.tmrSlideshow = new System.Windows.Forms.Timer(this.components);
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
            this.toolStripMenuItem2,
            this.toolStripMenuItem1,
            this.priceCheckToolStripMenuItem,
            this.CalorietoolStripMenuItem,
            this.otherToolStripMenuItem,
            this.signOutToolStripMenuItem});
            this.menuChoices.Location = new System.Drawing.Point(0, 0);
            this.menuChoices.Name = "menuChoices";
            this.menuChoices.Size = new System.Drawing.Size(866, 32);
            this.menuChoices.TabIndex = 0;
            this.menuChoices.Text = "menuStrip1";
            // 
            // myProfileToolStripMenuItem
            // 
            this.myProfileToolStripMenuItem.ForeColor = System.Drawing.Color.Green;
            this.myProfileToolStripMenuItem.Name = "myProfileToolStripMenuItem";
            this.myProfileToolStripMenuItem.Size = new System.Drawing.Size(114, 28);
            this.myProfileToolStripMenuItem.Text = "My Profile";
            // 
            // browseRecipesToolStripMenuItem
            // 
            this.browseRecipesToolStripMenuItem.ForeColor = System.Drawing.Color.Green;
            this.browseRecipesToolStripMenuItem.Name = "browseRecipesToolStripMenuItem";
            this.browseRecipesToolStripMenuItem.Size = new System.Drawing.Size(156, 28);
            this.browseRecipesToolStripMenuItem.Text = "Browse Recipes";
            // 
            // priceCheckToolStripMenuItem
            // 
            this.priceCheckToolStripMenuItem.ForeColor = System.Drawing.Color.Green;
            this.priceCheckToolStripMenuItem.Name = "priceCheckToolStripMenuItem";
            this.priceCheckToolStripMenuItem.Size = new System.Drawing.Size(127, 28);
            this.priceCheckToolStripMenuItem.Text = "Price Check";
            // 
            // CalorietoolStripMenuItem
            // 
            this.CalorietoolStripMenuItem.Name = "CalorietoolStripMenuItem";
            this.CalorietoolStripMenuItem.Size = new System.Drawing.Size(184, 28);
            this.CalorietoolStripMenuItem.Text = "Calorie Calculator";
            // 
            // otherToolStripMenuItem
            // 
            this.otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            this.otherToolStripMenuItem.Size = new System.Drawing.Size(63, 28);
            this.otherToolStripMenuItem.Text = "BMI";
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(101, 28);
            this.signOutToolStripMenuItem.Text = "Sign Out";
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
            this.picSlideShow.Location = new System.Drawing.Point(318, 32);
            this.picSlideShow.Name = "picSlideShow";
            this.picSlideShow.Size = new System.Drawing.Size(548, 353);
            this.picSlideShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSlideShow.TabIndex = 6;
            this.picSlideShow.TabStop = false;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.Green;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(156, 28);
            this.toolStripMenuItem1.Text = "Browse Recipes";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.Green;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(127, 28);
            this.toolStripMenuItem2.Text = "Price Check";
            // 
            // lblQuote
            // 
            this.lblQuote.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuote.Location = new System.Drawing.Point(63, 129);
            this.lblQuote.Name = "lblQuote";
            this.lblQuote.Size = new System.Drawing.Size(194, 181);
            this.lblQuote.TabIndex = 7;
            this.lblQuote.Text = "“By choosing healthy over skinny, you are choosing self-love over self-judgement." +
    "”  —Steve Maraboli";
            // 
            // lblQuoteTitle
            // 
            this.lblQuoteTitle.AutoSize = true;
            this.lblQuoteTitle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuoteTitle.Location = new System.Drawing.Point(41, 87);
            this.lblQuoteTitle.Name = "lblQuoteTitle";
            this.lblQuoteTitle.Size = new System.Drawing.Size(216, 31);
            this.lblQuoteTitle.TabIndex = 8;
            this.lblQuoteTitle.Text = "Quote of the day:";
            // 
            // tmrSlideshow
            // 
            this.tmrSlideshow.Interval = 2000;
            this.tmrSlideshow.Tick += new System.EventHandler(this.TmrSlideshow_Tick);
            // 
            // frmMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(183)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(866, 493);
            this.Controls.Add(this.lblQuoteTitle);
            this.Controls.Add(this.lblQuote);
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
        private System.Windows.Forms.ToolStripMenuItem CalorietoolStripMenuItem;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.PictureBox picSlideShow;
        private System.Windows.Forms.ToolStripMenuItem otherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label lblQuote;
        private System.Windows.Forms.Label lblQuoteTitle;
        private System.Windows.Forms.Timer tmrSlideshow;
    }
}