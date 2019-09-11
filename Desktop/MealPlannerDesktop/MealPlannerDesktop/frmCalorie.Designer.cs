namespace MealPlannerDesktop
{
    partial class frmCalorie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalorie));
            this.lblCal = new System.Windows.Forms.Label();
            this.lblCalMeal = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtCal = new System.Windows.Forms.TextBox();
            this.txtCalMeal = new System.Windows.Forms.TextBox();
            this.lblMeal = new System.Windows.Forms.Label();
            this.nudMeal = new System.Windows.Forms.NumericUpDown();
            this.btnBack = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudMeal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCal
            // 
            this.lblCal.AutoSize = true;
            this.lblCal.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCal.Location = new System.Drawing.Point(22, 143);
            this.lblCal.Name = "lblCal";
            this.lblCal.Size = new System.Drawing.Size(156, 21);
            this.lblCal.TabIndex = 0;
            this.lblCal.Text = "Daily calorie need:";
            // 
            // lblCalMeal
            // 
            this.lblCalMeal.AutoSize = true;
            this.lblCalMeal.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalMeal.Location = new System.Drawing.Point(22, 315);
            this.lblCalMeal.Name = "lblCalMeal";
            this.lblCalMeal.Size = new System.Drawing.Size(152, 21);
            this.lblCalMeal.TabIndex = 1;
            this.lblCalMeal.Text = "Calories per meal:";
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(183)))), ((int)(((byte)(43)))));
            this.btnCalc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.ForeColor = System.Drawing.Color.White;
            this.btnCalc.Location = new System.Drawing.Point(126, 249);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(137, 45);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtCal
            // 
            this.txtCal.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCal.Location = new System.Drawing.Point(274, 140);
            this.txtCal.Name = "txtCal";
            this.txtCal.Size = new System.Drawing.Size(71, 29);
            this.txtCal.TabIndex = 3;
            // 
            // txtCalMeal
            // 
            this.txtCalMeal.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalMeal.Location = new System.Drawing.Point(274, 312);
            this.txtCalMeal.Name = "txtCalMeal";
            this.txtCalMeal.Size = new System.Drawing.Size(71, 29);
            this.txtCalMeal.TabIndex = 4;
            // 
            // lblMeal
            // 
            this.lblMeal.AutoSize = true;
            this.lblMeal.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeal.Location = new System.Drawing.Point(22, 200);
            this.lblMeal.Name = "lblMeal";
            this.lblMeal.Size = new System.Drawing.Size(211, 21);
            this.lblMeal.TabIndex = 5;
            this.lblMeal.Text = "How many meals per day:";
            // 
            // nudMeal
            // 
            this.nudMeal.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMeal.Location = new System.Drawing.Point(274, 198);
            this.nudMeal.Name = "nudMeal";
            this.nudMeal.Size = new System.Drawing.Size(71, 29);
            this.nudMeal.TabIndex = 6;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(183)))), ((int)(((byte)(43)))));
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(126, 359);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(137, 45);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.White;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.InitialImage = null;
            this.pbLogo.Location = new System.Drawing.Point(43, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(291, 103);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 8;
            this.pbLogo.TabStop = false;
            // 
            // frmCalorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(378, 416);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.nudMeal);
            this.Controls.Add(this.lblMeal);
            this.Controls.Add(this.txtCalMeal);
            this.Controls.Add(this.txtCal);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblCalMeal);
            this.Controls.Add(this.lblCal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCalorie";
            this.Text = "Calorie Calculator";
            this.Load += new System.EventHandler(this.frmCalorie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMeal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCal;
        private System.Windows.Forms.Label lblCalMeal;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtCal;
        private System.Windows.Forms.TextBox txtCalMeal;
        private System.Windows.Forms.Label lblMeal;
        private System.Windows.Forms.NumericUpDown nudMeal;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}