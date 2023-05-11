namespace GitFit
{
    partial class TimeQuestionnaire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeQuestionnaire));
            this.timeQuestionnaireLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timeQuestionnaireLabel
            // 
            this.timeQuestionnaireLabel.BackColor = System.Drawing.Color.LightSlateGray;
            this.timeQuestionnaireLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeQuestionnaireLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.timeQuestionnaireLabel.Location = new System.Drawing.Point(0, 0);
            this.timeQuestionnaireLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.timeQuestionnaireLabel.Name = "timeQuestionnaireLabel";
            this.timeQuestionnaireLabel.Size = new System.Drawing.Size(922, 50);
            this.timeQuestionnaireLabel.TabIndex = 60;
            this.timeQuestionnaireLabel.Text = "TIME MANAGEMENT QUESTIONNAIRE";
            this.timeQuestionnaireLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeQuestionnaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(922, 722);
            this.Controls.Add(this.timeQuestionnaireLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TimeQuestionnaire";
            this.Text = "Time Management Questionnaire";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label timeQuestionnaireLabel;
    }
}