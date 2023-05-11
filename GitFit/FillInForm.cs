using GitFit.UserDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GitFit
{
    public partial class FillInForm : Form
    {
        private Signup signup;
        UserTableAdapter adapt;

        public FillInForm(Signup signup)
        {
            InitializeComponent();
            this.signup = signup;
            this.adapt= new UserTableAdapter();
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
            try {

               
                string username = signup.Username;
                string password = signup.Password;
                string fname = firstNameTextBox.Text;
                string lname = lastNameTextBox.Text;
                string dob = dateOfBirthTimePicker.Text;
                string email = emailTextBox.Text;
                string phone = phoneTextBox.Text;
                char gender = maleRadioButton.Checked ? 'M' : 'F';
                string genderstr = gender.ToString();
                decimal height = heightNumericUpDown.Value;
                decimal weight = weightNumericUpDown.Value;

                this.adapt.InsertNewUser(username, password, fname, lname, dob, email, phone, genderstr, height, weight);
                //this.adapt.Fill(UserDataSet.UserDataTable);
                MessageBox.Show("User Registration Completed.", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
               MessageBox.Show("Please ensure that all fields\nin the form are filled out\nbefore submitting.", "Registration Failed.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
