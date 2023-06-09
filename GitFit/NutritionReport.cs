﻿using GitFit.UserDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitFit
{
    public partial class NutritionReport : Form
    {
        public FoodChoices GeneralHealth { get; set; }

        /* ALL AVAILABLE MEALS*/
        public Meal[] Breakfasts = new Meal[4];
        public Meal[] Lunches = new Meal[4];
        public Meal[] Dinners = new Meal[4];
        public Meal[] Snacks = new Meal[4];

        LoginForm login;
        public int[] Answers { get; set; }

        private static int breakfastIterator = -1, lunchIterator = -1, dinnerIterator = -1, snackIterator = -1;

        /* ALL RECOMMENDED MEALS */

        public List<Meal> RecommendedBreakfasts { get; set; }
        public List<Meal> RecommendedLunches { get; set; }
        public List<Meal> RecommendedDinners { get; set; }
        public List<Meal> RecommendedSnacks { get; set; }

        public static Meal[] currentMeals = new Meal[4]; // 0=breakfast, 1=lunch, 2=dinner, 3=snacks

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;
            base.OnFormClosing(e);
        }

        public NutritionReport(FoodChoices[] choices, LoginForm login, int[] answers)
        {
            this.Answers = answers;
            this.login= login;
            InitializeComponent();
            InitializeMeals();
            InitializeRecommendedMeals();
            breakfastIterator = lunchIterator = dinnerIterator = snackIterator = 0;
            GeneralHealth = score(choices);

            problemAreasInformationLabel.Text = "It was determined that you are " + GeneralHealth + ".";
            if (GeneralHealth == FoodChoices.Healthy || GeneralHealth == FoodChoices.Moderate)
            {
                problemAreasInformationLabel.Text += "\nKeep it up! Here are some meal ideas to keep improving.";
            }
            else
            {

                problemAreasInformationLabel.Text += "\nYou should pay more attention to what you eat. Moderation is key. Here are \nsome meals plans to help";
            }

            this.login = login;
            macrosLabel.Text = (answers[0] == 1 || answers[3] == 2 || answers[3] == 3) ? "Calories: " + Math.Round(GetCalories(true), 2) : "Calories: " + Math.Round(GetCalories(), 2);
            macrosLabel.Text += (answers[0] == 0) ? "\nProtein: " + (Math.Round(GetProtein(), 2) + 50) : "\nProtein: " + (Math.Round(GetProtein(), 2));
            macrosLabel.Text += "\nCarbs: " + Math.Round(GetCarbs(), 2);
            macrosLabel.Text += "\nFats: " + Math.Round(GetFats(), 2);
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

        /* CONTROLS */

        private void menuBtn_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm(login);
            menuForm.Show();
            Visible = false;
        }

        private void breakfastPicture_Click(object sender, EventArgs e)
        {
            if (currentMeals[0] != null)
            {
                MealDescription desc = new MealDescription(currentMeals[0]);
                desc.Show();
            }
        }

        private void lunchPicture_Click(object sender, EventArgs e)
        {
            if (currentMeals[1] != null)
            {
                MealDescription desc = new MealDescription(currentMeals[1]);
                desc.Show();
            }
        }

        private void dinnerPicture_Click(object sender, EventArgs e)
        {
            if (currentMeals[2] != null)
            {
                MealDescription desc = new MealDescription(currentMeals[2]);
                desc.Show();
            }
        }

        private void snackPicture_Click(object sender, EventArgs e)
        {
            if (currentMeals[3] != null)
            {
                MealDescription desc = new MealDescription(currentMeals[3]);
                desc.Show();
            }
        }

        public void InitializeMeals()
        {
            Breakfasts[0] = new Meal(true, true, true, true, false, "Avocado spread on whole grain bread", "Avocado Toast", 360, 7, 20, 17, "avocado");
            Breakfasts[1] = new Meal(false, true, true, true, false, "Fruits, honey and granola on top of greek yoghourt", "Greek yoghourt bowl", 320, 24, 20, 14, "yoghourt");
            Breakfasts[2] = new Meal(true, false, false, true, false, "Meat and veggies inside of muffin-shaped baked eggs", "Egg bites", 200, 20, 20, 14, "eggs");
            Breakfasts[3] = new Meal(false, true, true, false, false, "Cooked oats, savory or sweet", "oatmeal", 250, 13, 20, 12, "oats");

            Lunches[0] = new Meal(false, false, true, true, false, "Turkey, cheese and lettuce on whole-grain bread", "Turkey sandwich", 300, 29, 20, 12, "turkey");
            Lunches[1] = new Meal(false, false, false, true, true, "Chicken, lettuce and sauce inside a tortilla wrap", "Chicken wrap", 320, 34, 17, 12, "wrap");
            Lunches[2] = new Meal(false, true, true, false, true, "Roma tomatoes, feta cheese, olives, cucumbers and red onions, diced and enjoyed", "Greek Salad", 400, 9, 21, 18, "greek");
            Lunches[3] = new Meal(false, false, false, true, false, "Chicken, broccoli and rice", "Chicken, broccoli and rice", 400, 32, 20, 12, "CRB");

            Dinners[0] = new Meal(true, true, false, true, false, "Chopped vegetables and broth, blended", "Vegetable soup", 200, 4, 18, 0, "veggies");
            Dinners[1] = new Meal(false, true, false, false, false, "Smoked salmon on begetables and rice", "Salmon bowl", 400, 36, 42, 14, "salmon");
            Dinners[2] = new Meal(false, true, false, true, false, "Tuna, rice and chipotle sauce", "Tuna rice", 320, 17, 35, 7, "tuna");
            Dinners[3] = new Meal(true, true, false, false, false, "Balanced bowls of any vegetables, protein sources and fats", "Nourish bowl", 600, 30, 39, 14, "nourish");

            Snacks[0] = new Meal(true, true, false, false, true, "Chopped fruits (any)", "Fruit salad", 100, 1, 25, 0, "fruits");
            Snacks[1] = new Meal(true, true, true, true, false, "Popcorn", "Popcorn", 60, 1, 10, 2, "popcorn");
            Snacks[2] = new Meal(true, true, true, false, false, "Mixed nuts", "Nuts", 320, 13, 20, 13, "nuts");
            Snacks[3] = new Meal(true, true, false, true, true, "Granola bar", "Granola bar", 140, 5, 19, 3, "granola");
        }

        private void NutritionReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userDataSet.NutritionAnswers' table. You can move, or remove it, as needed.
            this.nutritionAnswersTableAdapter.Fill(this.userDataSet.NutritionAnswers);
        }

        private void nextBreakfastButton_Click(object sender, EventArgs e)
        {
            if (RecommendedBreakfasts.Count > 0 && RecommendedBreakfasts != null)
            {
                breakfastIterator = (breakfastIterator + 1) % RecommendedBreakfasts.Count;
                breakfastPicture.Image = RecommendedBreakfasts[breakfastIterator].image;
                currentMeals[0] = RecommendedBreakfasts[breakfastIterator];
                UpdateMealPlanStatus();
            }                                            
        }

        private void nextLunchButton_Click(object sender, EventArgs e)
        {
            if (RecommendedLunches.Count > 0 && RecommendedLunches != null)
            {
                lunchIterator = (lunchIterator + 1) % RecommendedLunches.Count;
                lunchPicture.Image = RecommendedLunches[lunchIterator].image;
                currentMeals[1] = RecommendedLunches[lunchIterator];
                UpdateMealPlanStatus();
            }
        }

        private void nextDinnerButton_Click(object sender, EventArgs e)
        {
            if (RecommendedDinners.Count > 0 && RecommendedDinners != null)
            {
                dinnerIterator = (dinnerIterator + 1) % RecommendedDinners.Count;
                dinnerPicture.Image = RecommendedDinners[dinnerIterator].image;
                currentMeals[2] = RecommendedDinners[dinnerIterator];
                UpdateMealPlanStatus();
            }
        }

        private void nextSnackButton_Click(object sender, EventArgs e)
        {
            if (RecommendedSnacks.Count > 0 && RecommendedSnacks != null)
            {
                snackIterator = (snackIterator + 1) % RecommendedSnacks.Count;
                snackPicture.Image = RecommendedSnacks[snackIterator].image;
                currentMeals[3] = RecommendedSnacks[snackIterator];
                UpdateMealPlanStatus();
            }
        }

        public void InitializeRecommendedMeals()
        {
            RecommendedBreakfasts = new List<Meal>();
            RecommendedLunches = new List<Meal>();
            RecommendedDinners = new List<Meal>();
            RecommendedSnacks = new List<Meal>();
            Boolean pass;
            foreach (Meal breakfast in Breakfasts)
            {
                // if the meal passes all tests, it will be recommended
                pass = true;

                // if meal isnt vegan and user is vegan
                if (Answers[1] == 1 && breakfast.IsVegan == false)
                    pass = false;
                
                // if meal is pescatarian and meal includes non-fish meat
                if (Answers[1] == 2 && breakfast.IsPescatarian == false)
                    pass = false;

                // if the meal is not budget friendly and user has tight budget
                if ((Answers[4] == 0 || Answers[4] == 1) && breakfast.IsBudgetFriendly == false)
                    pass = false;

                // if meal is time consuming and user is busy
                if ((Answers[5] == 0 || Answers[4] == 1) && breakfast.IsEasyToMake == false)
                    pass = false;

                if (pass)
                {
                    RecommendedBreakfasts.Add(breakfast);
                }
            }

            foreach (Meal lunch in Lunches)
            {
                // if the meal passes all tests, it will be recommended
                pass = true;

                // if meal isnt vegan and user is vegan
                if (Answers[1] == 1 && lunch.IsVegan == false)
                    pass = false;

                // if meal is pescatarian and meal includes non-fish meat
                if (Answers[1] == 2 && lunch.IsPescatarian == false)
                    pass = false;

                // if the meal is not budget friendly and user has tight budget
                if ((Answers[4] == 0 || Answers[4] == 1) && lunch.IsBudgetFriendly == false)
                    pass = false;

                // if meal is time consuming and user is busy
                if ((Answers[5] == 0 || Answers[4] == 1) && lunch.IsEasyToMake == false)
                    pass = false;

                if (pass)
                {
                    RecommendedLunches.Add(lunch);
                }
            }

            foreach (Meal dinner in Dinners)
            {
                // if the meal passes all tests, it will be recommended
                pass = true;

                // if meal isnt vegan and user is vegan
                if (Answers[1] == 1 && dinner.IsVegan == false)
                    pass = false;

                // if meal is pescatarian and meal includes non-fish meat
                if (Answers[1] == 2 && dinner.IsPescatarian == false)
                    pass = false;

                // if the meal is not budget friendly and user has tight budget
                if ((Answers[4] == 0 || Answers[4] == 1) && dinner.IsBudgetFriendly == false)
                    pass = false;

                // if meal is time consuming and user is busy
                if ((Answers[5] == 0 || Answers[4] == 1) && dinner.IsEasyToMake == false)
                    pass = false;

                if (pass)
                {
                    RecommendedDinners.Add(dinner);
                }
            }

            foreach (Meal snack in Snacks)
            {
                // if the meal passes all tests, it will be recommended
                pass = true;

                // if meal isnt vegan and user is vegan
                if (Answers[1] == 1 && snack.IsVegan == false)
                    pass = false;

                // if meal is pescatarian and meal includes non-fish meat
                if (Answers[1] == 2 && snack.IsPescatarian == false)
                    pass = false;

                // if the meal is not budget friendly and user has tight budget
                if ((Answers[4] == 0 || Answers[4] == 1) && snack.IsBudgetFriendly == false)
                    pass = false;

                // if meal is time consuming and user is busy
                if ((Answers[5] == 0 || Answers[4] == 1) && snack.IsEasyToMake == false)
                    pass = false;

                if (pass)
                {
                    RecommendedSnacks.Add(snack);
                }
            }
        }

        public void UpdateMealPlanStatus()
        {
            double totalCal = 0, totalProtein = 0, totalCarbs = 0, totalFats = 0;
            if (currentMeals[0] != null)
            {
                totalCal += currentMeals[0].Calories;
                totalProtein += currentMeals[0].Proteins;
                totalCarbs += currentMeals[0].Carbohydrates;
                totalFats += currentMeals[0].Fats;
            }

            if (currentMeals[1] != null)
            {
                totalCal += currentMeals[1].Calories;
                totalProtein += currentMeals[1].Proteins;
                totalCarbs += currentMeals[1].Carbohydrates;
                totalFats += currentMeals[1].Fats;
            }

            if (currentMeals[2] != null)
            {
                totalCal += currentMeals[2].Calories;
                totalProtein += currentMeals[2].Proteins;
                totalCarbs += currentMeals[2].Carbohydrates;
                totalFats += currentMeals[2].Fats;
            }

            if (currentMeals[3] != null)
            {
                totalCal += currentMeals[3].Calories;
                totalProtein += currentMeals[3].Proteins;
                totalCarbs += currentMeals[3].Carbohydrates;
                totalFats += currentMeals[3].Fats;
            }

            currentStatsLabel.Text = "\n" + totalCal + " calories.";
            currentStatsLabel.Text += "\n" + totalProtein + " proteins.";
            currentStatsLabel.Text += "\n" + totalCarbs + " carbs.";
            currentStatsLabel.Text += "\n" + totalFats + " fats.";

            currentStatsLabel2.Text = (totalCal > GetCalories()) ?
                "\nYou are " + (totalCal - GetCalories()) + " calories over your recommended amount." :
                "\nYou are " + Math.Abs(totalCal - GetCalories()) + " calories under your recommended amount.";

            currentStatsLabel2.Text += (totalProtein > GetProtein()) ?
                "\nYou are " + (totalProtein - GetProtein()) + " proteins over your recommended amount." :
                "\nYou are " + Math.Round(Math.Abs(totalProtein - GetProtein()),2) + " proteins under your recommended amount.";

            currentStatsLabel2.Text += (totalCarbs > GetCarbs()) ?
                "\nYou are " + (totalCarbs - GetCarbs()) + " carbs over your recommended amount." :
                "\nYou are " + Math.Abs(totalCarbs - GetCarbs()) + " carbs under your recommended amount.";

            currentStatsLabel2.Text += (totalFats > GetFats()) ?
                "\nYou are " + (totalFats - GetFats()) + " fats over your recommended amount." :
                "\nYou are " + Math.Abs(totalFats - GetFats()) + " fats under your recommended amount.";
        }

        /* DATABSE RETRIEVAL */
        public string GetGender()
        {
            string username = this.login.loginUsername;
            UserDataSet.UserDataTable userTable = new UserTableAdapter().getDataByUsername(username);
            if (userTable.Rows.Count > 0)
            {
                string dob = userTable.Rows[0]["gender"].ToString();
                return dob;
            }
            return null;
        }

        public string GetHeight()
        {
            string username = this.login.loginUsername;
            UserDataSet.UserDataTable userTable = new UserTableAdapter().getDataByUsername(username);
            if (userTable.Rows.Count > 0)
            {
                string dob = userTable.Rows[0]["height"].ToString();
                return dob;
            }
            return null;
        }
        public string GetWeight()
        {
            string username = this.login.loginUsername;
            UserDataSet.UserDataTable userTable = new UserTableAdapter().getDataByUsername(username);
            if (userTable.Rows.Count > 0)
            {
                string dob = userTable.Rows[0]["weight"].ToString();
                return dob;
            }
            return null;
        }

        
        public double GetCalories()
        {
            if (GetGender().Equals("M"))
            {
                // For men: 66 + (6.2 x weight) + (12.7 x height) – (6.76 x age)
                return 66 + (6.2 * Double.Parse(GetWeight())) + (12.7 * Double.Parse(GetHeight())) - (6.76 * GetAge());
            }

            // For women: 655.1 + (4.35 x weight) + (4.7 x height) – (4.7 x age)
            return 655.1 + (4.35 * Double.Parse(GetWeight())) + (4.7 * Double.Parse(GetHeight())) - (4.7 * GetAge());
        }

        public double GetCalories(Boolean surplus)
        {
            if (surplus)
            {
                return GetCalories() + 500;
            }

            return GetCalories() - 500;
        }

        public string GetDOB()
        {
            string username = this.login.loginUsername;
            UserDataSet.UserDataTable userTable = new UserTableAdapter().getDataByUsername(username);
            if (userTable.Rows.Count > 0)
            {
                string dob = userTable.Rows[0]["dob"].ToString();
                return dob;
            }
            return null;
        }

        public int GetAge()
        {
            DateTime dob = DateTime.Parse(GetDOB());
            DateTime now = DateTime.Now;
            return now.Year - dob.Year;
        }

        public double GetProtein()
        {
            return 0.36 * Double.Parse(GetWeight());
        }

        public double GetCarbs()
        {
            return (GetCalories() * 0.45) / 4;
        }

        public double GetFats()
        {
            return (GetCalories() * 0.2) / 9;
        }
    }
}

