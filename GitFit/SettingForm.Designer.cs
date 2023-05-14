namespace GitFit
{
    partial class SettingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.settingLabel = new System.Windows.Forms.Label();
            this.activityLabel = new System.Windows.Forms.Label();
            this.historyLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nutritionLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.homeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.SteelBlue;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Left;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.homeLabel);
            this.splitContainer1.Panel1.Controls.Add(this.settingLabel);
            this.splitContainer1.Panel1.Controls.Add(this.activityLabel);
            this.splitContainer1.Panel1.Controls.Add(this.historyLabel);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.nutritionLabel);
            this.splitContainer1.Panel1.Controls.Add(this.userLabel);
            this.splitContainer1.Panel1.Controls.Add(this.logoutBtn);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Panel2Collapsed = true;
            this.splitContainer1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(249, 573);
            this.splitContainer1.SplitterDistance = 49;
            this.splitContainer1.TabIndex = 14;
            // 
            // settingLabel
            // 
            this.settingLabel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.settingLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingLabel.Location = new System.Drawing.Point(0, 411);
            this.settingLabel.Name = "settingLabel";
            this.settingLabel.Size = new System.Drawing.Size(253, 44);
            this.settingLabel.TabIndex = 17;
            this.settingLabel.Text = "Settings";
            this.settingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.settingLabel.Click += new System.EventHandler(this.settingLabel_Click);
            // 
            // activityLabel
            // 
            this.activityLabel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.activityLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityLabel.Location = new System.Drawing.Point(0, 247);
            this.activityLabel.Name = "activityLabel";
            this.activityLabel.Size = new System.Drawing.Size(253, 44);
            this.activityLabel.TabIndex = 14;
            this.activityLabel.Text = "Activity Questionnaire";
            this.activityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.activityLabel.Click += new System.EventHandler(this.activityLabel_Click);
            // 
            // historyLabel
            // 
            this.historyLabel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.historyLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyLabel.Location = new System.Drawing.Point(0, 357);
            this.historyLabel.Name = "historyLabel";
            this.historyLabel.Size = new System.Drawing.Size(253, 44);
            this.historyLabel.TabIndex = 16;
            this.historyLabel.Text = "History Report";
            this.historyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.historyLabel.Click += new System.EventHandler(this.historyLabel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // nutritionLabel
            // 
            this.nutritionLabel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.nutritionLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nutritionLabel.Location = new System.Drawing.Point(0, 302);
            this.nutritionLabel.Name = "nutritionLabel";
            this.nutritionLabel.Size = new System.Drawing.Size(253, 44);
            this.nutritionLabel.TabIndex = 15;
            this.nutritionLabel.Text = "Nutrition Questionnaire";
            this.nutritionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nutritionLabel.Click += new System.EventHandler(this.nutritionLabel_Click);
            // 
            // userLabel
            // 
            this.userLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.userLabel.Location = new System.Drawing.Point(0, 146);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(249, 39);
            this.userLabel.TabIndex = 13;
            this.userLabel.Text = "Hello User";
            this.userLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.logoutBtn.FlatAppearance.BorderSize = 5;
            this.logoutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.Location = new System.Drawing.Point(46, 488);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(4);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(155, 50);
            this.logoutBtn.TabIndex = 11;
            this.logoutBtn.Text = "Log Out";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // homeLabel
            // 
            this.homeLabel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.homeLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeLabel.Location = new System.Drawing.Point(0, 194);
            this.homeLabel.Name = "homeLabel";
            this.homeLabel.Size = new System.Drawing.Size(253, 44);
            this.homeLabel.TabIndex = 19;
            this.homeLabel.Text = "Home";
            this.homeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.homeLabel.Click += new System.EventHandler(this.homeLabel_Click);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(924, 573);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingForm";
            this.Text = "Settings";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label settingLabel;
        private System.Windows.Forms.Label activityLabel;
        private System.Windows.Forms.Label historyLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label nutritionLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Label homeLabel;
    }
}