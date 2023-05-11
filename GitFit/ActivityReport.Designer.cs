namespace GitFit
{
    partial class ActivityReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivityReport));
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitBtn = new System.Windows.Forms.Button();
            this.nutritionReportLabel = new System.Windows.Forms.Label();
            this.currentLevelLbl = new System.Windows.Forms.Label();
            this.ReportrichTextBox = new System.Windows.Forms.RichTextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.webBrowser3 = new System.Windows.Forms.WebBrowser();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.exitBtn);
            this.panel1.Controls.Add(this.nutritionReportLabel);
            this.panel1.Location = new System.Drawing.Point(14, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1181, 66);
            this.panel1.TabIndex = 84;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.exitBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.exitBtn.FlatAppearance.BorderSize = 5;
            this.exitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.Transparent;
            this.exitBtn.Location = new System.Drawing.Point(1072, 2);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(103, 59);
            this.exitBtn.TabIndex = 80;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click_1);
            // 
            // nutritionReportLabel
            // 
            this.nutritionReportLabel.BackColor = System.Drawing.Color.Transparent;
            this.nutritionReportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nutritionReportLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.nutritionReportLabel.Location = new System.Drawing.Point(5, 7);
            this.nutritionReportLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.nutritionReportLabel.Name = "nutritionReportLabel";
            this.nutritionReportLabel.Size = new System.Drawing.Size(1170, 50);
            this.nutritionReportLabel.TabIndex = 59;
            this.nutritionReportLabel.Text = "ACTIVE LIFESTYLE REPORT";
            this.nutritionReportLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentLevelLbl
            // 
            this.currentLevelLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentLevelLbl.Location = new System.Drawing.Point(4, 70);
            this.currentLevelLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.currentLevelLbl.Name = "currentLevelLbl";
            this.currentLevelLbl.Size = new System.Drawing.Size(1191, 61);
            this.currentLevelLbl.TabIndex = 85;
            this.currentLevelLbl.Text = "Current Activity Level: \r\nScore";
            this.currentLevelLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReportrichTextBox
            // 
            this.ReportrichTextBox.Location = new System.Drawing.Point(14, 134);
            this.ReportrichTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReportrichTextBox.Name = "ReportrichTextBox";
            this.ReportrichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.ReportrichTextBox.Size = new System.Drawing.Size(593, 697);
            this.ReportrichTextBox.TabIndex = 86;
            this.ReportrichTextBox.Text = "";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(641, 134);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(18, 16);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(554, 200);
            this.webBrowser1.TabIndex = 87;
            this.webBrowser1.Url = new System.Uri("https://www.who.int/news-room/fact-sheets/detail/physical-activity", System.UriKind.Absolute);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // webBrowser2
            // 
            this.webBrowser2.Location = new System.Drawing.Point(641, 365);
            this.webBrowser2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(18, 16);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.ScriptErrorsSuppressed = true;
            this.webBrowser2.Size = new System.Drawing.Size(554, 200);
            this.webBrowser2.TabIndex = 88;
            this.webBrowser2.Url = new System.Uri("https://www.who.int/publications/i/item/9789241599979", System.UriKind.Absolute);
            // 
            // webBrowser3
            // 
            this.webBrowser3.Location = new System.Drawing.Point(641, 597);
            this.webBrowser3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.webBrowser3.MinimumSize = new System.Drawing.Size(18, 16);
            this.webBrowser3.Name = "webBrowser3";
            this.webBrowser3.ScriptErrorsSuppressed = true;
            this.webBrowser3.Size = new System.Drawing.Size(554, 200);
            this.webBrowser3.TabIndex = 89;
            this.webBrowser3.Url = new System.Uri("https://www.who.int/publications/i/item/9241592222", System.UriKind.Absolute);
            // 
            // ActivityReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1208, 840);
            this.Controls.Add(this.webBrowser3);
            this.Controls.Add(this.webBrowser2);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.ReportrichTextBox);
            this.Controls.Add(this.currentLevelLbl);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ActivityReport";
            this.Text = "ActivityReport";
            this.Load += new System.EventHandler(this.ActivityReport_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label nutritionReportLabel;
        private System.Windows.Forms.Label currentLevelLbl;
        private System.Windows.Forms.RichTextBox ReportrichTextBox;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.WebBrowser webBrowser3;
    }
}