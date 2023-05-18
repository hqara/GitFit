namespace GitFit
{
    partial class NutritionReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NutritionReport));
            this.tipLabel = new System.Windows.Forms.Label();
            this.nextDinnerButton = new System.Windows.Forms.Button();
            this.nextSnackButton = new System.Windows.Forms.Button();
            this.nextLunchButton = new System.Windows.Forms.Button();
            this.nextBreakfastButton = new System.Windows.Forms.Button();
            this.nutritionQuestionnaireTitleLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuBtn = new System.Windows.Forms.Button();
            this.problemAreasInformationLabel = new System.Windows.Forms.Label();
            this.problemAreasLabel = new System.Windows.Forms.Label();
            this.snackPicture = new System.Windows.Forms.PictureBox();
            this.dinnerPicture = new System.Windows.Forms.PictureBox();
            this.lunchPicture = new System.Windows.Forms.PictureBox();
            this.breakfastPicture = new System.Windows.Forms.PictureBox();
            this.snackLabel = new System.Windows.Forms.Label();
            this.lunchLabel = new System.Windows.Forms.Label();
            this.dinnerLabel = new System.Windows.Forms.Label();
            this.breakfastLabel = new System.Windows.Forms.Label();
            this.mealPlanLabel = new System.Windows.Forms.Label();
            this.waterIntakeMessageLabel = new System.Windows.Forms.Label();
            this.addWaterTextBox = new System.Windows.Forms.TextBox();
            this.addWaterButton = new System.Windows.Forms.Button();
            this.waterIntakeLabel = new System.Windows.Forms.Label();
            this.waterIntakeBar = new System.Windows.Forms.ProgressBar();
            this.nutritionHistoryDataSet = new GitFit.NutritionHistoryDataSet();
            this.nutritionHistoryDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nutritionAnswersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userDataSet = new GitFit.UserDataSet();
            this.nutritionAnswersTableAdapter = new GitFit.UserDataSetTableAdapters.NutritionAnswersTableAdapter();
            this.tableAdapterManager = new GitFit.UserDataSetTableAdapters.TableAdapterManager();
            this.macrosLabel = new System.Windows.Forms.Label();
            this.youShouldConsumeLabel = new System.Windows.Forms.Label();
            this.currentStatsLabel = new System.Windows.Forms.Label();
            this.currentStatsLabel2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.snackPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dinnerPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lunchPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakfastPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nutritionHistoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nutritionHistoryDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nutritionAnswersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tipLabel
            // 
            this.tipLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipLabel.Location = new System.Drawing.Point(61, 314);
            this.tipLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tipLabel.Name = "tipLabel";
            this.tipLabel.Size = new System.Drawing.Size(716, 28);
            this.tipLabel.TabIndex = 131;
            this.tipLabel.Text = "TiP: Double-click on the meal\'s picture to get a full description!";
            this.tipLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nextDinnerButton
            // 
            this.nextDinnerButton.Location = new System.Drawing.Point(487, 470);
            this.nextDinnerButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nextDinnerButton.Name = "nextDinnerButton";
            this.nextDinnerButton.Size = new System.Drawing.Size(51, 25);
            this.nextDinnerButton.TabIndex = 126;
            this.nextDinnerButton.Text = "Next";
            this.nextDinnerButton.UseVisualStyleBackColor = true;
            this.nextDinnerButton.Click += new System.EventHandler(this.nextDinnerButton_Click);
            // 
            // nextSnackButton
            // 
            this.nextSnackButton.Location = new System.Drawing.Point(679, 470);
            this.nextSnackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nextSnackButton.Name = "nextSnackButton";
            this.nextSnackButton.Size = new System.Drawing.Size(51, 25);
            this.nextSnackButton.TabIndex = 125;
            this.nextSnackButton.Text = "Next";
            this.nextSnackButton.UseVisualStyleBackColor = true;
            this.nextSnackButton.Click += new System.EventHandler(this.nextSnackButton_Click);
            // 
            // nextLunchButton
            // 
            this.nextLunchButton.Location = new System.Drawing.Point(295, 470);
            this.nextLunchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nextLunchButton.Name = "nextLunchButton";
            this.nextLunchButton.Size = new System.Drawing.Size(51, 25);
            this.nextLunchButton.TabIndex = 124;
            this.nextLunchButton.Text = "Next";
            this.nextLunchButton.UseVisualStyleBackColor = true;
            this.nextLunchButton.Click += new System.EventHandler(this.nextLunchButton_Click);
            // 
            // nextBreakfastButton
            // 
            this.nextBreakfastButton.Location = new System.Drawing.Point(103, 470);
            this.nextBreakfastButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nextBreakfastButton.Name = "nextBreakfastButton";
            this.nextBreakfastButton.Size = new System.Drawing.Size(51, 25);
            this.nextBreakfastButton.TabIndex = 123;
            this.nextBreakfastButton.Text = "Next";
            this.nextBreakfastButton.UseVisualStyleBackColor = true;
            this.nextBreakfastButton.Click += new System.EventHandler(this.nextBreakfastButton_Click);
            // 
            // nutritionQuestionnaireTitleLabel
            // 
            this.nutritionQuestionnaireTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.nutritionQuestionnaireTitleLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nutritionQuestionnaireTitleLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.nutritionQuestionnaireTitleLabel.Location = new System.Drawing.Point(5, 0);
            this.nutritionQuestionnaireTitleLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.nutritionQuestionnaireTitleLabel.Name = "nutritionQuestionnaireTitleLabel";
            this.nutritionQuestionnaireTitleLabel.Size = new System.Drawing.Size(827, 50);
            this.nutritionQuestionnaireTitleLabel.TabIndex = 59;
            this.nutritionQuestionnaireTitleLabel.Text = "NUTRITION REPORT";
            this.nutritionQuestionnaireTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.nutritionQuestionnaireTitleLabel);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(831, 54);
            this.panel1.TabIndex = 122;
            // 
            // menuBtn
            // 
            this.menuBtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.menuBtn.FlatAppearance.BorderSize = 5;
            this.menuBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.menuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBtn.ForeColor = System.Drawing.Color.White;
            this.menuBtn.Location = new System.Drawing.Point(597, 868);
            this.menuBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(172, 59);
            this.menuBtn.TabIndex = 121;
            this.menuBtn.Text = "Back to Menu";
            this.menuBtn.UseVisualStyleBackColor = false;
            this.menuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // problemAreasInformationLabel
            // 
            this.problemAreasInformationLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.problemAreasInformationLabel.Location = new System.Drawing.Point(60, 214);
            this.problemAreasInformationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.problemAreasInformationLabel.Name = "problemAreasInformationLabel";
            this.problemAreasInformationLabel.Size = new System.Drawing.Size(725, 69);
            this.problemAreasInformationLabel.TabIndex = 119;
            this.problemAreasInformationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // problemAreasLabel
            // 
            this.problemAreasLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.problemAreasLabel.Location = new System.Drawing.Point(60, 186);
            this.problemAreasLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.problemAreasLabel.Name = "problemAreasLabel";
            this.problemAreasLabel.Size = new System.Drawing.Size(725, 28);
            this.problemAreasLabel.TabIndex = 118;
            this.problemAreasLabel.Text = "Problem Areas";
            this.problemAreasLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // snackPicture
            // 
            this.snackPicture.Location = new System.Drawing.Point(644, 374);
            this.snackPicture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.snackPicture.Name = "snackPicture";
            this.snackPicture.Size = new System.Drawing.Size(125, 89);
            this.snackPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.snackPicture.TabIndex = 117;
            this.snackPicture.TabStop = false;
            this.snackPicture.Click += new System.EventHandler(this.snackPicture_Click);
            // 
            // dinnerPicture
            // 
            this.dinnerPicture.Location = new System.Drawing.Point(452, 374);
            this.dinnerPicture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dinnerPicture.Name = "dinnerPicture";
            this.dinnerPicture.Size = new System.Drawing.Size(125, 89);
            this.dinnerPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dinnerPicture.TabIndex = 116;
            this.dinnerPicture.TabStop = false;
            this.dinnerPicture.Click += new System.EventHandler(this.dinnerPicture_Click);
            // 
            // lunchPicture
            // 
            this.lunchPicture.Location = new System.Drawing.Point(260, 374);
            this.lunchPicture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lunchPicture.Name = "lunchPicture";
            this.lunchPicture.Size = new System.Drawing.Size(125, 89);
            this.lunchPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lunchPicture.TabIndex = 115;
            this.lunchPicture.TabStop = false;
            this.lunchPicture.Click += new System.EventHandler(this.lunchPicture_Click);
            // 
            // breakfastPicture
            // 
            this.breakfastPicture.Location = new System.Drawing.Point(68, 374);
            this.breakfastPicture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.breakfastPicture.Name = "breakfastPicture";
            this.breakfastPicture.Size = new System.Drawing.Size(125, 89);
            this.breakfastPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.breakfastPicture.TabIndex = 114;
            this.breakfastPicture.TabStop = false;
            this.breakfastPicture.Click += new System.EventHandler(this.breakfastPicture_Click);
            // 
            // snackLabel
            // 
            this.snackLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snackLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.snackLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.snackLabel.Location = new System.Drawing.Point(639, 335);
            this.snackLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.snackLabel.Name = "snackLabel";
            this.snackLabel.Size = new System.Drawing.Size(129, 36);
            this.snackLabel.TabIndex = 108;
            this.snackLabel.Text = "Snack";
            this.snackLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lunchLabel
            // 
            this.lunchLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lunchLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lunchLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lunchLabel.Location = new System.Drawing.Point(260, 335);
            this.lunchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lunchLabel.Name = "lunchLabel";
            this.lunchLabel.Size = new System.Drawing.Size(125, 36);
            this.lunchLabel.TabIndex = 105;
            this.lunchLabel.Text = "Lunch";
            this.lunchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dinnerLabel
            // 
            this.dinnerLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dinnerLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dinnerLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.dinnerLabel.Location = new System.Drawing.Point(448, 335);
            this.dinnerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dinnerLabel.Name = "dinnerLabel";
            this.dinnerLabel.Size = new System.Drawing.Size(129, 36);
            this.dinnerLabel.TabIndex = 107;
            this.dinnerLabel.Text = "Dinner";
            this.dinnerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // breakfastLabel
            // 
            this.breakfastLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breakfastLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.breakfastLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.breakfastLabel.Location = new System.Drawing.Point(55, 335);
            this.breakfastLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.breakfastLabel.Name = "breakfastLabel";
            this.breakfastLabel.Size = new System.Drawing.Size(148, 36);
            this.breakfastLabel.TabIndex = 104;
            this.breakfastLabel.Text = "Breakfast";
            this.breakfastLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mealPlanLabel
            // 
            this.mealPlanLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mealPlanLabel.Location = new System.Drawing.Point(60, 283);
            this.mealPlanLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mealPlanLabel.Name = "mealPlanLabel";
            this.mealPlanLabel.Size = new System.Drawing.Size(716, 28);
            this.mealPlanLabel.TabIndex = 113;
            this.mealPlanLabel.Text = "Weekly Meal Plan";
            this.mealPlanLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // waterIntakeMessageLabel
            // 
            this.waterIntakeMessageLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waterIntakeMessageLabel.Location = new System.Drawing.Point(451, 818);
            this.waterIntakeMessageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.waterIntakeMessageLabel.Name = "waterIntakeMessageLabel";
            this.waterIntakeMessageLabel.Size = new System.Drawing.Size(319, 28);
            this.waterIntakeMessageLabel.TabIndex = 112;
            this.waterIntakeMessageLabel.Text = "Let\'s hit our water goal today!";
            this.waterIntakeMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addWaterTextBox
            // 
            this.addWaterTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addWaterTextBox.Location = new System.Drawing.Point(69, 823);
            this.addWaterTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addWaterTextBox.Name = "addWaterTextBox";
            this.addWaterTextBox.Size = new System.Drawing.Size(216, 28);
            this.addWaterTextBox.TabIndex = 111;
            // 
            // addWaterButton
            // 
            this.addWaterButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addWaterButton.Location = new System.Drawing.Point(321, 819);
            this.addWaterButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addWaterButton.Name = "addWaterButton";
            this.addWaterButton.Size = new System.Drawing.Size(100, 31);
            this.addWaterButton.TabIndex = 110;
            this.addWaterButton.Text = "Add Water";
            this.addWaterButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addWaterButton.UseVisualStyleBackColor = true;
            this.addWaterButton.Click += new System.EventHandler(this.addWaterButton_Click);
            // 
            // waterIntakeLabel
            // 
            this.waterIntakeLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waterIntakeLabel.Location = new System.Drawing.Point(59, 722);
            this.waterIntakeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.waterIntakeLabel.Name = "waterIntakeLabel";
            this.waterIntakeLabel.Size = new System.Drawing.Size(709, 28);
            this.waterIntakeLabel.TabIndex = 109;
            this.waterIntakeLabel.Text = "Today\'s Water Intake";
            this.waterIntakeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // waterIntakeBar
            // 
            this.waterIntakeBar.BackColor = System.Drawing.SystemColors.Control;
            this.waterIntakeBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.waterIntakeBar.Location = new System.Drawing.Point(59, 765);
            this.waterIntakeBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.waterIntakeBar.Maximum = 3000;
            this.waterIntakeBar.Name = "waterIntakeBar";
            this.waterIntakeBar.Size = new System.Drawing.Size(715, 28);
            this.waterIntakeBar.TabIndex = 106;
            // 
            // nutritionHistoryDataSet
            // 
            this.nutritionHistoryDataSet.DataSetName = "NutritionHistoryDataSet";
            this.nutritionHistoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nutritionHistoryDataSetBindingSource
            // 
            this.nutritionHistoryDataSetBindingSource.DataSource = this.nutritionHistoryDataSet;
            this.nutritionHistoryDataSetBindingSource.Position = 0;
            // 
            // nutritionAnswersBindingSource
            // 
            this.nutritionAnswersBindingSource.DataMember = "NutritionAnswers";
            this.nutritionAnswersBindingSource.DataSource = this.userDataSet;
            // 
            // userDataSet
            // 
            this.userDataSet.DataSetName = "UserDataSet";
            this.userDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nutritionAnswersTableAdapter
            // 
            this.nutritionAnswersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.NutritionAnswersTableAdapter = this.nutritionAnswersTableAdapter;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GitFit.UserDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // macrosLabel
            // 
            this.macrosLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macrosLabel.Location = new System.Drawing.Point(65, 92);
            this.macrosLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.macrosLabel.Name = "macrosLabel";
            this.macrosLabel.Size = new System.Drawing.Size(712, 94);
            this.macrosLabel.TabIndex = 132;
            this.macrosLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // youShouldConsumeLabel
            // 
            this.youShouldConsumeLabel.AutoSize = true;
            this.youShouldConsumeLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.youShouldConsumeLabel.Location = new System.Drawing.Point(308, 63);
            this.youShouldConsumeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.youShouldConsumeLabel.Name = "youShouldConsumeLabel";
            this.youShouldConsumeLabel.Size = new System.Drawing.Size(204, 23);
            this.youShouldConsumeLabel.TabIndex = 120;
            this.youShouldConsumeLabel.Text = "You should consume:";
            // 
            // currentStatsLabel
            // 
            this.currentStatsLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentStatsLabel.Location = new System.Drawing.Point(60, 510);
            this.currentStatsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentStatsLabel.Name = "currentStatsLabel";
            this.currentStatsLabel.Size = new System.Drawing.Size(227, 182);
            this.currentStatsLabel.TabIndex = 133;
            this.currentStatsLabel.Text = "You have selected: ";
            this.currentStatsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // currentStatsLabel2
            // 
            this.currentStatsLabel2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentStatsLabel2.Location = new System.Drawing.Point(312, 510);
            this.currentStatsLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentStatsLabel2.Name = "currentStatsLabel2";
            this.currentStatsLabel2.Size = new System.Drawing.Size(473, 182);
            this.currentStatsLabel2.TabIndex = 134;
            this.currentStatsLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NutritionReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(833, 979);
            this.Controls.Add(this.currentStatsLabel2);
            this.Controls.Add(this.currentStatsLabel);
            this.Controls.Add(this.macrosLabel);
            this.Controls.Add(this.tipLabel);
            this.Controls.Add(this.nextDinnerButton);
            this.Controls.Add(this.nextSnackButton);
            this.Controls.Add(this.nextLunchButton);
            this.Controls.Add(this.nextBreakfastButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuBtn);
            this.Controls.Add(this.youShouldConsumeLabel);
            this.Controls.Add(this.problemAreasInformationLabel);
            this.Controls.Add(this.problemAreasLabel);
            this.Controls.Add(this.snackPicture);
            this.Controls.Add(this.dinnerPicture);
            this.Controls.Add(this.lunchPicture);
            this.Controls.Add(this.breakfastPicture);
            this.Controls.Add(this.snackLabel);
            this.Controls.Add(this.lunchLabel);
            this.Controls.Add(this.dinnerLabel);
            this.Controls.Add(this.breakfastLabel);
            this.Controls.Add(this.mealPlanLabel);
            this.Controls.Add(this.waterIntakeMessageLabel);
            this.Controls.Add(this.addWaterTextBox);
            this.Controls.Add(this.addWaterButton);
            this.Controls.Add(this.waterIntakeLabel);
            this.Controls.Add(this.waterIntakeBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NutritionReport";
            this.Text = "GitFit - Nutrition Report";
            this.Load += new System.EventHandler(this.NutritionReport_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.snackPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dinnerPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lunchPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakfastPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nutritionHistoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nutritionHistoryDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nutritionAnswersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tipLabel;
        private System.Windows.Forms.Button nextDinnerButton;
        private System.Windows.Forms.Button nextSnackButton;
        private System.Windows.Forms.Button nextLunchButton;
        private System.Windows.Forms.Button nextBreakfastButton;
        private System.Windows.Forms.Label nutritionQuestionnaireTitleLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button menuBtn;
        private System.Windows.Forms.Label problemAreasInformationLabel;
        private System.Windows.Forms.Label problemAreasLabel;
        private System.Windows.Forms.PictureBox snackPicture;
        private System.Windows.Forms.PictureBox dinnerPicture;
        private System.Windows.Forms.PictureBox lunchPicture;
        private System.Windows.Forms.PictureBox breakfastPicture;
        private System.Windows.Forms.Label snackLabel;
        private System.Windows.Forms.Label lunchLabel;
        private System.Windows.Forms.Label dinnerLabel;
        private System.Windows.Forms.Label breakfastLabel;
        private System.Windows.Forms.Label mealPlanLabel;
        private System.Windows.Forms.Label waterIntakeMessageLabel;
        private System.Windows.Forms.TextBox addWaterTextBox;
        private System.Windows.Forms.Button addWaterButton;
        private System.Windows.Forms.Label waterIntakeLabel;
        private System.Windows.Forms.ProgressBar waterIntakeBar;
        private NutritionHistoryDataSet nutritionHistoryDataSet;
        private System.Windows.Forms.BindingSource nutritionHistoryDataSetBindingSource;
        private UserDataSet userDataSet;
        private System.Windows.Forms.BindingSource nutritionAnswersBindingSource;
        private UserDataSetTableAdapters.NutritionAnswersTableAdapter nutritionAnswersTableAdapter;
        private UserDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label macrosLabel;
        private System.Windows.Forms.Label youShouldConsumeLabel;
        private System.Windows.Forms.Label currentStatsLabel;
        private System.Windows.Forms.Label currentStatsLabel2;
    }
}