namespace MealPlannerDesktop
{
    partial class frmSignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSignIn));
            this.gbSign = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.gbSignUp = new System.Windows.Forms.GroupBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.gbSign.SuspendLayout();
            this.gbSignUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSign
            // 
            this.gbSign.Controls.Add(this.btnSubmit);
            this.gbSign.Controls.Add(this.txtPass);
            this.gbSign.Controls.Add(this.txtUser);
            this.gbSign.Controls.Add(this.lblPass);
            this.gbSign.Controls.Add(this.lblUser);
            this.gbSign.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSign.Location = new System.Drawing.Point(12, 112);
            this.gbSign.Name = "gbSign";
            this.gbSign.Size = new System.Drawing.Size(291, 252);
            this.gbSign.TabIndex = 1;
            this.gbSign.TabStop = false;
            this.gbSign.Text = "Sign In";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(183)))), ((int)(((byte)(43)))));
            this.btnSubmit.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(46, 177);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(197, 43);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Sign In";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(10, 126);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(275, 29);
            this.txtPass.TabIndex = 3;
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(9, 72);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(276, 29);
            this.txtUser.TabIndex = 2;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(6, 104);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(71, 19);
            this.lblPass.TabIndex = 1;
            this.lblPass.Text = "Password";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(6, 49);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(75, 19);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Username";
            // 
            // gbSignUp
            // 
            this.gbSignUp.Controls.Add(this.btnSignUp);
            this.gbSignUp.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSignUp.Location = new System.Drawing.Point(12, 370);
            this.gbSignUp.Name = "gbSignUp";
            this.gbSignUp.Size = new System.Drawing.Size(291, 84);
            this.gbSignUp.TabIndex = 2;
            this.gbSignUp.TabStop = false;
            this.gbSignUp.Text = "Don\'t Have An Account?";
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(183)))), ((int)(((byte)(43)))));
            this.btnSignUp.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(46, 28);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(197, 43);
            this.btnSignUp.TabIndex = 5;
            this.btnSignUp.Text = "Sign Up!";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.White;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.InitialImage = null;
            this.pbLogo.Location = new System.Drawing.Point(12, 3);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(291, 103);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 3;
            this.pbLogo.TabStop = false;
            // 
            // frmSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(315, 462);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.gbSignUp);
            this.Controls.Add(this.gbSign);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign In";
            this.Load += new System.EventHandler(this.FrmSignIn_Load);
            this.gbSign.ResumeLayout(false);
            this.gbSign.PerformLayout();
            this.gbSignUp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSign;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.GroupBox gbSignUp;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}

