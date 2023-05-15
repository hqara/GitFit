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
    public partial class NutritionQuestionnaireFollowUp : Form
    {
        public NutritionQuestionnaireFollowUp()
        {
            InitializeComponent();
        }

        private void resultsButton_Click(object sender, EventArgs e)
        {
            Boolean b = true;
            foreach (ComboBox box in answersPanel.Controls)
            {
                if (box.SelectedIndex == -1)
                {
                    MessageBox.Show("All fields must be completed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    b = false;
                }
            }

            if (b)
            {
                NutritionReport report = new NutritionReport(); // change with db param
                report.Show();
                Visible = false;
            }

        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
            Visible = false;
        }
    }
}
