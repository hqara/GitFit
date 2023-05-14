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
            NutritionReport report = new NutritionReport(); // change with param
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
            Visible = false;
        }
    }
}
