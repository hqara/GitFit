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


        private void nextButton_Click(object sender, EventArgs e)
        {
            choices[0] = getValue(breakfastPanel);
            choices[1] = getValue(lunchPanel);
            choices[2] = getValue(dinnerPanel);
            choices[3] = getValue(snackPannel);

            NutritionReport nutrition_form = new NutritionReport(2300, choices); // change to nutrition follow up
            nutrition_form.Show();
            Visible = false;
        }

        private FoodChoices getValue(Panel panel)
        {
            foreach (RadioButton rb in panel.Controls)
            {
                if (rb.Checked)
                {
                    switch (lastChar(rb.Name))
                    {
                        case '1':
                            return FoodChoices.Unhealthy;
                        case '2':
                            return FoodChoices.Healthy;
                        case '3':
                            return FoodChoices.Moderate;
                        case '4':
                            return FoodChoices.VeryUnhealthy;
                    }
                }
            }

            return FoodChoices.Unhealthy;
        }

        // TO FIND THE LAST CHARACTER (NUMBER) //
        private char lastChar(String str)
        {
            int length = str.Length;
            return str[length - 1];
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
            Visible = false;
        }
    }
}
