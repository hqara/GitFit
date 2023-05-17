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

        public MenuForm()
        {
            InitializeComponent();
        }

        public MenuForm(LoginForm login, string username)
        {
            InitializeComponent();
            this.login = login;

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

        private Dictionary<DateTime, List<string>> taskDictionary = new Dictionary<DateTime, List<string>>();

        private List<string> LoadTasks(DateTime date)
        {
            // Check if there are any tasks for the selected date
            if (taskDictionary.ContainsKey(date))
            {
                // If there are, return the list of tasks for the selected date
                return taskDictionary[date];
            }
            else
            {
                // If there are no tasks for the selected date, return an empty list
                return new List<string>();
            }
        }

        private void SaveTask(DateTime date, string task)
        {
            // Retrieve the tasks for the selected date
            List<string> tasks = LoadTasks(date);

            // Add the new task to the list
            tasks.Add(task);

            if (taskDictionary.ContainsKey(date))
            {
                taskDictionary[date] = tasks;
            }
            else
            {
                taskDictionary.Add(date, tasks);
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

            // Clear the list box
            listBox1.Items.Clear();

            // Get the selected date
            DateTime selectedDate = e.Start;

            // Load the tasks for the selected date
            List<string> tasks = LoadTasks(selectedDate);

            // Display the tasks in the list box
            foreach (string task in tasks)
            {
                listBox1.Items.Add(task);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the selected date
            DateTime selectedDate = monthCalendar1.SelectionStart;

            // Get the task from the text box
            string task = textBox3.Text;

            // Save the task for the selected date
            SaveTask(selectedDate, task);

            // Reload the tasks for the selected date
            List<string> tasks = LoadTasks(selectedDate);
            listBox1.Items.Clear();
            foreach (string t in tasks)
            {
                listBox1.Items.Add(t);
            }

            // Clear the text box
            textBox3.Clear();
        }

        public string bmiText(double value)
        {
            if (value < 18.5)
            {
                return ("Underweight");
            }
            else if (value > 18.5 && value < 24.9)
            {
                return ("Normal");
            }
            else if (value > 25 && value < 29.9)
            {
                return ("Overweight");
            }
            else if (value > 30)
            {
                return ("Obese");
            }

            return "";
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double height = double.Parse(heightNumericUpDown.Text);
            double weight = double.Parse(weightNumericUpDown.Text);
            double bmi = weight * 703 / (height * height);

            numericTextBox.Text = bmi.ToString("F2");
            textBox.Text = bmiText(bmi).ToString();
        }

        private void historyLabel_Click(object sender, EventArgs e)
        {
            HistoryForm h = new HistoryForm(login);
            h.Show();
            Visible = false;
        }

        private void settingLabel_Click(object sender, EventArgs e)
        {
            try
            {
                string username = this.login.loginUsername;
                SettingForm settingForm = new SettingForm(login, username);
                settingForm.Show();
                Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($" failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
