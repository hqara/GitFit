namespace GitFit
{
    partial class TimeReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeReport));
            this.timeReportLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timeReportLabel
            // 
            this.timeReportLabel.BackColor = System.Drawing.Color.LightSlateGray;
            this.timeReportLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeReportLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.timeReportLabel.Location = new System.Drawing.Point(0, 0);
            this.timeReportLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.timeReportLabel.Name = "timeReportLabel";
            this.timeReportLabel.Size = new System.Drawing.Size(921, 53);
            this.timeReportLabel.TabIndex = 61;
            this.timeReportLabel.Text = "TIME MANAGEMENT REPORT";
            this.timeReportLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(921, 656);
            this.Controls.Add(this.timeReportLabel);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TimeReport";
            this.Text = "Time Management Report";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label timeReportLabel;
    }
}