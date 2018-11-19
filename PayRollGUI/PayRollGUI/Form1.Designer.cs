namespace PayRollGUI
{
    partial class Form1
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSocialSecurity = new System.Windows.Forms.TextBox();
            this.tbHourlyPay = new System.Windows.Forms.TextBox();
            this.tbHoursWorked = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSocialSecurityNum = new System.Windows.Forms.Label();
            this.lblHourPayrate = new System.Windows.Forms.Label();
            this.lblHoursWorked = new System.Windows.Forms.Label();
            this.btnCalcMoneyStuff = new System.Windows.Forms.Button();
            this.lblPayroll = new System.Windows.Forms.Label();
            this.lblNameLabel = new System.Windows.Forms.Label();
            this.lblSocialSecurityLabel = new System.Windows.Forms.Label();
            this.lblHourlyPayLabel = new System.Windows.Forms.Label();
            this.lblHoursWorkedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(130, 60);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 0;
            // 
            // tbSocialSecurity
            // 
            this.tbSocialSecurity.Location = new System.Drawing.Point(130, 86);
            this.tbSocialSecurity.Name = "tbSocialSecurity";
            this.tbSocialSecurity.Size = new System.Drawing.Size(100, 20);
            this.tbSocialSecurity.TabIndex = 1;
            // 
            // tbHourlyPay
            // 
            this.tbHourlyPay.Location = new System.Drawing.Point(130, 112);
            this.tbHourlyPay.Name = "tbHourlyPay";
            this.tbHourlyPay.Size = new System.Drawing.Size(100, 20);
            this.tbHourlyPay.TabIndex = 2;
            // 
            // tbHoursWorked
            // 
            this.tbHoursWorked.Location = new System.Drawing.Point(130, 138);
            this.tbHoursWorked.Name = "tbHoursWorked";
            this.tbHoursWorked.Size = new System.Drawing.Size(100, 20);
            this.tbHoursWorked.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(86, 230);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name:";
            // 
            // lblSocialSecurityNum
            // 
            this.lblSocialSecurityNum.AutoSize = true;
            this.lblSocialSecurityNum.Location = new System.Drawing.Point(206, 230);
            this.lblSocialSecurityNum.Name = "lblSocialSecurityNum";
            this.lblSocialSecurityNum.Size = new System.Drawing.Size(80, 13);
            this.lblSocialSecurityNum.TabIndex = 5;
            this.lblSocialSecurityNum.Text = "Social Security:";
            // 
            // lblHourPayrate
            // 
            this.lblHourPayrate.AutoSize = true;
            this.lblHourPayrate.Location = new System.Drawing.Point(553, 230);
            this.lblHourPayrate.Name = "lblHourPayrate";
            this.lblHourPayrate.Size = new System.Drawing.Size(61, 13);
            this.lblHourPayrate.TabIndex = 6;
            this.lblHourPayrate.Text = "Hourly Pay:";
            // 
            // lblHoursWorked
            // 
            this.lblHoursWorked.AutoSize = true;
            this.lblHoursWorked.Location = new System.Drawing.Point(371, 230);
            this.lblHoursWorked.Name = "lblHoursWorked";
            this.lblHoursWorked.Size = new System.Drawing.Size(79, 13);
            this.lblHoursWorked.TabIndex = 7;
            this.lblHoursWorked.Text = "Hours Worked:";
            // 
            // btnCalcMoneyStuff
            // 
            this.btnCalcMoneyStuff.Location = new System.Drawing.Point(299, 76);
            this.btnCalcMoneyStuff.Name = "btnCalcMoneyStuff";
            this.btnCalcMoneyStuff.Size = new System.Drawing.Size(100, 39);
            this.btnCalcMoneyStuff.TabIndex = 8;
            this.btnCalcMoneyStuff.Text = "Money Stuff";
            this.btnCalcMoneyStuff.UseVisualStyleBackColor = true;
            this.btnCalcMoneyStuff.Click += new System.EventHandler(this.btnCalcMoneyStuff_Click);
            // 
            // lblPayroll
            // 
            this.lblPayroll.AutoSize = true;
            this.lblPayroll.Location = new System.Drawing.Point(286, 249);
            this.lblPayroll.Name = "lblPayroll";
            this.lblPayroll.Size = new System.Drawing.Size(0, 13);
            this.lblPayroll.TabIndex = 9;
            // 
            // lblNameLabel
            // 
            this.lblNameLabel.AutoSize = true;
            this.lblNameLabel.Location = new System.Drawing.Point(79, 60);
            this.lblNameLabel.Name = "lblNameLabel";
            this.lblNameLabel.Size = new System.Drawing.Size(38, 13);
            this.lblNameLabel.TabIndex = 10;
            this.lblNameLabel.Text = "Name:";
            // 
            // lblSocialSecurityLabel
            // 
            this.lblSocialSecurityLabel.AutoSize = true;
            this.lblSocialSecurityLabel.Location = new System.Drawing.Point(37, 86);
            this.lblSocialSecurityLabel.Name = "lblSocialSecurityLabel";
            this.lblSocialSecurityLabel.Size = new System.Drawing.Size(80, 13);
            this.lblSocialSecurityLabel.TabIndex = 11;
            this.lblSocialSecurityLabel.Text = "Social Security:";
            // 
            // lblHourlyPayLabel
            // 
            this.lblHourlyPayLabel.AutoSize = true;
            this.lblHourlyPayLabel.Location = new System.Drawing.Point(56, 112);
            this.lblHourlyPayLabel.Name = "lblHourlyPayLabel";
            this.lblHourlyPayLabel.Size = new System.Drawing.Size(61, 13);
            this.lblHourlyPayLabel.TabIndex = 12;
            this.lblHourlyPayLabel.Text = "Hourly Pay:";
            // 
            // lblHoursWorkedLabel
            // 
            this.lblHoursWorkedLabel.AutoSize = true;
            this.lblHoursWorkedLabel.Location = new System.Drawing.Point(38, 141);
            this.lblHoursWorkedLabel.Name = "lblHoursWorkedLabel";
            this.lblHoursWorkedLabel.Size = new System.Drawing.Size(79, 13);
            this.lblHoursWorkedLabel.TabIndex = 13;
            this.lblHoursWorkedLabel.Text = "Hours Worked:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHoursWorkedLabel);
            this.Controls.Add(this.lblHourlyPayLabel);
            this.Controls.Add(this.lblSocialSecurityLabel);
            this.Controls.Add(this.lblNameLabel);
            this.Controls.Add(this.lblPayroll);
            this.Controls.Add(this.btnCalcMoneyStuff);
            this.Controls.Add(this.lblHoursWorked);
            this.Controls.Add(this.lblHourPayrate);
            this.Controls.Add(this.lblSocialSecurityNum);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbHoursWorked);
            this.Controls.Add(this.tbHourlyPay);
            this.Controls.Add(this.tbSocialSecurity);
            this.Controls.Add(this.tbName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSocialSecurity;
        private System.Windows.Forms.TextBox tbHourlyPay;
        private System.Windows.Forms.TextBox tbHoursWorked;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSocialSecurityNum;
        private System.Windows.Forms.Label lblHourPayrate;
        private System.Windows.Forms.Label lblHoursWorked;
        private System.Windows.Forms.Button btnCalcMoneyStuff;
        private System.Windows.Forms.Label lblPayroll;
        private System.Windows.Forms.Label lblNameLabel;
        private System.Windows.Forms.Label lblSocialSecurityLabel;
        private System.Windows.Forms.Label lblHourlyPayLabel;
        private System.Windows.Forms.Label lblHoursWorkedLabel;
    }
}

