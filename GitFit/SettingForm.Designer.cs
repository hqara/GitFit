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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.homeLabel = new System.Windows.Forms.Label();
            this.settingLabel = new System.Windows.Forms.Label();
            this.activityLabel = new System.Windows.Forms.Label();
            this.historyLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nutritionLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.userDataSet = new GitFit.UserDataSet();
            this.userTableAdapter = new GitFit.UserDataSetTableAdapters.UserTableAdapter();
            this.tableAdapterManager = new GitFit.UserDataSetTableAdapters.TableAdapterManager();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.weight1Label = new System.Windows.Forms.Label();
            this.height1Label = new System.Windows.Forms.Label();
            this.phone1Label = new System.Windows.Forms.Label();
            this.email1Label = new System.Windows.Forms.Label();
            this.age1Label = new System.Windows.Forms.Label();
            this.lNameLabel = new System.Windows.Forms.Label();
            this.fNameLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.updateWeight = new System.Windows.Forms.Button();
            this.updateHeight = new System.Windows.Forms.Button();
            this.updateEmail = new System.Windows.Forms.Button();
            this.updatePhone = new System.Windows.Forms.Button();
            this.updatePassword = new System.Windows.Forms.Button();
            this.newWeightTxt = new System.Windows.Forms.TextBox();
            this.newHeightTxt = new System.Windows.Forms.TextBox();
            this.newEmailTxt = new System.Windows.Forms.TextBox();
            this.newPhoneTxt = new System.Windows.Forms.TextBox();
            this.newPasswordTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.userLabel.Text = "Hello";
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
            // userDataSet
            // 
            this.userDataSet.DataSetName = "UserDataSet";
            this.userDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GitFit.UserDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = this.userTableAdapter;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.userDataSet;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.weight1Label);
            this.groupBox1.Controls.Add(this.height1Label);
            this.groupBox1.Controls.Add(this.phone1Label);
            this.groupBox1.Controls.Add(this.email1Label);
            this.groupBox1.Controls.Add(this.age1Label);
            this.groupBox1.Controls.Add(this.lNameLabel);
            this.groupBox1.Controls.Add(this.fNameLabel);
            this.groupBox1.Controls.Add(this.weightLabel);
            this.groupBox1.Controls.Add(this.heightLabel);
            this.groupBox1.Controls.Add(this.phoneLabel);
            this.groupBox1.Controls.Add(this.emailLabel);
            this.groupBox1.Controls.Add(this.ageLabel);
            this.groupBox1.Controls.Add(this.lastNameLabel);
            this.groupBox1.Controls.Add(this.firstNameLabel);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(255, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(723, 264);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Profile Summary";
            // 
            // weight1Label
            // 
            this.weight1Label.AutoSize = true;
            this.weight1Label.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weight1Label.Location = new System.Drawing.Point(450, 215);
            this.weight1Label.Name = "weight1Label";
            this.weight1Label.Size = new System.Drawing.Size(60, 21);
            this.weight1Label.TabIndex = 46;
            this.weight1Label.Text = "label7";
            // 
            // height1Label
            // 
            this.height1Label.AutoSize = true;
            this.height1Label.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.height1Label.Location = new System.Drawing.Point(161, 215);
            this.height1Label.Name = "height1Label";
            this.height1Label.Size = new System.Drawing.Size(60, 21);
            this.height1Label.TabIndex = 45;
            this.height1Label.Text = "label6";
            // 
            // phone1Label
            // 
            this.phone1Label.AutoSize = true;
            this.phone1Label.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone1Label.Location = new System.Drawing.Point(409, 152);
            this.phone1Label.Name = "phone1Label";
            this.phone1Label.Size = new System.Drawing.Size(60, 21);
            this.phone1Label.TabIndex = 44;
            this.phone1Label.Text = "label5";
            // 
            // email1Label
            // 
            this.email1Label.AutoSize = true;
            this.email1Label.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email1Label.Location = new System.Drawing.Point(17, 161);
            this.email1Label.Name = "email1Label";
            this.email1Label.Size = new System.Drawing.Size(60, 21);
            this.email1Label.TabIndex = 43;
            this.email1Label.Text = "label4";
            // 
            // age1Label
            // 
            this.age1Label.AutoSize = true;
            this.age1Label.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age1Label.Location = new System.Drawing.Point(596, 73);
            this.age1Label.Name = "age1Label";
            this.age1Label.Size = new System.Drawing.Size(60, 21);
            this.age1Label.TabIndex = 42;
            this.age1Label.Text = "label3";
            // 
            // lNameLabel
            // 
            this.lNameLabel.AutoSize = true;
            this.lNameLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNameLabel.Location = new System.Drawing.Point(312, 73);
            this.lNameLabel.Name = "lNameLabel";
            this.lNameLabel.Size = new System.Drawing.Size(60, 21);
            this.lNameLabel.TabIndex = 41;
            this.lNameLabel.Text = "label2";
            // 
            // fNameLabel
            // 
            this.fNameLabel.AutoSize = true;
            this.fNameLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameLabel.Location = new System.Drawing.Point(17, 77);
            this.fNameLabel.Name = "fNameLabel";
            this.fNameLabel.Size = new System.Drawing.Size(60, 21);
            this.fNameLabel.TabIndex = 40;
            this.fNameLabel.Text = "label1";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightLabel.Location = new System.Drawing.Point(338, 215);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(106, 21);
            this.weightLabel.TabIndex = 27;
            this.weightLabel.Text = "Weight (lb):";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightLabel.Location = new System.Drawing.Point(17, 215);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(138, 21);
            this.heightLabel.TabIndex = 26;
            this.heightLabel.Text = "Height (inches):";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(409, 121);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(143, 21);
            this.phoneLabel.TabIndex = 24;
            this.phoneLabel.Text = "Phone Number: ";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(17, 121);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(62, 21);
            this.emailLabel.TabIndex = 23;
            this.emailLabel.Text = "Email: ";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageLabel.Location = new System.Drawing.Point(596, 35);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(55, 21);
            this.ageLabel.TabIndex = 22;
            this.ageLabel.Text = "Age: ";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(312, 35);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(110, 21);
            this.lastNameLabel.TabIndex = 21;
            this.lastNameLabel.Text = "Last Name: ";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(17, 35);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(106, 21);
            this.firstNameLabel.TabIndex = 20;
            this.firstNameLabel.Text = "First Name: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.updateWeight);
            this.groupBox2.Controls.Add(this.updateHeight);
            this.groupBox2.Controls.Add(this.updateEmail);
            this.groupBox2.Controls.Add(this.updatePhone);
            this.groupBox2.Controls.Add(this.updatePassword);
            this.groupBox2.Controls.Add(this.newWeightTxt);
            this.groupBox2.Controls.Add(this.newHeightTxt);
            this.groupBox2.Controls.Add(this.newEmailTxt);
            this.groupBox2.Controls.Add(this.newPhoneTxt);
            this.groupBox2.Controls.Add(this.newPasswordTxt);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(255, 282);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(723, 282);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Change Profile";
            // 
            // updateWeight
            // 
            this.updateWeight.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateWeight.Location = new System.Drawing.Point(552, 219);
            this.updateWeight.Name = "updateWeight";
            this.updateWeight.Size = new System.Drawing.Size(120, 30);
            this.updateWeight.TabIndex = 53;
            this.updateWeight.Text = "Update";
            this.updateWeight.UseVisualStyleBackColor = true;
            this.updateWeight.Click += new System.EventHandler(this.updateWeight_Click);
            // 
            // updateHeight
            // 
            this.updateHeight.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateHeight.Location = new System.Drawing.Point(552, 177);
            this.updateHeight.Name = "updateHeight";
            this.updateHeight.Size = new System.Drawing.Size(120, 30);
            this.updateHeight.TabIndex = 52;
            this.updateHeight.Text = "Update";
            this.updateHeight.UseVisualStyleBackColor = true;
            this.updateHeight.Click += new System.EventHandler(this.updateHeight_Click);
            // 
            // updateEmail
            // 
            this.updateEmail.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateEmail.Location = new System.Drawing.Point(552, 132);
            this.updateEmail.Name = "updateEmail";
            this.updateEmail.Size = new System.Drawing.Size(120, 30);
            this.updateEmail.TabIndex = 51;
            this.updateEmail.Text = "Update";
            this.updateEmail.UseVisualStyleBackColor = true;
            this.updateEmail.Click += new System.EventHandler(this.updateEmail_Click);
            // 
            // updatePhone
            // 
            this.updatePhone.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePhone.Location = new System.Drawing.Point(552, 84);
            this.updatePhone.Name = "updatePhone";
            this.updatePhone.Size = new System.Drawing.Size(120, 30);
            this.updatePhone.TabIndex = 50;
            this.updatePhone.Text = "Update";
            this.updatePhone.UseVisualStyleBackColor = true;
            this.updatePhone.Click += new System.EventHandler(this.updatePhone_Click);
            // 
            // updatePassword
            // 
            this.updatePassword.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePassword.Location = new System.Drawing.Point(552, 42);
            this.updatePassword.Name = "updatePassword";
            this.updatePassword.Size = new System.Drawing.Size(120, 30);
            this.updatePassword.TabIndex = 49;
            this.updatePassword.Text = "Update";
            this.updatePassword.UseVisualStyleBackColor = true;
            this.updatePassword.Click += new System.EventHandler(this.updatePassword_Click);
            // 
            // newWeightTxt
            // 
            this.newWeightTxt.Location = new System.Drawing.Point(236, 221);
            this.newWeightTxt.Name = "newWeightTxt";
            this.newWeightTxt.Size = new System.Drawing.Size(261, 30);
            this.newWeightTxt.TabIndex = 48;
            // 
            // newHeightTxt
            // 
            this.newHeightTxt.Location = new System.Drawing.Point(236, 177);
            this.newHeightTxt.Name = "newHeightTxt";
            this.newHeightTxt.Size = new System.Drawing.Size(261, 30);
            this.newHeightTxt.TabIndex = 47;
            // 
            // newEmailTxt
            // 
            this.newEmailTxt.Location = new System.Drawing.Point(236, 132);
            this.newEmailTxt.Name = "newEmailTxt";
            this.newEmailTxt.Size = new System.Drawing.Size(261, 30);
            this.newEmailTxt.TabIndex = 46;
            // 
            // newPhoneTxt
            // 
            this.newPhoneTxt.Location = new System.Drawing.Point(236, 85);
            this.newPhoneTxt.Name = "newPhoneTxt";
            this.newPhoneTxt.Size = new System.Drawing.Size(261, 30);
            this.newPhoneTxt.TabIndex = 45;
            // 
            // newPasswordTxt
            // 
            this.newPasswordTxt.Location = new System.Drawing.Point(236, 42);
            this.newPasswordTxt.Name = "newPasswordTxt";
            this.newPasswordTxt.Size = new System.Drawing.Size(261, 30);
            this.newPasswordTxt.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 21);
            this.label4.TabIndex = 43;
            this.label4.Text = "Enter New Height (in):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 21);
            this.label7.TabIndex = 40;
            this.label7.Text = "Enter New Phone:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(196, 21);
            this.label9.TabIndex = 26;
            this.label9.Text = "Enter New Weight (lb):";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(21, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 21);
            this.label11.TabIndex = 23;
            this.label11.Text = "Enter New Email:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(21, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(183, 21);
            this.label14.TabIndex = 20;
            this.label14.Text = "Enter New Password:";
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(990, 573);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingForm";
            this.Text = "Settings";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private UserDataSet userDataSet;
        private UserDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private UserDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label phone1Label;
        private System.Windows.Forms.Label email1Label;
        private System.Windows.Forms.Label age1Label;
        private System.Windows.Forms.Label lNameLabel;
        private System.Windows.Forms.Label fNameLabel;
        private System.Windows.Forms.Label weight1Label;
        private System.Windows.Forms.Label height1Label;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button updateWeight;
        private System.Windows.Forms.Button updateHeight;
        private System.Windows.Forms.Button updateEmail;
        private System.Windows.Forms.Button updatePhone;
        private System.Windows.Forms.Button updatePassword;
        private System.Windows.Forms.TextBox newWeightTxt;
        private System.Windows.Forms.TextBox newHeightTxt;
        private System.Windows.Forms.TextBox newEmailTxt;
        private System.Windows.Forms.TextBox newPhoneTxt;
        private System.Windows.Forms.TextBox newPasswordTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
    }
}