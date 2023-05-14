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

            int registered = (int)userTableAdapter.LoginRegisteredUsername(username);

            if (passwordTextBox.Text.Equals(confirmPasswordTextBox.Text) && registered==0)
            {
                
                FillInForm fill = new FillInForm(this);
                this.Username = usernameTextBox.Text;
                this.Password = passwordTextBox.Text;
                fill.Show();
                Visible = false;
            }
            else if (!passwordTextBox.Text.Equals(confirmPasswordTextBox.Text)) {

                MessageBox.Show("The passwords you entered do not match.\nPlease try again.", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (registered == 1) {

                MessageBox.Show("This username is already taken.\nPlease choose a different\nusername.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MenuForm r = new MenuForm();
            NutritionReport r = new NutritionReport();
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
