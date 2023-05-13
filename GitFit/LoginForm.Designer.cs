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
            this.components = new System.ComponentModel.Container();
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
            this.userDataSet = new GitFit.UserDataSet();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new GitFit.UserDataSetTableAdapters.UserTableAdapter();
            this.tableAdapterManager = new GitFit.UserDataSetTableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
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
            this.label3.Size = new System.Drawing.Size(178, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(462, 242);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(178, 27);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password";
            this.passwordLabel.Visible = false;
            // 
            // usernameLoginTxt
            // 
            this.usernameLoginTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLoginTxt.Location = new System.Drawing.Point(462, 176);
            this.usernameLoginTxt.Margin = new System.Windows.Forms.Padding(4);
            this.usernameLoginTxt.Name = "usernameLoginTxt";
            this.usernameLoginTxt.Size = new System.Drawing.Size(338, 32);
            this.usernameLoginTxt.TabIndex = 4;
            this.usernameLoginTxt.TextChanged += new System.EventHandler(this.usernameLoginTxt_TextChanged);
            // 
            // passwordLoginTxt
            // 
            this.passwordLoginTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLoginTxt.Location = new System.Drawing.Point(462, 279);
            this.passwordLoginTxt.Margin = new System.Windows.Forms.Padding(4);
            this.passwordLoginTxt.Name = "passwordLoginTxt";
            this.passwordLoginTxt.Size = new System.Drawing.Size(330, 32);
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
            this.backToRegister.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.backToRegister.Location = new System.Drawing.Point(462, 405);
            this.backToRegister.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.backToRegister.Name = "backToRegister";
            this.backToRegister.Size = new System.Drawing.Size(330, 30);
            this.backToRegister.TabIndex = 7;
            this.backToRegister.Text = "Don\'t Have an Account? REGISTER";
            this.backToRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.loginBtn.Location = new System.Drawing.Point(462, 460);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(4);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(112, 59);
            this.loginBtn.TabIndex = 9;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Visible = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // exitLoginBtn
            // 
            this.exitLoginBtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.exitLoginBtn.FlatAppearance.BorderSize = 5;
            this.exitLoginBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.exitLoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitLoginBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLoginBtn.ForeColor = System.Drawing.Color.White;
            this.exitLoginBtn.Location = new System.Drawing.Point(680, 460);
            this.exitLoginBtn.Margin = new System.Windows.Forms.Padding(4);
            this.exitLoginBtn.Name = "exitLoginBtn";
            this.exitLoginBtn.Size = new System.Drawing.Size(112, 59);
            this.exitLoginBtn.TabIndex = 10;
            this.exitLoginBtn.Text = "Exit";
            this.exitLoginBtn.UseVisualStyleBackColor = false;
            this.exitLoginBtn.Click += new System.EventHandler(this.exitLoginBtn_Click);
            // 
            // userDataSet
            // 
            this.userDataSet.DataSetName = "UserDataSet";
            this.userDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.userDataSet;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = GitFit.UserDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = this.userTableAdapter;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "username";
            this.dataGridViewTextBoxColumn1.HeaderText = "username";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "password";
            this.dataGridViewTextBoxColumn2.HeaderText = "password";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "fname";
            this.dataGridViewTextBoxColumn3.HeaderText = "fname";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "lname";
            this.dataGridViewTextBoxColumn4.HeaderText = "lname";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "dob";
            this.dataGridViewTextBoxColumn5.HeaderText = "dob";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn6.HeaderText = "email";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "phone";
            this.dataGridViewTextBoxColumn7.HeaderText = "phone";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "gender";
            this.dataGridViewTextBoxColumn8.HeaderText = "gender";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "height";
            this.dataGridViewTextBoxColumn9.HeaderText = "height";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "weight";
            this.dataGridViewTextBoxColumn10.HeaderText = "weight";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(858, 588);
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
            this.Text = "Git Fit Application";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
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
        private UserDataSet userDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private UserDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private UserDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}