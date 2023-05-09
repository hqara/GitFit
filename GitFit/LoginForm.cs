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
            //test delete later
        }

        private void backToRegister_Click(object sender, EventArgs e)
        {
            MainForm m = new MainForm();
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
    }
}
