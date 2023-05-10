using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GitFit
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
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
                passwordTxt.UseSystemPasswordChar = false;
                confirmPasswordTxt.UseSystemPasswordChar = false;
            }
            else {
                
                passwordTxt.UseSystemPasswordChar = true;
                confirmPasswordTxt.UseSystemPasswordChar = true;
            }
        }

        private void backToLogin_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            Visible = false;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            FillInForm fill = new FillInForm();
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
