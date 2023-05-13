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
        Signup signup;

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
            this.Username = usernameTextBox.Text;
            this.Password = passwordTextBox.Text;

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
            FillInForm fill = new FillInForm(this);
            this.Username = usernameTextBox.Text;
            this.Password = passwordTextBox.Text;
            fill.Show();
            Visible = false;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NutritionQuestionnaire r = new NutritionQuestionnaire();
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
