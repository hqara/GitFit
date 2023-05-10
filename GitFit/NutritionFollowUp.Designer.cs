namespace GitFit
{
    partial class NutritionQuestionnaireFollowUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NutritionQuestionnaireFollowUp));
            this.resultsButton = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultsButton
            // 
            this.resultsButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.resultsButton.FlatAppearance.BorderSize = 5;
            this.resultsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.resultsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resultsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsButton.ForeColor = System.Drawing.Color.White;
            this.resultsButton.Location = new System.Drawing.Point(574, 781);
            this.resultsButton.Margin = new System.Windows.Forms.Padding(4);
            this.resultsButton.Name = "resultsButton";
            this.resultsButton.Size = new System.Drawing.Size(112, 59);
            this.resultsButton.TabIndex = 70;
            this.resultsButton.Text = "Results";
            this.resultsButton.UseVisualStyleBackColor = false;
            this.resultsButton.Click += new System.EventHandler(this.resultsButton_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.exitBtn.FlatAppearance.BorderSize = 5;
            this.exitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(436, 781);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(112, 59);
            this.exitBtn.TabIndex = 69;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // NutritionQuestionnaireFollowUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(699, 853);
            this.Controls.Add(this.resultsButton);
            this.Controls.Add(this.exitBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NutritionQuestionnaireFollowUp";
            this.Text = "GitFit - Nutrition Questionnaire";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button resultsButton;
        private System.Windows.Forms.Button exitBtn;
    }
}