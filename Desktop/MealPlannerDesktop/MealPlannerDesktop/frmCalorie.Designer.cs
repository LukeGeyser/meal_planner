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
            this.btnBack = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.tabCalculators = new System.Windows.Forms.TabControl();
            this.tabCalorie = new System.Windows.Forms.TabPage();
            this.tabBMI = new System.Windows.Forms.TabPage();
            this.txtCalMeal = new System.Windows.Forms.TextBox();
            this.lblMeal = new System.Windows.Forms.Label();
            this.txtCal = new System.Windows.Forms.TextBox();
            this.nudMeal = new System.Windows.Forms.NumericUpDown();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblCalMeal = new System.Windows.Forms.Label();
            this.lblCal = new System.Windows.Forms.Label();
            this.lblDescribe = new System.Windows.Forms.Label();
            this.lblYourHeight = new System.Windows.Forms.Label();
            this.blYourWeight = new System.Windows.Forms.Label();
            this.txtBmiHeight = new System.Windows.Forms.TextBox();
            this.txtBmiWeight = new System.Windows.Forms.TextBox();
            this.lblm = new System.Windows.Forms.Label();
            this.lblKg = new System.Windows.Forms.Label();
            this.btnBMI = new System.Windows.Forms.Button();
            this.lblDescribeBMI = new System.Windows.Forms.Label();
            this.lblBMI = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.tabCalculators.SuspendLayout();
            this.tabCalorie.SuspendLayout();
            this.tabBMI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMeal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(183)))), ((int)(((byte)(43)))));
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(152, 404);
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
            this.pbLogo.Location = new System.Drawing.Point(16, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(405, 81);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 8;
            this.pbLogo.TabStop = false;
            // 
            // tabCalculators
            // 
            this.tabCalculators.Controls.Add(this.tabCalorie);
            this.tabCalculators.Controls.Add(this.tabBMI);
            this.tabCalculators.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCalculators.Location = new System.Drawing.Point(12, 99);
            this.tabCalculators.Name = "tabCalculators";
            this.tabCalculators.SelectedIndex = 0;
            this.tabCalculators.Size = new System.Drawing.Size(413, 299);
            this.tabCalculators.TabIndex = 10;
            // 
            // tabCalorie
            // 
            this.tabCalorie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabCalorie.Controls.Add(this.lblDescribe);
            this.tabCalorie.Controls.Add(this.btnCalc);
            this.tabCalorie.Controls.Add(this.lblMeal);
            this.tabCalorie.Controls.Add(this.lblCal);
            this.tabCalorie.Controls.Add(this.txtCal);
            this.tabCalorie.Controls.Add(this.txtCalMeal);
            this.tabCalorie.Controls.Add(this.lblCalMeal);
            this.tabCalorie.Controls.Add(this.nudMeal);
            this.tabCalorie.Location = new System.Drawing.Point(4, 30);
            this.tabCalorie.Name = "tabCalorie";
            this.tabCalorie.Padding = new System.Windows.Forms.Padding(3);
            this.tabCalorie.Size = new System.Drawing.Size(405, 265);
            this.tabCalorie.TabIndex = 0;
            this.tabCalorie.Text = "Calories";
            this.tabCalorie.UseVisualStyleBackColor = true;
            // 
            // tabBMI
            // 
            this.tabBMI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabBMI.Controls.Add(this.lblStatus);
            this.tabBMI.Controls.Add(this.lblBMI);
            this.tabBMI.Controls.Add(this.lblDescribeBMI);
            this.tabBMI.Controls.Add(this.btnBMI);
            this.tabBMI.Controls.Add(this.lblKg);
            this.tabBMI.Controls.Add(this.lblm);
            this.tabBMI.Controls.Add(this.txtBmiWeight);
            this.tabBMI.Controls.Add(this.txtBmiHeight);
            this.tabBMI.Controls.Add(this.blYourWeight);
            this.tabBMI.Controls.Add(this.lblYourHeight);
            this.tabBMI.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabBMI.Location = new System.Drawing.Point(4, 30);
            this.tabBMI.Name = "tabBMI";
            this.tabBMI.Padding = new System.Windows.Forms.Padding(3);
            this.tabBMI.Size = new System.Drawing.Size(405, 265);
            this.tabBMI.TabIndex = 1;
            this.tabBMI.Text = "BMI";
            this.tabBMI.UseVisualStyleBackColor = true;
            // 
            // txtCalMeal
            // 
            this.txtCalMeal.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalMeal.Location = new System.Drawing.Point(293, 216);
            this.txtCalMeal.Name = "txtCalMeal";
            this.txtCalMeal.ReadOnly = true;
            this.txtCalMeal.Size = new System.Drawing.Size(71, 29);
            this.txtCalMeal.TabIndex = 4;
            // 
            // lblMeal
            // 
            this.lblMeal.AutoSize = true;
            this.lblMeal.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeal.Location = new System.Drawing.Point(41, 104);
            this.lblMeal.Name = "lblMeal";
            this.lblMeal.Size = new System.Drawing.Size(211, 21);
            this.lblMeal.TabIndex = 5;
            this.lblMeal.Text = "How many meals per day:";
            // 
            // txtCal
            // 
            this.txtCal.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCal.Location = new System.Drawing.Point(293, 15);
            this.txtCal.Name = "txtCal";
            this.txtCal.Size = new System.Drawing.Size(71, 29);
            this.txtCal.TabIndex = 3;
            // 
            // nudMeal
            // 
            this.nudMeal.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMeal.Location = new System.Drawing.Point(293, 102);
            this.nudMeal.Name = "nudMeal";
            this.nudMeal.Size = new System.Drawing.Size(71, 29);
            this.nudMeal.TabIndex = 6;
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(183)))), ((int)(((byte)(43)))));
            this.btnCalc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.ForeColor = System.Drawing.Color.White;
            this.btnCalc.Location = new System.Drawing.Point(136, 152);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(137, 45);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblCalMeal
            // 
            this.lblCalMeal.AutoSize = true;
            this.lblCalMeal.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalMeal.Location = new System.Drawing.Point(41, 219);
            this.lblCalMeal.Name = "lblCalMeal";
            this.lblCalMeal.Size = new System.Drawing.Size(152, 21);
            this.lblCalMeal.TabIndex = 1;
            this.lblCalMeal.Text = "Calories per meal:";
            // 
            // lblCal
            // 
            this.lblCal.AutoSize = true;
            this.lblCal.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCal.Location = new System.Drawing.Point(41, 18);
            this.lblCal.Name = "lblCal";
            this.lblCal.Size = new System.Drawing.Size(156, 21);
            this.lblCal.TabIndex = 0;
            this.lblCal.Text = "Daily calorie need:";
            // 
            // lblDescribe
            // 
            this.lblDescribe.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescribe.ForeColor = System.Drawing.Color.Green;
            this.lblDescribe.Location = new System.Drawing.Point(74, 47);
            this.lblDescribe.Name = "lblDescribe";
            this.lblDescribe.Size = new System.Drawing.Size(250, 35);
            this.lblDescribe.TabIndex = 9;
            this.lblDescribe.Text = "Daily Calorie need is calculated based on your Height, Weight and Age";
            this.lblDescribe.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblYourHeight
            // 
            this.lblYourHeight.AutoSize = true;
            this.lblYourHeight.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourHeight.Location = new System.Drawing.Point(78, 17);
            this.lblYourHeight.Name = "lblYourHeight";
            this.lblYourHeight.Size = new System.Drawing.Size(90, 19);
            this.lblYourHeight.TabIndex = 0;
            this.lblYourHeight.Text = "Your Height:";
            // 
            // blYourWeight
            // 
            this.blYourWeight.AutoSize = true;
            this.blYourWeight.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blYourWeight.Location = new System.Drawing.Point(78, 49);
            this.blYourWeight.Name = "blYourWeight";
            this.blYourWeight.Size = new System.Drawing.Size(91, 19);
            this.blYourWeight.TabIndex = 1;
            this.blYourWeight.Text = "Your Weight:";
            // 
            // txtBmiHeight
            // 
            this.txtBmiHeight.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBmiHeight.Location = new System.Drawing.Point(172, 14);
            this.txtBmiHeight.Name = "txtBmiHeight";
            this.txtBmiHeight.Size = new System.Drawing.Size(100, 26);
            this.txtBmiHeight.TabIndex = 2;
            // 
            // txtBmiWeight
            // 
            this.txtBmiWeight.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBmiWeight.Location = new System.Drawing.Point(172, 46);
            this.txtBmiWeight.Name = "txtBmiWeight";
            this.txtBmiWeight.Size = new System.Drawing.Size(100, 26);
            this.txtBmiWeight.TabIndex = 3;
            // 
            // lblm
            // 
            this.lblm.AutoSize = true;
            this.lblm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblm.Location = new System.Drawing.Point(278, 17);
            this.lblm.Name = "lblm";
            this.lblm.Size = new System.Drawing.Size(21, 19);
            this.lblm.TabIndex = 4;
            this.lblm.Text = "m";
            // 
            // lblKg
            // 
            this.lblKg.AutoSize = true;
            this.lblKg.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKg.Location = new System.Drawing.Point(278, 49);
            this.lblKg.Name = "lblKg";
            this.lblKg.Size = new System.Drawing.Size(25, 19);
            this.lblKg.TabIndex = 5;
            this.lblKg.Text = "kg";
            // 
            // btnBMI
            // 
            this.btnBMI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(183)))), ((int)(((byte)(43)))));
            this.btnBMI.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBMI.ForeColor = System.Drawing.Color.White;
            this.btnBMI.Location = new System.Drawing.Point(135, 131);
            this.btnBMI.Name = "btnBMI";
            this.btnBMI.Size = new System.Drawing.Size(137, 45);
            this.btnBMI.TabIndex = 6;
            this.btnBMI.Text = "Calculate";
            this.btnBMI.UseVisualStyleBackColor = false;
            this.btnBMI.Click += new System.EventHandler(this.BtnBMI_Click);
            // 
            // lblDescribeBMI
            // 
            this.lblDescribeBMI.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescribeBMI.ForeColor = System.Drawing.Color.Green;
            this.lblDescribeBMI.Location = new System.Drawing.Point(6, 89);
            this.lblDescribeBMI.Name = "lblDescribeBMI";
            this.lblDescribeBMI.Size = new System.Drawing.Size(389, 39);
            this.lblDescribeBMI.TabIndex = 10;
            this.lblDescribeBMI.Text = "Your Body Mass Index (BMI) is calculated using the formula:\r\nWeight (KG) ÷ Height" +
    " (Metres²)";
            this.lblDescribeBMI.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBMI.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblBMI.Location = new System.Drawing.Point(130, 189);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(134, 26);
            this.lblBMI.TabIndex = 11;
            this.lblBMI.Text = "Your BMI...";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Green;
            this.lblStatus.Location = new System.Drawing.Point(131, 225);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(117, 22);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Your status...";
            // 
            // frmCalorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(435, 459);
            this.Controls.Add(this.tabCalculators);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCalorie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calorie Calculator";
            this.Load += new System.EventHandler(this.frmCalorie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.tabCalculators.ResumeLayout(false);
            this.tabCalorie.ResumeLayout(false);
            this.tabCalorie.PerformLayout();
            this.tabBMI.ResumeLayout(false);
            this.tabBMI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMeal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.TabControl tabCalculators;
        private System.Windows.Forms.TabPage tabCalorie;
        private System.Windows.Forms.TabPage tabBMI;
        private System.Windows.Forms.Label lblDescribe;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblMeal;
        private System.Windows.Forms.Label lblCal;
        private System.Windows.Forms.TextBox txtCal;
        private System.Windows.Forms.TextBox txtCalMeal;
        private System.Windows.Forms.Label lblCalMeal;
        private System.Windows.Forms.NumericUpDown nudMeal;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.Label lblDescribeBMI;
        private System.Windows.Forms.Button btnBMI;
        private System.Windows.Forms.Label lblKg;
        private System.Windows.Forms.Label lblm;
        private System.Windows.Forms.TextBox txtBmiWeight;
        private System.Windows.Forms.TextBox txtBmiHeight;
        private System.Windows.Forms.Label blYourWeight;
        private System.Windows.Forms.Label lblYourHeight;
    }
}