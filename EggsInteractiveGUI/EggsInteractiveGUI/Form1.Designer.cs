namespace EggsInteractiveGUI
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
            this.lblChickens = new System.Windows.Forms.Label();
            this.lblTotDozLeft = new System.Windows.Forms.Label();
            this.tbEggProduced1 = new System.Windows.Forms.TextBox();
            this.tbEggProduced2 = new System.Windows.Forms.TextBox();
            this.tbEggProduced3 = new System.Windows.Forms.TextBox();
            this.tbEggProduced4 = new System.Windows.Forms.TextBox();
            this.tbEggProduced5 = new System.Windows.Forms.TextBox();
            this.btnCalcEggs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblChickens
            // 
            this.lblChickens.AutoSize = true;
            this.lblChickens.Location = new System.Drawing.Point(255, 27);
            this.lblChickens.Name = "lblChickens";
            this.lblChickens.Size = new System.Drawing.Size(191, 13);
            this.lblChickens.TabIndex = 0;
            this.lblChickens.Text = "Enter eggs produced by all 5 chickens ";
            // 
            // lblTotDozLeft
            // 
            this.lblTotDozLeft.AutoSize = true;
            this.lblTotDozLeft.Location = new System.Drawing.Point(308, 295);
            this.lblTotDozLeft.Name = "lblTotDozLeft";
            this.lblTotDozLeft.Size = new System.Drawing.Size(0, 13);
            this.lblTotDozLeft.TabIndex = 3;
            // 
            // tbEggProduced1
            // 
            this.tbEggProduced1.Location = new System.Drawing.Point(71, 84);
            this.tbEggProduced1.Name = "tbEggProduced1";
            this.tbEggProduced1.Size = new System.Drawing.Size(100, 20);
            this.tbEggProduced1.TabIndex = 5;
            // 
            // tbEggProduced2
            // 
            this.tbEggProduced2.Location = new System.Drawing.Point(177, 84);
            this.tbEggProduced2.Name = "tbEggProduced2";
            this.tbEggProduced2.Size = new System.Drawing.Size(100, 20);
            this.tbEggProduced2.TabIndex = 6;
            // 
            // tbEggProduced3
            // 
            this.tbEggProduced3.Location = new System.Drawing.Point(283, 84);
            this.tbEggProduced3.Name = "tbEggProduced3";
            this.tbEggProduced3.Size = new System.Drawing.Size(100, 20);
            this.tbEggProduced3.TabIndex = 7;
            // 
            // tbEggProduced4
            // 
            this.tbEggProduced4.Location = new System.Drawing.Point(389, 84);
            this.tbEggProduced4.Name = "tbEggProduced4";
            this.tbEggProduced4.Size = new System.Drawing.Size(100, 20);
            this.tbEggProduced4.TabIndex = 8;
            // 
            // tbEggProduced5
            // 
            this.tbEggProduced5.Location = new System.Drawing.Point(495, 84);
            this.tbEggProduced5.Name = "tbEggProduced5";
            this.tbEggProduced5.Size = new System.Drawing.Size(100, 20);
            this.tbEggProduced5.TabIndex = 9;
            // 
            // btnCalcEggs
            // 
            this.btnCalcEggs.Location = new System.Drawing.Point(328, 196);
            this.btnCalcEggs.Name = "btnCalcEggs";
            this.btnCalcEggs.Size = new System.Drawing.Size(144, 66);
            this.btnCalcEggs.TabIndex = 10;
            this.btnCalcEggs.Text = "Eggs Calculator";
            this.btnCalcEggs.UseVisualStyleBackColor = true;
            this.btnCalcEggs.Click += new System.EventHandler(this.btnCalcEggs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcEggs);
            this.Controls.Add(this.tbEggProduced5);
            this.Controls.Add(this.tbEggProduced4);
            this.Controls.Add(this.tbEggProduced3);
            this.Controls.Add(this.tbEggProduced2);
            this.Controls.Add(this.tbEggProduced1);
            this.Controls.Add(this.lblTotDozLeft);
            this.Controls.Add(this.lblChickens);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChickens;
        private System.Windows.Forms.Label lblTotDozLeft;
        private System.Windows.Forms.TextBox tbEggProduced1;
        private System.Windows.Forms.TextBox tbEggProduced2;
        private System.Windows.Forms.TextBox tbEggProduced3;
        private System.Windows.Forms.TextBox tbEggProduced4;
        private System.Windows.Forms.TextBox tbEggProduced5;
        private System.Windows.Forms.Button btnCalcEggs;
    }
}

