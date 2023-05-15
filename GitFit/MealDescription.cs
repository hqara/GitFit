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
    public partial class MealDescription : Form
    {
        public Meal meal { get; set; }
        public MealDescription()
        {
            InitializeComponent();
        }

        public MealDescription(Meal meal)
        {
            InitializeComponent();
            mealNameLabel.Text = meal.Name;
            macroInformationTextBox.Text = meal.MacroInformation();
            mealDescriptionTextBox.Text = meal.Description;
            BenefitsTextBox.Text = meal.Benefits();
        }
    }

    public class Meal
    {
        public Boolean IsVegan { get; }
        public Boolean IsPescatarian { get; }
        public Boolean IsEasyToMake { get; }
        public Boolean IsBudgetFriendly { get; }
        public Boolean IsTakeOut { get; }

        public String Description { get; }
        public String Name { get; }
        public int Calories { get; }
        public int Proteins { get; }
        public int Carbohydrates { get; }
        public int Fats { get; }

        public Image image { get; set; }
        public Meal(bool isVegan, bool isPescatarian, bool isEasyToMake, bool isBudgetFriendly, bool isTakeOut, string description, string name, int calories, int proteins, int carbohydrates, int fats)
        {
            IsVegan = isVegan;
            IsPescatarian = isPescatarian;
            IsEasyToMake = isEasyToMake;
            IsBudgetFriendly = isBudgetFriendly;
            IsTakeOut = isTakeOut;
            Description = description;
            Name = name;
            Calories = calories;
            Proteins = proteins;
            Carbohydrates = carbohydrates;
            Fats = fats;
            this.image = image;
        }

        public String MacroInformation()
        {
            return String.Format($"Calories: {Calories}\r\n" + $"Protein: {Proteins}\r\n" + $"Carbohydrates: {Carbohydrates}\r\n" + $"Fats: {Fats}");
        }

        public String Benefits()
        {
            String str = "This meal is: \r\n";
            if (IsVegan)
            {
                str += "* Vegan\r\n";
            }

            if (IsPescatarian)
            {
                str += "* Pescatarian\r\n";
            }

            if (IsEasyToMake)
            {
                str += "* Easy to make\r\n";
            }

            if (IsBudgetFriendly)
            {
                str += "* Budget friendly\r\n";
            }

            if (IsTakeOut)
            {
                str += "* Takeout\r\n";
            }

            return str;
        }
    }
}
