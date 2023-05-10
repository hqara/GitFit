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

        private void exitBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void resultsButton_Click(object sender, EventArgs e)
        {
            NutritionReport report = new NutritionReport(); // change with param
        }
    }
}
