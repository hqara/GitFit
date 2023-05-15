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
    public partial class NutritionReport : Form
    {
        public FoodChoices GeneralHealth { get; set; }
        /* ALL AVAILABLE MEALS*/
        public Meal[] Breakfasts { get; }
        public Meal[] Lunches { get; }
        public Meal[] Dinners { get; }
        public Meal[] Snacks { get; }

        /* ALL RECOMMENDED MEALS */

        public Meal[] RecommendedBreakfasts { get; }
        public Meal[] RecommmendedLunches { get; }
        public Meal[] RecommendedDinners { get; }
        public Meal[] RecommendedSnacks { get; }

        public static Meal[] currentMeals; // 0=breakfast, 1=lunch, 2=dinner, 3=snacks

        public NutritionReport()
        {
            InitializeComponent();
            if (GeneralHealth == FoodChoices.Healthy || GeneralHealth == FoodChoices.Moderate)
            {
                // moreTipsTextLabel.Text = "You generally have healthy food choices. ";
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;
            base.OnFormClosing(e);
        }

        public NutritionReport(int estimatedCalorieIntake, FoodChoices[] choices)
        {
            InitializeComponent();
            this.estimatedCalorieIntakeLabel.Text += (" " + estimatedCalorieIntake);
            GeneralHealth = score(choices);

        }

        private FoodChoices score(FoodChoices[] choices)
        {
            int healthPoints = 0;

            for (int i = 0; i < choices.Length; i++)
            {
                if (choices[i] == FoodChoices.Healthy)
                {
                    healthPoints += 2;
                }
                else if (choices[i] == FoodChoices.Moderate)
                {
                    healthPoints += 1;
                }
            }

            if (healthPoints >= 6)
            {
                return FoodChoices.Healthy;
            }
            else if (healthPoints < 6 && healthPoints >= 3)
            {
                return FoodChoices.Moderate;
            }
            else if (healthPoints < 3 && healthPoints > 0)
            {
                return FoodChoices.Unhealthy;
            }
            else
            {
                return FoodChoices.VeryUnhealthy;
            }
        }

        private void addWaterButton_Click(object sender, EventArgs e)
        {
            try
            {
                int added = int.Parse(addWaterTextBox.Text);
                if (waterIntakeBar.Value + added >= waterIntakeBar.Maximum)
                {
                    waterIntakeBar.Value = waterIntakeBar.Maximum;
                    waterIntakeMessageLabel.Text = "Goal reached! You did it!";
                }
                else
                {
                    waterIntakeBar.Value += added;

                    if (waterIntakeBar.Value >= 500 && waterIntakeBar.Value < 1000)
                    {
                        waterIntakeMessageLabel.Text = "Nice! Keep pushing.";
                    }
                    else if (waterIntakeBar.Value >= 1000 && waterIntakeBar.Value < 1500)
                    {
                        waterIntakeMessageLabel.Text = "Almost halfway!";
                    }
                    else if (waterIntakeBar.Value >= 1500 && waterIntakeBar.Value < 2000)
                    {
                        waterIntakeMessageLabel.Text = "Halfway though! keep pushing.";
                    }
                    else if (waterIntakeBar.Value >= 2000 && waterIntakeBar.Value < 2500)
                    {
                        waterIntakeMessageLabel.Text = "You rock! You're almost there!";
                    }
                    else if (waterIntakeBar.Value >= 2500)
                    {
                        waterIntakeMessageLabel.Text = "Keep pushing! You're nearing it!";
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Whole numbers only.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
            Visible = false;
        }

        private void breakfastPicture_Click(object sender, EventArgs e)
        {
            MealDescription desc = new MealDescription(currentMeals[0]);
            desc.Show();
        }

        private void lunchPicture_Click(object sender, EventArgs e)
        {
            MealDescription desc = new MealDescription(currentMeals[1]);
            desc.Show();
        }

        private void dinnerPicture_Click(object sender, EventArgs e)
        {
            MealDescription desc = new MealDescription(currentMeals[2]);
            desc.Show();
        }

        private void snackPicture_Click(object sender, EventArgs e)
        {
            MealDescription desc = new MealDescription(currentMeals[3]);
            desc.Show();
        }

    }
}

