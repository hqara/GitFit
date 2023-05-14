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
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
        }

        private void homeLabel_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
            Visible = false;
        }

        private void activityLabel_Click(object sender, EventArgs e)
        {

        }

        private void nutritionLabel_Click(object sender, EventArgs e)
        {

        }

        private void historyLabel_Click(object sender, EventArgs e)
        {

        }

        private void settingLabel_Click(object sender, EventArgs e)
        {

        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }
    }
}
