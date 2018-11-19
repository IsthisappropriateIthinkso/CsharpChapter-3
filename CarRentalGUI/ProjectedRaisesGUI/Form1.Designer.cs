namespace ProjectedRaisesGUI
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
            this.tbDays = new System.Windows.Forms.TextBox();
            this.tbMiles = new System.Windows.Forms.TextBox();
            this.btnRentFee = new System.Windows.Forms.Button();
            this.lblDays = new System.Windows.Forms.Label();
            this.lblMiles = new System.Windows.Forms.Label();
            this.lblTotalRentFee = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbDays
            // 
            this.tbDays.Location = new System.Drawing.Point(150, 82);
            this.tbDays.Name = "tbDays";
            this.tbDays.Size = new System.Drawing.Size(100, 20);
            this.tbDays.TabIndex = 0;
            // 
            // tbMiles
            // 
            this.tbMiles.Location = new System.Drawing.Point(150, 141);
            this.tbMiles.Name = "tbMiles";
            this.tbMiles.Size = new System.Drawing.Size(100, 20);
            this.tbMiles.TabIndex = 1;
            // 
            // btnRentFee
            // 
            this.btnRentFee.Location = new System.Drawing.Point(340, 82);
            this.btnRentFee.Name = "btnRentFee";
            this.btnRentFee.Size = new System.Drawing.Size(140, 49);
            this.btnRentFee.TabIndex = 2;
            this.btnRentFee.Text = "Rent Fee";
            this.btnRentFee.UseVisualStyleBackColor = true;
            this.btnRentFee.Click += new System.EventHandler(this.btnRentFee_Click);
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(50, 82);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(34, 13);
            this.lblDays.TabIndex = 3;
            this.lblDays.Text = "Days:";
            // 
            // lblMiles
            // 
            this.lblMiles.AutoSize = true;
            this.lblMiles.Location = new System.Drawing.Point(50, 141);
            this.lblMiles.Name = "lblMiles";
            this.lblMiles.Size = new System.Drawing.Size(34, 13);
            this.lblMiles.TabIndex = 4;
            this.lblMiles.Text = "Miles:";
            // 
            // lblTotalRentFee
            // 
            this.lblTotalRentFee.AutoSize = true;
            this.lblTotalRentFee.Location = new System.Drawing.Point(602, 97);
            this.lblTotalRentFee.Name = "lblTotalRentFee";
            this.lblTotalRentFee.Size = new System.Drawing.Size(35, 13);
            this.lblTotalRentFee.TabIndex = 5;
            this.lblTotalRentFee.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotalRentFee);
            this.Controls.Add(this.lblMiles);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.btnRentFee);
            this.Controls.Add(this.tbMiles);
            this.Controls.Add(this.tbDays);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDays;
        private System.Windows.Forms.TextBox tbMiles;
        private System.Windows.Forms.Button btnRentFee;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Label lblMiles;
        private System.Windows.Forms.Label lblTotalRentFee;
    }
}

