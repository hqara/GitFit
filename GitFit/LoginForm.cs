using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        private void usernameLoginTxt_TextChanged(object sender, EventArgs e) { 

            string username = usernameLoginTxt.Text;
            int registered = (int)userTableAdapter.LoginRegisteredUsername(username);
        
             if (registered == 1)
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

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameLoginTxt.Text;
            string password = passwordLoginTxt.Text;

            int registered = (int)userTableAdapter.LoginCompleteValidation(username, password);

            if (registered == 1)
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MenuForm dashboard = new MenuForm();
                dashboard.Show();
                this.Visible = false;

            }
            else
            {
                MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
          
        }

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.userDataSet);

        }

    }
}
