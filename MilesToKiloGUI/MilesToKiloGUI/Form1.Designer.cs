namespace MilesToKiloGUI
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
            this.btnCalcMilesKilo = new System.Windows.Forms.Button();
            this.tbMiles = new System.Windows.Forms.TextBox();
            this.lblMiles = new System.Windows.Forms.Label();
            this.lblMilesToKilos = new System.Windows.Forms.Label();
            this.lblKilosToMiles = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcMilesKilo
            // 
            this.btnCalcMilesKilo.Location = new System.Drawing.Point(330, 51);
            this.btnCalcMilesKilo.Name = "btnCalcMilesKilo";
            this.btnCalcMilesKilo.Size = new System.Drawing.Size(114, 42);
            this.btnCalcMilesKilo.TabIndex = 0;
            this.btnCalcMilesKilo.Text = "Miles To Kilos";
            this.btnCalcMilesKilo.UseVisualStyleBackColor = true;
            this.btnCalcMilesKilo.Click += new System.EventHandler(this.btnCalcMilesKilo_Click);
            // 
            // tbMiles
            // 
            this.tbMiles.Location = new System.Drawing.Point(112, 73);
            this.tbMiles.Name = "tbMiles";
            this.tbMiles.Size = new System.Drawing.Size(100, 20);
            this.tbMiles.TabIndex = 1;
            // 
            // lblMiles
            // 
            this.lblMiles.AutoSize = true;
            this.lblMiles.Location = new System.Drawing.Point(42, 73);
            this.lblMiles.Name = "lblMiles";
            this.lblMiles.Size = new System.Drawing.Size(34, 13);
            this.lblMiles.TabIndex = 3;
            this.lblMiles.Text = "Miles:";
            // 
            // lblMilesToKilos
            // 
            this.lblMilesToKilos.AutoSize = true;
            this.lblMilesToKilos.Location = new System.Drawing.Point(608, 73);
            this.lblMilesToKilos.Name = "lblMilesToKilos";
            this.lblMilesToKilos.Size = new System.Drawing.Size(0, 13);
            this.lblMilesToKilos.TabIndex = 6;
            // 
            // lblKilosToMiles
            // 
            this.lblKilosToMiles.AutoSize = true;
            this.lblKilosToMiles.Location = new System.Drawing.Point(626, 161);
            this.lblKilosToMiles.Name = "lblKilosToMiles";
            this.lblKilosToMiles.Size = new System.Drawing.Size(0, 13);
            this.lblKilosToMiles.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblKilosToMiles);
            this.Controls.Add(this.lblMilesToKilos);
            this.Controls.Add(this.lblMiles);
            this.Controls.Add(this.tbMiles);
            this.Controls.Add(this.btnCalcMilesKilo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcMilesKilo;
        private System.Windows.Forms.TextBox tbMiles;
        private System.Windows.Forms.Label lblMiles;
        private System.Windows.Forms.Label lblMilesToKilos;
        private System.Windows.Forms.Label lblKilosToMiles;
    }
}

