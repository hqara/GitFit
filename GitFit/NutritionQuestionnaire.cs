using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitFitNutrition
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

        private void resultsButton_Click(object sender, EventArgs e)
        {
            NutritionReport nutrition_form = new NutritionReport(2300, choices);
            nutrition_form.Show();
            Visible = false;
        }
    }
}
