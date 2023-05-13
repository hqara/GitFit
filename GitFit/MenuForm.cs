using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GitFit
{
    public partial class MenuForm : Form
    {
        public LoginForm login; 
        public MenuForm(LoginForm login)
        {
            InitializeComponent();
            this.login = login;
            this.testLabel.Text = getLastNameByUsername();
            
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;
            base.OnFormClosing(e);
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }


        public string getLastNameByUsername()
        {
            string username = this.login.loginUsername;
            return userTableAdapter.getLastName(username).ToString();
        }



    }
}
