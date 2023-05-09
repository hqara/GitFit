namespace GitFit
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLoginTxt = new System.Windows.Forms.TextBox();
            this.passwordLoginTxt = new System.Windows.Forms.TextBox();
            this.showPasswordLoginCheckBox = new System.Windows.Forms.CheckBox();
            this.backToRegister = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.exitLoginBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 594);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 329);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 116);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lifestyle Management\r\n System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(63, 78);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 280);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(471, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Log In";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(462, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(462, 242);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(116, 27);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password";
            this.passwordLabel.Visible = false;
            // 
            // usernameLoginTxt
            // 
            this.usernameLoginTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLoginTxt.Location = new System.Drawing.Point(462, 176);
            this.usernameLoginTxt.Margin = new System.Windows.Forms.Padding(4);
            this.usernameLoginTxt.Name = "usernameLoginTxt";
            this.usernameLoginTxt.Size = new System.Drawing.Size(306, 27);
            this.usernameLoginTxt.TabIndex = 4;
            this.usernameLoginTxt.TextChanged += new System.EventHandler(this.usernameLoginTxt_TextChanged);
            // 
            // passwordLoginTxt
            // 
            this.passwordLoginTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLoginTxt.Location = new System.Drawing.Point(462, 279);
            this.passwordLoginTxt.Margin = new System.Windows.Forms.Padding(4);
            this.passwordLoginTxt.Name = "passwordLoginTxt";
            this.passwordLoginTxt.Size = new System.Drawing.Size(306, 27);
            this.passwordLoginTxt.TabIndex = 5;
            this.passwordLoginTxt.UseSystemPasswordChar = true;
            this.passwordLoginTxt.Visible = false;
            // 
            // showPasswordLoginCheckBox
            // 
            this.showPasswordLoginCheckBox.AutoSize = true;
            this.showPasswordLoginCheckBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPasswordLoginCheckBox.Location = new System.Drawing.Point(462, 341);
            this.showPasswordLoginCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.showPasswordLoginCheckBox.Name = "showPasswordLoginCheckBox";
            this.showPasswordLoginCheckBox.Size = new System.Drawing.Size(135, 23);
            this.showPasswordLoginCheckBox.TabIndex = 6;
            this.showPasswordLoginCheckBox.Text = "Show Password";
            this.showPasswordLoginCheckBox.UseVisualStyleBackColor = true;
            this.showPasswordLoginCheckBox.Visible = false;
            this.showPasswordLoginCheckBox.CheckedChanged += new System.EventHandler(this.showPasswordLoginCheckBox_CheckedChanged);
            // 
            // backToRegister
            // 
            this.backToRegister.AutoSize = true;
            this.backToRegister.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.backToRegister.Location = new System.Drawing.Point(493, 403);
            this.backToRegister.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.backToRegister.Name = "backToRegister";
            this.backToRegister.Size = new System.Drawing.Size(245, 19);
            this.backToRegister.TabIndex = 7;
            this.backToRegister.Text = "Don\'t Have an Account? REGISTER";
            this.backToRegister.Click += new System.EventHandler(this.backToRegister_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.loginBtn.FlatAppearance.BorderSize = 5;
            this.loginBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(469, 450);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(4);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(112, 59);
            this.loginBtn.TabIndex = 9;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Visible = false;
            // 
            // exitLoginBtn
            // 
            this.exitLoginBtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.exitLoginBtn.FlatAppearance.BorderSize = 5;
            this.exitLoginBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.exitLoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitLoginBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLoginBtn.ForeColor = System.Drawing.Color.White;
            this.exitLoginBtn.Location = new System.Drawing.Point(656, 450);
            this.exitLoginBtn.Margin = new System.Windows.Forms.Padding(4);
            this.exitLoginBtn.Name = "exitLoginBtn";
            this.exitLoginBtn.Size = new System.Drawing.Size(112, 59);
            this.exitLoginBtn.TabIndex = 10;
            this.exitLoginBtn.Text = "Exit";
            this.exitLoginBtn.UseVisualStyleBackColor = false;
            this.exitLoginBtn.Click += new System.EventHandler(this.exitLoginBtn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(854, 592);
            this.Controls.Add(this.exitLoginBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.backToRegister);
            this.Controls.Add(this.showPasswordLoginCheckBox);
            this.Controls.Add(this.passwordLoginTxt);
            this.Controls.Add(this.usernameLoginTxt);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usernameLoginTxt;
        private System.Windows.Forms.TextBox passwordLoginTxt;
        private System.Windows.Forms.CheckBox showPasswordLoginCheckBox;
        private System.Windows.Forms.Label backToRegister;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button exitLoginBtn;
    }
}