using GitFit.UserDataSetTableAdapters;
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
        public MenuForm(LoginForm login, string username)
        {
            InitializeComponent();
            this.login = login;
            /*
             * Hey Sarah, this is a test to changing pass, feel free to remove
             * if (login.loginUsername.Equals("hqara")) {

                this.testLabel.Text = "Old Password:" + GetPassword();
                SetPassword("test");
                this.testLabel.Text += "\nNew Password:"+GetPassword();
            }
            */
           
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

        public string GetPassword()
        {
            string username = this.login.loginUsername;
            UserDataSet.UserDataTable userTable = new UserTableAdapter().getDataByUsername(username);
            if (userTable.Rows.Count > 0)
            {
                string lastName = userTable.Rows[0]["password"].ToString();
                return lastName;
            }
            return null;
        }

        public string GetFirstName()
        {
            string username = this.login.loginUsername;
            UserDataSet.UserDataTable userTable = new UserTableAdapter().getDataByUsername(username);
            if (userTable.Rows.Count > 0)
            {
                string lastName = userTable.Rows[0]["fname"].ToString();
                return lastName;
            }
            return null;
        }

        public string GetLastName()
        {
            string username = this.login.loginUsername;
            UserDataSet.UserDataTable userTable = new UserTableAdapter().getDataByUsername(username);
            if (userTable.Rows.Count > 0)
            {
                string lastName = userTable.Rows[0]["lname"].ToString();
                return lastName;
            }
            return null;
        }

        public string GetDOB()
        {
            string username = this.login.loginUsername;
            UserDataSet.UserDataTable userTable = new UserTableAdapter().getDataByUsername(username);
            if (userTable.Rows.Count > 0)
            {
                string dob = userTable.Rows[0]["dob"].ToString();
                return dob;
            }
            return null;
        }

        public string GetEmail()
        {
            string username = this.login.loginUsername;
            UserDataSet.UserDataTable userTable = new UserTableAdapter().getDataByUsername(username);
            if (userTable.Rows.Count > 0)
            {
                string dob = userTable.Rows[0]["email"].ToString();
                return dob;
            }
            return null;
        }

        public string GetPhone()
        {
            string username = this.login.loginUsername;
            UserDataSet.UserDataTable userTable = new UserTableAdapter().getDataByUsername(username);
            if (userTable.Rows.Count > 0)
            {
                string dob = userTable.Rows[0]["phone"].ToString();
                return dob;
            }
            return null;
        }

        public string GetGender()
        {
            string username = this.login.loginUsername;
            UserDataSet.UserDataTable userTable = new UserTableAdapter().getDataByUsername(username);
            if (userTable.Rows.Count > 0)
            {
                string dob = userTable.Rows[0]["gender"].ToString();
                return dob;
            }
            return null;
        }

        public string GetHeight()
        {
            string username = this.login.loginUsername;
            UserDataSet.UserDataTable userTable = new UserTableAdapter().getDataByUsername(username);
            if (userTable.Rows.Count > 0)
            {
                string dob = userTable.Rows[0]["height"].ToString();
                return dob;
            }
            return null;
        }
        public string GetWeight()
        {
            string username = this.login.loginUsername;
            UserDataSet.UserDataTable userTable = new UserTableAdapter().getDataByUsername(username);
            if (userTable.Rows.Count > 0)
            {
                string dob = userTable.Rows[0]["weight"].ToString();
                return dob;
            }
            return null;
        }

        public void SetPassword(string password)
        {
            string username = this.login.loginUsername;
            userTableAdapter.setNewPassword(username, password);
        }

        public void SetEmail(string email)
        {
            string username = this.login.loginUsername;
            userTableAdapter.setNewEmail(username, email);
        }

        public void SetPhone(string phone)
        {
            string username = this.login.loginUsername;
            userTableAdapter.setNewPhone(username,phone);
        }

        public void SetHeight(decimal height)
        {
            string username = this.login.loginUsername;
            userTableAdapter.setNewHeight(username, height);
        }

        public void SetWeight(decimal weight)
        {
            string username = this.login.loginUsername;
            userTableAdapter.setNewWeight(username, weight);
        }
    }
}
