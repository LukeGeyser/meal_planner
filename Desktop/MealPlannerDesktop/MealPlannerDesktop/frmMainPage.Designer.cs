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
            this.updateMyDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackMyProgressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseRecipesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PricetoolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.browseShopsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CalorietoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.picSlideShow = new System.Windows.Forms.PictureBox();
            this.lblQuote = new System.Windows.Forms.Label();
            this.lblQuoteTitle = new System.Windows.Forms.Label();
            this.tmrSlideshow = new System.Windows.Forms.Timer(this.components);
            this.lblWelcome = new System.Windows.Forms.Label();
            this.menuChoices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSlideShow)).BeginInit();
            this.SuspendLayout();
            // 
            // menuChoices
            // 
            this.menuChoices.BackColor = System.Drawing.Color.White;
            this.menuChoices.Font = new System.Drawing.Font("Times New Roman", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuChoices.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myProfileToolStripMenuItem,
            this.browseRecipesToolStripMenuItem,
            this.PricetoolStripMenuItem2,
            this.browseShopsMenuItem,
            this.CalorietoolStripMenuItem1,
            this.logoutToolStripMenuItem});
            this.menuChoices.Location = new System.Drawing.Point(0, 0);
            this.menuChoices.Name = "menuChoices";
            this.menuChoices.Size = new System.Drawing.Size(867, 31);
            this.menuChoices.TabIndex = 0;
            this.menuChoices.Text = "menuStrip1";
            // 
            // myProfileToolStripMenuItem
            // 
            this.myProfileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateMyDetailsToolStripMenuItem,
            this.trackMyProgressToolStripMenuItem});
            this.myProfileToolStripMenuItem.ForeColor = System.Drawing.Color.Green;
            this.myProfileToolStripMenuItem.Name = "myProfileToolStripMenuItem";
            this.myProfileToolStripMenuItem.Size = new System.Drawing.Size(111, 27);
            this.myProfileToolStripMenuItem.Text = "My Profile";
            // 
            // updateMyDetailsToolStripMenuItem
            // 
            this.updateMyDetailsToolStripMenuItem.ForeColor = System.Drawing.Color.Green;
            this.updateMyDetailsToolStripMenuItem.Name = "updateMyDetailsToolStripMenuItem";
            this.updateMyDetailsToolStripMenuItem.Size = new System.Drawing.Size(237, 28);
            this.updateMyDetailsToolStripMenuItem.Text = "Update My Details";
            this.updateMyDetailsToolStripMenuItem.Click += new System.EventHandler(this.UpdateMyDetailsToolStripMenuItem_Click);
            // 
            // trackMyProgressToolStripMenuItem
            // 
            this.trackMyProgressToolStripMenuItem.ForeColor = System.Drawing.Color.Green;
            this.trackMyProgressToolStripMenuItem.Name = "trackMyProgressToolStripMenuItem";
            this.trackMyProgressToolStripMenuItem.Size = new System.Drawing.Size(237, 28);
            this.trackMyProgressToolStripMenuItem.Text = "Track My Progress";
            this.trackMyProgressToolStripMenuItem.Click += new System.EventHandler(this.trackMyProgressToolStripMenuItem_Click);
            // 
            // browseRecipesToolStripMenuItem
            // 
            this.browseRecipesToolStripMenuItem.ForeColor = System.Drawing.Color.Green;
            this.browseRecipesToolStripMenuItem.Name = "browseRecipesToolStripMenuItem";
            this.browseRecipesToolStripMenuItem.Size = new System.Drawing.Size(153, 27);
            this.browseRecipesToolStripMenuItem.Text = "Browse Recipes";
            this.browseRecipesToolStripMenuItem.Click += new System.EventHandler(this.BrowseRecipesToolStripMenuItem_Click);
            // 
            // PricetoolStripMenuItem2
            // 
            this.PricetoolStripMenuItem2.ForeColor = System.Drawing.Color.Green;
            this.PricetoolStripMenuItem2.Name = "PricetoolStripMenuItem2";
            this.PricetoolStripMenuItem2.Size = new System.Drawing.Size(123, 27);
            this.PricetoolStripMenuItem2.Text = "Price Check";
            // 
            // browseShopsMenuItem
            // 
            this.browseShopsMenuItem.ForeColor = System.Drawing.Color.Green;
            this.browseShopsMenuItem.Name = "browseShopsMenuItem";
            this.browseShopsMenuItem.Size = new System.Drawing.Size(119, 27);
            this.browseShopsMenuItem.Text = "Find Stores";
            this.browseShopsMenuItem.Click += new System.EventHandler(this.BrowseShopsMenuItem_Click);
            // 
            // CalorietoolStripMenuItem1
            // 
            this.CalorietoolStripMenuItem1.ForeColor = System.Drawing.Color.Green;
            this.CalorietoolStripMenuItem1.Name = "CalorietoolStripMenuItem1";
            this.CalorietoolStripMenuItem1.Size = new System.Drawing.Size(178, 27);
            this.CalorietoolStripMenuItem1.Text = "Calorie Calculator";
            this.CalorietoolStripMenuItem1.Click += new System.EventHandler(this.CalorietoolStripMenuItem1_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.ForeColor = System.Drawing.Color.Green;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(96, 27);
            this.logoutToolStripMenuItem.Text = "Sign Out";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
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
            this.pbLogo.Size = new System.Drawing.Size(867, 109);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 5;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
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
            // lblQuote
            // 
            this.lblQuote.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuote.Location = new System.Drawing.Point(62, 176);
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
            this.lblQuoteTitle.Location = new System.Drawing.Point(40, 134);
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
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(23, 78);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(181, 22);
            this.lblWelcome.TabIndex = 9;
            this.lblWelcome.Text = "Welcome {Username}";
            // 
            // frmMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(183)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(867, 493);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblQuoteTitle);
            this.Controls.Add(this.lblQuote);
            this.Controls.Add(this.picSlideShow);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.menuChoices);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuChoices;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eat Right, Pay Light";
            this.Load += new System.EventHandler(this.FrmMainPage_Load);
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
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.PictureBox picSlideShow;
        private System.Windows.Forms.ToolStripMenuItem PricetoolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem CalorietoolStripMenuItem1;
        private System.Windows.Forms.Label lblQuote;
        private System.Windows.Forms.Label lblQuoteTitle;
        private System.Windows.Forms.Timer tmrSlideshow;
        private System.Windows.Forms.ToolStripMenuItem updateMyDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trackMyProgressToolStripMenuItem;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.ToolStripMenuItem browseShopsMenuItem;
    }
}