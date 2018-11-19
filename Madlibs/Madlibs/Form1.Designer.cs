namespace Madlibs
{
    partial class FrmMadLibs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMadLibs));
            this.tbColor = new System.Windows.Forms.TextBox();
            this.tbWordEst = new System.Windows.Forms.TextBox();
            this.tbBodyPartPlural = new System.Windows.Forms.TextBox();
            this.tbAnimal = new System.Windows.Forms.TextBox();
            this.tbNoun = new System.Windows.Forms.TextBox();
            this.lblStoryLabel = new System.Windows.Forms.Label();
            this.btnMakeMadLibsStory = new System.Windows.Forms.Button();
            this.tbPluralNoun = new System.Windows.Forms.TextBox();
            this.lblColorLabel = new System.Windows.Forms.Label();
            this.lblWordEstLabel = new System.Windows.Forms.Label();
            this.lblBodyPartPluralLabel = new System.Windows.Forms.Label();
            this.lblAnimalLabel = new System.Windows.Forms.Label();
            this.lblNounLabel = new System.Windows.Forms.Label();
            this.lblPluralNounLabel = new System.Windows.Forms.Label();
            this.lblMadLibsNewStory = new System.Windows.Forms.Label();
            this.tbFirstNum = new System.Windows.Forms.TextBox();
            this.tbSecondNum = new System.Windows.Forms.TextBox();
            this.lblFirstNum = new System.Windows.Forms.Label();
            this.lblSecondNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbColor
            // 
            this.tbColor.Location = new System.Drawing.Point(194, 104);
            this.tbColor.Name = "tbColor";
            this.tbColor.Size = new System.Drawing.Size(100, 20);
            this.tbColor.TabIndex = 0;
            // 
            // tbWordEst
            // 
            this.tbWordEst.Location = new System.Drawing.Point(194, 130);
            this.tbWordEst.Name = "tbWordEst";
            this.tbWordEst.Size = new System.Drawing.Size(100, 20);
            this.tbWordEst.TabIndex = 1;
            // 
            // tbBodyPartPlural
            // 
            this.tbBodyPartPlural.Location = new System.Drawing.Point(194, 202);
            this.tbBodyPartPlural.Name = "tbBodyPartPlural";
            this.tbBodyPartPlural.Size = new System.Drawing.Size(100, 20);
            this.tbBodyPartPlural.TabIndex = 4;
            // 
            // tbAnimal
            // 
            this.tbAnimal.Location = new System.Drawing.Point(194, 231);
            this.tbAnimal.Name = "tbAnimal";
            this.tbAnimal.Size = new System.Drawing.Size(100, 20);
            this.tbAnimal.TabIndex = 5;
            // 
            // tbNoun
            // 
            this.tbNoun.Location = new System.Drawing.Point(194, 257);
            this.tbNoun.Name = "tbNoun";
            this.tbNoun.Size = new System.Drawing.Size(100, 20);
            this.tbNoun.TabIndex = 6;
            // 
            // lblStoryLabel
            // 
            this.lblStoryLabel.AutoSize = true;
            this.lblStoryLabel.Location = new System.Drawing.Point(32, 45);
            this.lblStoryLabel.Name = "lblStoryLabel";
            this.lblStoryLabel.Size = new System.Drawing.Size(728, 26);
            this.lblStoryLabel.TabIndex = 6;
            this.lblStoryLabel.Text = resources.GetString("lblStoryLabel.Text");
            // 
            // btnMakeMadLibsStory
            // 
            this.btnMakeMadLibsStory.Location = new System.Drawing.Point(383, 130);
            this.btnMakeMadLibsStory.Name = "btnMakeMadLibsStory";
            this.btnMakeMadLibsStory.Size = new System.Drawing.Size(119, 72);
            this.btnMakeMadLibsStory.TabIndex = 7;
            this.btnMakeMadLibsStory.Text = "Make Your Mad Libs Story";
            this.btnMakeMadLibsStory.UseVisualStyleBackColor = true;
            this.btnMakeMadLibsStory.Click += new System.EventHandler(this.btnMakeMadLibsStory_Click);
            // 
            // tbPluralNoun
            // 
            this.tbPluralNoun.Location = new System.Drawing.Point(194, 292);
            this.tbPluralNoun.Name = "tbPluralNoun";
            this.tbPluralNoun.Size = new System.Drawing.Size(100, 20);
            this.tbPluralNoun.TabIndex = 7;
            // 
            // lblColorLabel
            // 
            this.lblColorLabel.AutoSize = true;
            this.lblColorLabel.Location = new System.Drawing.Point(81, 104);
            this.lblColorLabel.Name = "lblColorLabel";
            this.lblColorLabel.Size = new System.Drawing.Size(34, 13);
            this.lblColorLabel.TabIndex = 9;
            this.lblColorLabel.Text = "Color:";
            // 
            // lblWordEstLabel
            // 
            this.lblWordEstLabel.AutoSize = true;
            this.lblWordEstLabel.Location = new System.Drawing.Point(81, 130);
            this.lblWordEstLabel.Name = "lblWordEstLabel";
            this.lblWordEstLabel.Size = new System.Drawing.Size(90, 13);
            this.lblWordEstLabel.TabIndex = 10;
            this.lblWordEstLabel.Text = "Word Ending Est:";
            // 
            // lblBodyPartPluralLabel
            // 
            this.lblBodyPartPluralLabel.AutoSize = true;
            this.lblBodyPartPluralLabel.Location = new System.Drawing.Point(81, 209);
            this.lblBodyPartPluralLabel.Name = "lblBodyPartPluralLabel";
            this.lblBodyPartPluralLabel.Size = new System.Drawing.Size(100, 13);
            this.lblBodyPartPluralLabel.TabIndex = 11;
            this.lblBodyPartPluralLabel.Text = "Multiple Body Parts:";
            // 
            // lblAnimalLabel
            // 
            this.lblAnimalLabel.AutoSize = true;
            this.lblAnimalLabel.Location = new System.Drawing.Point(81, 231);
            this.lblAnimalLabel.Name = "lblAnimalLabel";
            this.lblAnimalLabel.Size = new System.Drawing.Size(41, 13);
            this.lblAnimalLabel.TabIndex = 13;
            this.lblAnimalLabel.Text = "Animal:";
            // 
            // lblNounLabel
            // 
            this.lblNounLabel.AutoSize = true;
            this.lblNounLabel.Location = new System.Drawing.Point(86, 264);
            this.lblNounLabel.Name = "lblNounLabel";
            this.lblNounLabel.Size = new System.Drawing.Size(36, 13);
            this.lblNounLabel.TabIndex = 14;
            this.lblNounLabel.Text = "Noun:";
            // 
            // lblPluralNounLabel
            // 
            this.lblPluralNounLabel.AutoSize = true;
            this.lblPluralNounLabel.Location = new System.Drawing.Point(81, 295);
            this.lblPluralNounLabel.Name = "lblPluralNounLabel";
            this.lblPluralNounLabel.Size = new System.Drawing.Size(65, 13);
            this.lblPluralNounLabel.TabIndex = 15;
            this.lblPluralNounLabel.Text = "Plural Noun:";
            // 
            // lblMadLibsNewStory
            // 
            this.lblMadLibsNewStory.AutoSize = true;
            this.lblMadLibsNewStory.Location = new System.Drawing.Point(32, 319);
            this.lblMadLibsNewStory.Name = "lblMadLibsNewStory";
            this.lblMadLibsNewStory.Size = new System.Drawing.Size(0, 13);
            this.lblMadLibsNewStory.TabIndex = 16;
            // 
            // tbFirstNum
            // 
            this.tbFirstNum.Location = new System.Drawing.Point(194, 157);
            this.tbFirstNum.Name = "tbFirstNum";
            this.tbFirstNum.Size = new System.Drawing.Size(100, 20);
            this.tbFirstNum.TabIndex = 2;
            // 
            // tbSecondNum
            // 
            this.tbSecondNum.Location = new System.Drawing.Point(194, 180);
            this.tbSecondNum.Name = "tbSecondNum";
            this.tbSecondNum.Size = new System.Drawing.Size(100, 20);
            this.tbSecondNum.TabIndex = 3;
            // 
            // lblFirstNum
            // 
            this.lblFirstNum.AutoSize = true;
            this.lblFirstNum.Location = new System.Drawing.Point(86, 159);
            this.lblFirstNum.Name = "lblFirstNum";
            this.lblFirstNum.Size = new System.Drawing.Size(54, 13);
            this.lblFirstNum.TabIndex = 18;
            this.lblFirstNum.Text = "First Num:";
            // 
            // lblSecondNum
            // 
            this.lblSecondNum.AutoSize = true;
            this.lblSecondNum.Location = new System.Drawing.Point(39, 180);
            this.lblSecondNum.Name = "lblSecondNum";
            this.lblSecondNum.Size = new System.Drawing.Size(149, 13);
            this.lblSecondNum.TabIndex = 19;
            this.lblSecondNum.Text = "Second Num ( Less than first):";
            // 
            // FrmMadLibs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSecondNum);
            this.Controls.Add(this.lblFirstNum);
            this.Controls.Add(this.tbSecondNum);
            this.Controls.Add(this.tbFirstNum);
            this.Controls.Add(this.lblMadLibsNewStory);
            this.Controls.Add(this.lblPluralNounLabel);
            this.Controls.Add(this.lblNounLabel);
            this.Controls.Add(this.lblAnimalLabel);
            this.Controls.Add(this.lblBodyPartPluralLabel);
            this.Controls.Add(this.lblWordEstLabel);
            this.Controls.Add(this.lblColorLabel);
            this.Controls.Add(this.tbPluralNoun);
            this.Controls.Add(this.btnMakeMadLibsStory);
            this.Controls.Add(this.lblStoryLabel);
            this.Controls.Add(this.tbNoun);
            this.Controls.Add(this.tbAnimal);
            this.Controls.Add(this.tbBodyPartPlural);
            this.Controls.Add(this.tbWordEst);
            this.Controls.Add(this.tbColor);
            this.Name = "FrmMadLibs";
            this.Text = "MadLibs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbColor;
        private System.Windows.Forms.TextBox tbWordEst;
        private System.Windows.Forms.TextBox tbBodyPartPlural;
        private System.Windows.Forms.TextBox tbAnimal;
        private System.Windows.Forms.TextBox tbNoun;
        private System.Windows.Forms.Label lblStoryLabel;
        private System.Windows.Forms.Button btnMakeMadLibsStory;
        private System.Windows.Forms.TextBox tbPluralNoun;
        private System.Windows.Forms.Label lblColorLabel;
        private System.Windows.Forms.Label lblWordEstLabel;
        private System.Windows.Forms.Label lblBodyPartPluralLabel;
        private System.Windows.Forms.Label lblAnimalLabel;
        private System.Windows.Forms.Label lblNounLabel;
        private System.Windows.Forms.Label lblPluralNounLabel;
        private System.Windows.Forms.Label lblMadLibsNewStory;
        private System.Windows.Forms.TextBox tbFirstNum;
        private System.Windows.Forms.TextBox tbSecondNum;
        private System.Windows.Forms.Label lblFirstNum;
        private System.Windows.Forms.Label lblSecondNum;
    }
}

