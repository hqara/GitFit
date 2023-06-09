﻿using GitFit.UserDataSetTableAdapters;
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
        public Signup signup;
        public LoginForm login;
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

        private void returnFillBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            signup.Show();
            signup.Visible = true;

            /*
             * DialogResult result = MessageBox.Show("Are you sure you want to leave?\nYour registration information will be lost.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    this.Visible = false;
                    signup.Show();
                    signup.Visible = true;
                }
                else
                {   //Do nothing
                    return;
                } 
            */

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(firstNameTextBox.Text) || string.IsNullOrWhiteSpace(lastNameTextBox.Text) ||
                (!maleRadioButton.Checked && !femaleRadioButton.Checked) || heightNumericUpDown.Value == 0 ||
                weightNumericUpDown.Value == 0)
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string username = signup.Username;
                    string password = signup.Password;
                    string fname = firstNameTextBox.Text;
                    string lname = lastNameTextBox.Text;
                    string dobStr = dateOfBirthTimePicker.Value.ToString("yyyy-MM-dd");
                    string email = emailTextBox.Text;
                    string phone = phoneTextBox.Text;
                    string gender = maleRadioButton.Checked ? "M" : "F";
                    decimal height = heightNumericUpDown.Value;
                    decimal weight = weightNumericUpDown.Value;
                    this.userTableAdapter.InsertNewUser(username, password, fname, lname, dobStr, email, phone, gender, height, weight);
                    this.userTableAdapter.Fill(this.userDataSet.User);
                    MessageBox.Show("User Registration Completed.", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //this.login.loginUsername = username;
                    //this.login.loginPassword = password;
                    //MenuForm m = new MenuForm(login);
                    //m.Show();
                    //Visible = false;
                }

                catch (Exception ex)
                {
                    MessageBox.Show($"Registration failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private void FillInForm_Load(object sender, EventArgs e)
        {
            this.userTableAdapter.Fill(this.userDataSet.User);

        }
    }
}
