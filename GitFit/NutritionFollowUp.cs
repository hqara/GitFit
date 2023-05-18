using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GitFit
{
    public partial class NutritionFollowUp : Form
    {
        public FoodChoices[] foodContainer { get; set; }
        public int[] answers { get; set; }
        public LoginForm login { get; set; }
        public NutritionFollowUp(FoodChoices[] choices, LoginForm login)
        {
            InitializeComponent();
            this.foodContainer = choices;
            this.login = login;
        }

        private void resultsButton_Click(object sender, EventArgs e)
        {
            if (answer1ComboBox.SelectedIndex != -1 && answer2ComboBox.SelectedIndex != -1 && answer3ComboBox.SelectedIndex != -1 &&
            answer4ComboBox.SelectedIndex != -1 && answer5ComboBox.SelectedIndex != -1 && answer6ComboBox.SelectedIndex != -1 && 
            answer7ComboBox.SelectedIndex != -1 && answer8ComboBox.SelectedIndex != -1 && answer9ComboBox.SelectedIndex != -1)
            {
                answers = new int[9];
                answers[0] = answer1ComboBox.SelectedIndex;
                answers[1] = answer2ComboBox.SelectedIndex;
                answers[2] = answer3ComboBox.SelectedIndex;
                answers[3] = answer4ComboBox.SelectedIndex;
                answers[4] = answer5ComboBox.SelectedIndex;
                answers[5] = answer6ComboBox.SelectedIndex;
                answers[6] = answer7ComboBox.SelectedIndex;
                answers[7] = answer8ComboBox.SelectedIndex;
                answers[8] = answer9ComboBox.SelectedIndex;
                
                NutritionReport report = new NutritionReport(foodContainer, login, answers); // change with db param
                report.Show();
                Visible = false;
            }
            else
            {
                DialogResult result = MessageBox.Show("All fields must be completed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            /*Boolean b = true;
            foreach (ComboBox box in answersPanel.Controls)
            {
                if (box.SelectedIndex == -1)
                {
                    MessageBox.Show("All fields must be completed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    b = false;
                }
            }

            if (b)
            {
                NutritionReport report = new NutritionReport(); // change with db param
                report.Show();
                Visible = false;
            }*/

        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
            Visible = false;
        }
    }
}
