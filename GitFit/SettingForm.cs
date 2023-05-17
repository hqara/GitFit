using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GitFit.UserDataSetTableAdapters;

namespace GitFit
{
    public partial class SettingForm : Form
    {
        public LoginForm login;

        public SettingForm()
        {
            InitializeComponent();
            /*
          * Hey Sarah, this is a test to changing pass, feel free to remove
          * if (login.loginUsername.Equals("hqara")) {

             this.testLabel.Text = "Old Password:" + GetPassword();
             SetPassword("test");
             this.testLabel.Text += "\nNew Password:"+GetPassword();
         }
         */

        }

        public SettingForm(LoginForm login, string username)
        {
            InitializeComponent();
            this.login = login;
            this.userLabel.Text = "Hello " + username;
            fNameLabel.Text = GetFirstName();
            lNameLabel.Text = GetLastName();
            DateTime dob = DateTime.Parse(GetDOB());
            DateTime now = DateTime.Now;
            int age = now.Year - dob.Year;
            age1Label.Text = age.ToString();
            email1Label.Text = GetEmail();
            phone1Label.Text = GetPhone();
            height1Label.Text = GetHeight();
            weight1Label.Text = GetWeight();
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
            userTableAdapter.setNewPhone(username, phone);
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

        private void homeLabel_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
            Visible = false;
        }

        private void activityLabel_Click(object sender, EventArgs e)
        {
            ActivityQuesionnaire a = new ActivityQuesionnaire();
            a.Show();
            Visible = false;
        }

        private void nutritionLabel_Click(object sender, EventArgs e)
        {
            NutritionQuestionnaire n = new NutritionQuestionnaire(login);
            n.Show();
            Visible = false;
        }

        private void historyLabel_Click(object sender, EventArgs e)
        {
            HistoryForm h = new HistoryForm(login);
            h.Show();
            Visible = false;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void updatePassword_Click(object sender, EventArgs e)
        {
            SetPassword(newPasswordTxt.Text);
            MessageBox.Show("Password has been changed successfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void updatePhone_Click(object sender, EventArgs e)
        {
            string phone = newPhoneTxt.Text.Trim();

            if (phone.Length != 10 || !phone.All(char.IsDigit))
            {
                MessageBox.Show("Please enter a valid 10-digit phone number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SetPhone(phone);
            MessageBox.Show("Phone has been changed successfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            phone1Label.Text = GetPhone();
        }

        private void updateEmail_Click(object sender, EventArgs e)
        {
            string email = newEmailTxt.Text;

            // Check if email contains '@'
            if (!email.Contains("@"))
            {
                MessageBox.Show("Invalid email address. Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Set email if valid
            SetEmail(email);
            MessageBox.Show("Email has been changed successfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            email1Label.Text = GetEmail();
        }


        private void updateHeight_Click(object sender, EventArgs e)
        {
            string height = newHeightTxt.Text.Trim();
            if (height.All(char.IsDigit))
            {
                SetHeight(decimal.Parse(height));
                MessageBox.Show("Height has been changed successfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                height1Label.Text = GetHeight();
            }
            else
            {
                MessageBox.Show("Please enter a valid height!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateWeight_Click(object sender, EventArgs e)
        {
            string weight = newWeightTxt.Text.Trim();
            if (weight.All(char.IsDigit))
            {
                SetWeight(decimal.Parse(weight));
                MessageBox.Show("Weight has been changed successfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                weight1Label.Text = GetWeight();
            }
            else
            {
                MessageBox.Show("Please enter a valid weight!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
