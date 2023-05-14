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
        public Meal[] Breakfasts { get; }
        public Meal[] Lunches { get; }
        public Meal[] Dinners { get; }
        public Meal[] Snacks { get; } 

        public NutritionReport()
        {
            InitializeComponent();
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

        /*
        private Meal[] getBreakfasts()
        {

        }
        */
        private void exitNReportBtn_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }
    }

    public class Meal
    {
        public Boolean IsVegan { get; }
        public Boolean IsLowCalorie { get; }
        public Boolean IsHighProtein { get; }
        public Boolean IsPescatarian { get; }
        public Boolean IsEasyToMake { get; }
        public Boolean IsBudgetFriendly { get; }
        public Boolean IsTakeOut { get; }

        public String Description { get; }
        public String Name { get; }
        public int Calories { get; }

        public Meal(bool isVegan, bool isLowCalorie, bool isHighProtein, bool isPescatarian, bool isEasyToMake, bool isBudgetFriendly, bool isTakeOut, string description, string name, int calories) 
        {
            IsVegan = isVegan;
            IsLowCalorie = isLowCalorie;
            IsHighProtein = isHighProtein;
            IsPescatarian = isPescatarian;
            IsEasyToMake = isEasyToMake;
            IsBudgetFriendly = isBudgetFriendly;
            IsTakeOut = isTakeOut;
            Description = description;
            Name = name;
            Calories = calories;
        }
    }
}

