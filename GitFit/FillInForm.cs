using GitFit.UserDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitFit
{
    public partial class FillInForm : Form
    {
        private Signup signup;
      

        public FillInForm(Signup signup)
        {
            InitializeComponent();
            this.signup = signup;
        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;
            base.OnFormClosing(e);
        }

        private void exitFillBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you certain that you want to \nlose your registration information?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
                Application.Exit();
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string username = signup.Username;
                string password = signup.Password;
                string fname = firstNameTextBox.Text;
                string lname = lastNameTextBox.Text;
                DateTime dob = dateOfBirthTimePicker.Value;
                string dobStr = dob.ToString("yyyy-MM-dd");
                string email = emailTextBox.Text;
                string phone = phoneTextBox.Text;
                string gender = maleRadioButton.Checked ? "M" : "F";
                decimal height = heightNumericUpDown.Value;
                decimal weight = weightNumericUpDown.Value;
                this.userTableAdapter.Insert(username, password, fname, lname, dob, email, phone, gender, height, weight);
                this.userTableAdapter.Fill(this.userDataSet.User);
                MessageBox.Show("User Registration Completed.", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Registration failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.userDataSet);

        }

        private void FillInForm_Load(object sender, EventArgs e)
        {
           
            this.userTableAdapter.Fill(this.userDataSet.User);

        }
    }
}
