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
    public enum FoodChoices
    {
        Unhealthy, 
        Healthy,
        Moderate,
        VeryUnhealthy
    }

    public partial class NutritionQuestionnaire : Form
    {
        public FoodChoices[] choices = new FoodChoices[4];
        public NutritionQuestionnaire()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;
            base.OnFormClosing(e);
        }

        private void resultsButton_Click(object sender, EventArgs e)
        {
            NutritionReport nutrition_form = new NutritionReport(2300, choices);
            nutrition_form.Show();
            Visible = false;
        }

        private void exitBtn_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();

        }
    }
}
