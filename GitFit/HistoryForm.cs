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
    public partial class HistoryForm : Form
    {
        public HistoryForm()
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

            ActivityQuesionnaire a = new ActivityQuesionnaire();
            a.Show();
            Visible = false;
        }

        private void nutritionLabel_Click(object sender, EventArgs e)
        {
            NutritionQuestionnaire n = new NutritionQuestionnaire();
            n.Show();
            Visible = false;
        }

        private void settingLabel_Click(object sender, EventArgs e)
        {
            SettingForm settingForm = new SettingForm();
            settingForm.Show();
            Visible = false;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.userDataSet);

        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userDataSet.Table' table. You can move, or remove it, as needed.
            
            //this.tableTableAdapter.Insert()
            this.tableTableAdapter.Fill(this.userDataSet.Table);

        }
    }
}
