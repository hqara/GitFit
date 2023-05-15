using GitFit.UserDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace GitFit
{
    public partial class Signup : Form
    {
        public Signup signup;
        public NutritionFollowUp r;

        public string Username { get; set; } 
        public string Password { get; set; } 
        public Signup()
        {
            InitializeComponent();
            this.signup = this;
            this.Username = usernameTextBox.Text;
            this.Password = passwordTextBox.Text;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;
            base.OnFormClosing(e);
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckBox.Checked)
            {
                passwordTextBox.UseSystemPasswordChar = false;
                confirmPasswordTextBox.UseSystemPasswordChar = false;
            }
            else {
                
                passwordTextBox.UseSystemPasswordChar = true;
                confirmPasswordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void backToLogin_Click(object sender, EventArgs e)
        { 

            LoginForm login = new LoginForm();
            login.Show();
            this.Visible = false;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string confirmPassword = confirmPasswordTextBox.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please enter a username and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!password.Equals(confirmPassword))
            {
                MessageBox.Show("The passwords you entered do not match.\nPlease try again.", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (userTableAdapter.LoginRegisteredUsername(username) == 1)
            {
                MessageBox.Show("This username is already taken.\nPlease choose a different username.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FillInForm fill = new FillInForm(this);
                this.Username = username;
                this.Password = password;
                fill.Show();
                Visible = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MenuForm r = new MenuForm();
            //NutritionReport r = new NutritionReport();
            //NutritionFollowUpQuestionnaire r = new NutritionFollowUpQuestionnaire();
            FoodChoices[] foodContainer = r.foodContainer; 
            r = new NutritionFollowUp(foodContainer);
            r.Show();
            Visible= false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActivityQuesionnaire a = new ActivityQuesionnaire();
            a.Show();
            Visible = false;
        }

    }
}
