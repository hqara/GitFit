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
    public partial class ActivityReport : Form
    {
        public ActivityReport()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;
            base.OnFormClosing(e);
        }

        public ActivityReport(int level, decimal score)
        {
            InitializeComponent();
            if(level == 0)
            {
                currentLevelLbl.Text = "Current Activity Level: Above Average \n"+ score;
                ReportrichTextBox.Text = "The purpose of this report is to provide you with an evaluation of your current " +
                    "activity levels and to highlight the fact that you are performing above average in terms of physical activity." +
                    "\r\n\r\nMethodology:\r\nTo determine your physical activity levels, we utilized a combination of self-reporting " +
                    "and objective measurements. You were asked to complete a detailed questionnaire regarding your exercise routines, " +
                    "daily activities, and overall lifestyle. Additionally, we employed advanced wearable fitness trackers to monitor " +
                    "your activity and collect accurate data.\r\n\r\nFindings:\r\nBased on the comprehensive analysis of the collected " +
                    "data, we have concluded that you consistently exhibit above-average physical activity levels. Here are the key " +
                    "findings that support this assessment:\r\n\r\nRegular Exercise Routine:\r\nYou have consistently adhered to a " +
                    "well-structured exercise routine, engaging in various forms of physical activity, such as cardiovascular exercises, " +
                    "strength training, and flexibility exercises. Your commitment to maintaining a regular exercise schedule significantly " +
                    "contributes to your above-average activity levels.\r\n\r\nDuration and Intensity:\r\nThe duration and intensity of " +
                    "your physical activities surpass the average benchmarks. Your exercise sessions typically extend beyond the recommended " +
                    "minimum duration, and you consistently engage in moderate to high-intensity workouts, which are beneficial for " +
                    "cardiovascular health and overall fitness.\r\n\r\nActive Lifestyle:\r\nIn addition to your exercise routine, you " +
                    "lead an active lifestyle by incorporating physical activity into your daily routines. You frequently engage in " +
                    "activities such as walking, cycling, taking the stairs, or participating in recreational sports. This consistent " +
                    "engagement in physical movement further supports your above-average activity levels.\r\n\r\nEnergy Expenditure:\r\nThe " +
                    "data collected from the wearable fitness trackers indicates a significantly higher energy expenditure during your " +
                    "physical activities compared to the average individual. This suggests that you are expending more calories and exerting " +
                    "greater effort during your workouts, contributing to your exceptional activity levels.\r\n\r\nConclusion:\r\nIn conclusion, " +
                    "based on the data collected and analyzed, it is evident that you are performing above average in terms of physical activity" +
                    " levels. Your dedication to maintaining a regular exercise routine, participation in various physical activities, and high " +
                    "energy expenditure during workouts all contribute to your commendable physical fitness.\r\n\r\nIt is important to acknowledge" +
                    " your accomplishments in maintaining an active lifestyle and sustaining a high level of physical activity. Regular physical " +
                    "activity offers numerous health benefits, including improved cardiovascular fitness, enhanced mental well-being, increased " +
                    "energy levels, and reduced risk of various chronic conditions.\r\n\r\nPlease note that maintaining a balanced approach to " +
                    "physical activity, including adequate rest and recovery, is essential for sustaining long-term health and preventing the risk" +
                    " of overexertion or injury. If you have any concerns or require guidance regarding your fitness journey, we encourage you to" +
                    " consult with a healthcare professional or certified fitness trainer.\r\n\r\nCongratulations on your above-average physical" +
                    " activity levels, and keep up the excellent work!\r\n";
            }
            else if (level == 1)
            {
                currentLevelLbl.Text = "Current Activity Level: Average \n"+ score;
                ReportrichTextBox.Text = "The purpose of this report is to inform you that your current activity levels fall within the average range " +
                    "and to encourage you to consider further opportunities to enhance your overall fitness and well-being.\r\n\r\nMethodology:\r\nTo " +
                    "evaluate your physical activity levels, we utilized a combination of self-reporting and objective measurements. You were asked to " +
                    "complete a detailed questionnaire regarding your exercise routines, daily activities, and overall lifestyle. Additionally, we" +
                    " employed advanced wearable fitness trackers to monitor your activity and collect accurate data.\r\n\r\nFindings:\r\nBased on" +
                    " the comprehensive analysis of the collected data, we have determined that your physical activity levels fall within the average" +
                    " range. Here are the key findings that support this assessment:\r\n\r\nRegular Exercise Routine:\r\nYou have established a fairly" +
                    " consistent exercise routine that aligns with the recommended guidelines for maintaining good physical fitness. Your exercise " +
                    "sessions encompass a variety of activities, such as cardiovascular exercises, strength training, and flexibility exercises.\r\n\r\nDuration " +
                    "and Intensity:\r\nThe duration and intensity of your physical activities meet the average benchmarks. Your exercise sessions typically" +
                    " fall within the recommended time frames, and you engage in moderate to high-intensity workouts, which contribute to maintaining overall " +
                    "fitness and health.\r\n\r\nBalanced Lifestyle:\r\nYour daily routines reflect a balanced lifestyle with a reasonable level of physical" +
                    " activity. While you may not engage in excessive exercise or lead an exceptionally active lifestyle, you manage to incorporate" +
                    " movement into your daily routines, such as walking, light recreational activities, or occasional active leisure pursuits.\r\n\r\nModerate" +
                    " Energy Expenditure:\r\nThe data collected from the wearable fitness trackers indicates a moderate energy expenditure during your " +
                    "physical activities, which aligns with the average values for individuals with similar lifestyles. This indicates that you are " +
                    "expending a reasonable amount of calories and exerting a moderate effort during your workouts.\r\n\r\nConclusion:\r\nIn conclusion," +
                    " based on the data collected and analyzed, it is evident that your physical activity levels fall within the average range. While " +
                    "being average is not inherently negative, it is important to consider opportunities to further enhance your fitness and overall" +
                    " well-being.\r\n\r\nRegular physical activity offers numerous health benefits, including improved cardiovascular health, increased" +
                    " energy levels, enhanced mental well-being, and reduced risk of chronic diseases. By incorporating the following strategies, you" +
                    " can elevate your physical activity levels and further improve your overall fitness:\r\n\r\nProgressive Goals: Consider setting " +
                    "realistic goals to gradually increase the duration, intensity, or frequency of your workouts. Aim to challenge yourself and make " +
                    "incremental improvements over time.\r\n\r\nVariety and Novelty: Explore new physical activities or exercise routines to keep your " +
                    "fitness journey engaging and exciting. Trying different exercises can help target different muscle groups and improve overall fitness " +
                    "levels.\r\n\r\nActive Lifestyle: Look for opportunities to incorporate physical activity into your daily routines. Make choices such" +
                    " as taking the stairs instead of the elevator, walking or cycling for short distances, or participating in active hobbies and " +
                    "recreational activities.\r\n\r\nMindful Monitoring: Continue using wearable fitness trackers or similar tools to monitor your " +
                    "activity levels and progress. This will allow you to assess your efforts, make adjustments, and stay motivated on your fitness " +
                    "journey.\r\n\r\nRemember, even small improvements in your physical activity levels can have significant positive impacts on your " +
                    "health and well-being. We encourage you to explore these opportunities and strive for continuous growth and improvement.";
                
            }
            else if (level == 2)
            {
                currentLevelLbl.Text = "Current Activity Level: Below Average \n" + score;
                ReportrichTextBox.Text = "The purpose of this report is to highlight the fact that your current activity levels are below average " +
                    "and to encourage you to make positive changes in order to improve your overall fitness and well-being.\r\n\r\nMethodology:\r\nTo " +
                    "evaluate your physical activity levels, we utilized a combination of self-reporting and objective measurements. You were asked to" +
                    " complete a detailed questionnaire regarding your exercise routines, daily activities, and overall lifestyle. Additionally, we " +
                    "employed advanced wearable fitness trackers to monitor your activity and collect accurate data.\r\n\r\nFindings:\r\nBased on the" +
                    " comprehensive analysis of the collected data, we have determined that your physical activity levels are below average. Here are" +
                    " the key findings that support this assessment:\r\n\r\nInconsistent Exercise Routine:\r\nYour exercise routine shows a lack of" +
                    " consistency and regularity. The frequency of your workouts falls short of the recommended guidelines for maintaining good " +
                    "physical fitness. Irregular exercise patterns can have a negative impact on your overall health and fitness levels.\r\n\r\nDuration" +
                    " and Intensity:\r\nThe duration and intensity of your physical activities are below the average benchmarks. Your exercise sessions " +
                    "are often shorter in duration and lack the necessary intensity to provide substantial health benefits. Increasing the duration and " +
                    "intensity of your workouts is crucial for improving cardiovascular fitness and overall physical well-being.\r\n\r\nSedentary " +
                    "Lifestyle:\r\nIn addition to a lack of exercise, your daily routines reflect a sedentary lifestyle. You spend extended periods " +
                    "of time engaged in activities that involve minimal physical movement, such as prolonged sitting or sedentary leisure activities." +
                    " A sedentary lifestyle can lead to various health issues, including weight gain, decreased muscle strength, and reduced" +
                    " cardiovascular fitness.\r\n\r\nLow Energy Expenditure:\r\nThe data collected from the wearable fitness trackers indicates a" +
                    " lower energy expenditure during your physical activities compared to the average individual. This suggests that you are " +
                    "expending fewer calories and exerting less effort during your workouts, which contributes to your below-average activity " +
                    "levels.\r\n\r\nConclusion:\r\nIn conclusion, based on the data collected and analyzed, it is evident that your physical " +
                    "activity levels are below average. It is important to address this issue and take steps to improve your overall fitness" +
                    " and well-being. Regular physical activity offers numerous health benefits, including improved cardiovascular health," +
                    " increased energy levels, enhanced mental well-being, and reduced risk of chronic diseases.\r\n\r\nWe encourage you to " +
                    "consider the following strategies to increase your physical activity levels:\r\n\r\nEstablish a Routine: Create a structured " +
                    "exercise routine that includes a combination of cardiovascular exercises, strength training, and flexibility exercises." +
                    " Aim for a minimum of 150 minutes of moderate-intensity aerobic activity or 75 minutes of vigorous-intensity aerobic activity" +
                    " per week.\r\n\r\nActive Lifestyle: Incorporate physical activity into your daily routines. Take breaks from prolonged sitting " +
                    "and engage in activities such as walking, cycling, or taking the stairs whenever possible.\r\n\r\nSet Realistic Goals: Set " +
                    "achievable goals to gradually increase the duration and intensity of your workouts. Start with small steps and gradually" +
                    " progress to more challenging activities.\r\n\r\nSeek Support: Consider seeking guidance from a healthcare professional or " +
                    "certified fitness trainer who can provide personalized advice and help you develop an exercise plan that suits your needs" +
                    " and goals.\r\n\r\nBy implementing these strategies and committing to regular physical activity, you can improve your fitness" +
                    " levels, enhance your overall health, and experience the numerous benefits associated with an active lifestyle.";
            }
        }

        private void exitBtn_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you certain that you want to \nlose your current information?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // User clicked the OK button, exit the program
                System.Diagnostics.Process.GetCurrentProcess().Kill();
                Application.Exit();
            }
        }

        private void ActivityReport_Load(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
