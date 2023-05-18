using GitFit.UserDataSetTableAdapters;
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

        LoginForm login { get; set; }

        private static int breakfastIterator = -1, lunchIterator = -1, dinnerIterator = -1, snackIterator = -1;

        /* ALL RECOMMENDED MEALS */

        public List<Meal> RecommendedBreakfasts { get; }
        public List<Meal> RecommendedLunches { get; }
        public List<Meal> RecommendedDinners { get; }
        public List<Meal> RecommendedSnacks { get; }

        public static Meal[] currentMeals; // 0=breakfast, 1=lunch, 2=dinner, 3=snacks

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;
            base.OnFormClosing(e);
        }

        public NutritionReport(FoodChoices[] choices, LoginForm login)
        {
            InitializeComponent();
            InitializeMeals();
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
            macrosLabel.Text = "Calories: " + Math.Round(GetCalories(), 2);
            macrosLabel.Text += "\nProtein: " + Math.Round(GetProtein(), 2);
            macrosLabel.Text += "\nCarbs: " + Math.Round(GetCarbs(), 2);
            macrosLabel.Text += "\nFats: " + Math.Round(GetFats(), 2);
            breakfastIterator = lunchIterator = dinnerIterator = snackIterator = 0;

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

        private void nextBreakfastButton_Click(object sender, EventArgs e)
        {
            if (RecommendedBreakfasts.Count > 0)
            {
                breakfastIterator = (breakfastIterator + 1) % RecommendedBreakfasts.Count;
                breakfastPicture.Image = RecommendedBreakfasts[breakfastIterator].image;
            }                                            
        }

        private void nextLunchButton_Click(object sender, EventArgs e)
        {
            if (RecommendedLunches.Count > 0)
            {
                lunchIterator = (lunchIterator + 1) % RecommendedLunches.Count;
                lunchPicture.Image = RecommendedLunches[lunchIterator].image;
            }
        }

        private void NutritionReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userDataSet.NutritionAnswers' table. You can move, or remove it, as needed.
            this.nutritionAnswersTableAdapter.Fill(this.userDataSet.NutritionAnswers);

        }

        private void nextDinnerButton_Click(object sender, EventArgs e)
        {
            if (RecommendedDinners.Count > 0)
            {
                dinnerIterator = (dinnerIterator + 1) % RecommendedDinners.Count;
                dinnerPicture.Image = RecommendedDinners[dinnerIterator].image;
            }
        }

        private void nextSnackButton_Click(object sender, EventArgs e)
        {
            if (RecommendedSnacks.Count > 0)
            {
                snackIterator = (snackIterator + 1) % RecommendedSnacks.Count;
                snackPicture.Image = RecommendedSnacks[snackIterator].image;
            }
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

