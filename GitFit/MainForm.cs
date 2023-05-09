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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        //comment sadaf
        //second test comment
        //comment 3
        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckBox.Checked)
            {
                passwordTxt.UseSystemPasswordChar = false;
                confirmPasswordTxt.UseSystemPasswordChar = false;
            }
            else {
                //
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
    }
}
