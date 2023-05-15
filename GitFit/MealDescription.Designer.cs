namespace GitFit
{
    partial class MealDescription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MealDescription));
            this.BenefitsTextBox = new System.Windows.Forms.TextBox();
            this.mealDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.macroInformationTextBox = new System.Windows.Forms.TextBox();
            this.mealNameLabel = new System.Windows.Forms.Label();
            this.mealPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mealPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BenefitsTextBox
            // 
            this.BenefitsTextBox.Location = new System.Drawing.Point(16, 523);
            this.BenefitsTextBox.Multiline = true;
            this.BenefitsTextBox.Name = "BenefitsTextBox";
            this.BenefitsTextBox.ReadOnly = true;
            this.BenefitsTextBox.Size = new System.Drawing.Size(346, 112);
            this.BenefitsTextBox.TabIndex = 9;
            // 
            // mealDescriptionTextBox
            // 
            this.mealDescriptionTextBox.Location = new System.Drawing.Point(16, 396);
            this.mealDescriptionTextBox.Multiline = true;
            this.mealDescriptionTextBox.Name = "mealDescriptionTextBox";
            this.mealDescriptionTextBox.ReadOnly = true;
            this.mealDescriptionTextBox.Size = new System.Drawing.Size(346, 112);
            this.mealDescriptionTextBox.TabIndex = 8;
            // 
            // macroInformationTextBox
            // 
            this.macroInformationTextBox.Location = new System.Drawing.Point(16, 267);
            this.macroInformationTextBox.Multiline = true;
            this.macroInformationTextBox.Name = "macroInformationTextBox";
            this.macroInformationTextBox.ReadOnly = true;
            this.macroInformationTextBox.Size = new System.Drawing.Size(346, 112);
            this.macroInformationTextBox.TabIndex = 7;
            // 
            // mealNameLabel
            // 
            this.mealNameLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mealNameLabel.Location = new System.Drawing.Point(12, 241);
            this.mealNameLabel.Name = "mealNameLabel";
            this.mealNameLabel.Size = new System.Drawing.Size(350, 23);
            this.mealNameLabel.TabIndex = 6;
            this.mealNameLabel.Text = "mealNameLabel";
            // 
            // mealPictureBox
            // 
            this.mealPictureBox.Location = new System.Drawing.Point(12, 12);
            this.mealPictureBox.Name = "mealPictureBox";
            this.mealPictureBox.Size = new System.Drawing.Size(350, 216);
            this.mealPictureBox.TabIndex = 5;
            this.mealPictureBox.TabStop = false;
            // 
            // MealDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 646);
            this.Controls.Add(this.BenefitsTextBox);
            this.Controls.Add(this.mealDescriptionTextBox);
            this.Controls.Add(this.macroInformationTextBox);
            this.Controls.Add(this.mealNameLabel);
            this.Controls.Add(this.mealPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MealDescription";
            this.Text = "MealDescription";
            ((System.ComponentModel.ISupportInitialize)(this.mealPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BenefitsTextBox;
        private System.Windows.Forms.TextBox mealDescriptionTextBox;
        private System.Windows.Forms.TextBox macroInformationTextBox;
        private System.Windows.Forms.Label mealNameLabel;
        private System.Windows.Forms.PictureBox mealPictureBox;
    }
}