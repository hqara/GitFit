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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;
            base.OnFormClosing(e);
        }

        private void backToRegister_Click(object sender, EventArgs e)
        {
            Signup m = new Signup();
            m.Show();
            Visible = false;
        }

        private void showPasswordLoginCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordLoginCheckBox.Checked)
            {
                passwordLoginTxt.UseSystemPasswordChar = false;
            }
            else { 
                passwordLoginTxt.UseSystemPasswordChar = true;
            }
        }

        private void usernameLoginTxt_TextChanged(object sender, EventArgs e)
        {
            if (usernameLoginTxt.Text.Length > 0)
            {
                passwordLabel.Visible= true;
                passwordLoginTxt.Visible = true;
                showPasswordLoginCheckBox.Visible = true;
                loginBtn.Visible = true;
            }
        }

        private void exitLoginBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }
    }
}
