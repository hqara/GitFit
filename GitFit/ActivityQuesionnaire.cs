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
    public partial class ActivityQuesionnaire : Form
    {
        public ActivityQuesionnaire()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;
            base.OnFormClosing(e);
        }
        

        private void exitBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you certain that you want to \nlose your current information?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                MenuForm m = new MenuForm();
                m.Show();
                Visible = false;
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (Q1comboBox.SelectedIndex != -1 && Q3comboBox.SelectedIndex != -1 && Q4comboBox.SelectedIndex != -1 &&
            Q5comboBox.SelectedIndex != -1 && Q6comboBox.SelectedIndex != -1 && Q7comboBox.SelectedIndex != -1 && Q8comboBox.SelectedIndex != -1)
            {
                decimal score = activeLevel();
                if (score == 7 ) {
                    ActivityReport ar = new ActivityReport(0, score);
                    ar.Show();
                    
                }
                else if(score>=8 && score <= 16)
                {
                    ActivityReport ar = new ActivityReport(1, score);
                    ar.Show();
                }
                else if(score>16)
                {
                    ActivityReport ar = new ActivityReport(2, score);
                    ar.Show();
                }

                Visible = false;
            }
            else
            {
                DialogResult result = MessageBox.Show("MUST fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private decimal activeLevel()
        {
            decimal score = 0;

            score += Q1comboBox.SelectedIndex + 1;
            score += Q3comboBox.SelectedIndex + 1;
            score += Q4comboBox.SelectedIndex + 1;
            score += Q5comboBox.SelectedIndex + 1;
            score += Q6comboBox.SelectedIndex + 1;
            score += Q7comboBox.SelectedIndex + 1;
            score += Q8comboBox.SelectedIndex + 1;
            


            return score;
        }
    }
}
