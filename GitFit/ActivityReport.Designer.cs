namespace GitFit
{
    partial class ActivityReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivityReport));
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitBtn = new System.Windows.Forms.Button();
            this.nutritionReportLabel = new System.Windows.Forms.Label();
            this.currentLevelLbl = new System.Windows.Forms.Label();
            this.ReportrichTextBox = new System.Windows.Forms.RichTextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.webBrowser3 = new System.Windows.Forms.WebBrowser();
            this.userDataSet = new GitFit.UserDataSet();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new GitFit.UserDataSetTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new GitFit.UserDataSetTableAdapters.TableAdapterManager();
            this.tableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.exitBtn);
            this.panel1.Controls.Add(this.nutritionReportLabel);
            this.panel1.Location = new System.Drawing.Point(16, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1328, 82);
            this.panel1.TabIndex = 84;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.exitBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.exitBtn.FlatAppearance.BorderSize = 5;
            this.exitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.Transparent;
            this.exitBtn.Location = new System.Drawing.Point(1206, 2);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(116, 74);
            this.exitBtn.TabIndex = 80;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click_1);
            // 
            // nutritionReportLabel
            // 
            this.nutritionReportLabel.BackColor = System.Drawing.Color.Transparent;
            this.nutritionReportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nutritionReportLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.nutritionReportLabel.Location = new System.Drawing.Point(6, 9);
            this.nutritionReportLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.nutritionReportLabel.Name = "nutritionReportLabel";
            this.nutritionReportLabel.Size = new System.Drawing.Size(1316, 62);
            this.nutritionReportLabel.TabIndex = 59;
            this.nutritionReportLabel.Text = "ACTIVE LIFESTYLE REPORT";
            this.nutritionReportLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentLevelLbl
            // 
            this.currentLevelLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentLevelLbl.Location = new System.Drawing.Point(4, 88);
            this.currentLevelLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.currentLevelLbl.Name = "currentLevelLbl";
            this.currentLevelLbl.Size = new System.Drawing.Size(1340, 76);
            this.currentLevelLbl.TabIndex = 85;
            this.currentLevelLbl.Text = "Current Activity Level: \r\nScore";
            this.currentLevelLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReportrichTextBox
            // 
            this.ReportrichTextBox.Location = new System.Drawing.Point(16, 168);
            this.ReportrichTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReportrichTextBox.Name = "ReportrichTextBox";
            this.ReportrichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.ReportrichTextBox.Size = new System.Drawing.Size(667, 870);
            this.ReportrichTextBox.TabIndex = 86;
            this.ReportrichTextBox.Text = "";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(721, 168);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(623, 250);
            this.webBrowser1.TabIndex = 87;
            this.webBrowser1.Url = new System.Uri("https://www.who.int/news-room/fact-sheets/detail/physical-activity", System.UriKind.Absolute);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // webBrowser2
            // 
            this.webBrowser2.Location = new System.Drawing.Point(721, 456);
            this.webBrowser2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.ScriptErrorsSuppressed = true;
            this.webBrowser2.Size = new System.Drawing.Size(623, 250);
            this.webBrowser2.TabIndex = 88;
            this.webBrowser2.Url = new System.Uri("https://www.who.int/publications/i/item/9789241599979", System.UriKind.Absolute);
            // 
            // webBrowser3
            // 
            this.webBrowser3.Location = new System.Drawing.Point(721, 746);
            this.webBrowser3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.webBrowser3.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser3.Name = "webBrowser3";
            this.webBrowser3.ScriptErrorsSuppressed = true;
            this.webBrowser3.Size = new System.Drawing.Size(623, 250);
            this.webBrowser3.TabIndex = 89;
            this.webBrowser3.Url = new System.Uri("https://www.who.int/publications/i/item/9241592222", System.UriKind.Absolute);
            // 
            // userDataSet
            // 
            this.userDataSet.DataSetName = "UserDataSet";
            this.userDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.userDataSet;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = GitFit.UserDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // tableDataGridView
            // 
            this.tableDataGridView.AutoGenerateColumns = false;
            this.tableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.tableDataGridView.DataSource = this.tableBindingSource;
            this.tableDataGridView.Location = new System.Drawing.Point(721, 1009);
            this.tableDataGridView.Name = "tableDataGridView";
            this.tableDataGridView.RowHeadersWidth = 62;
            this.tableDataGridView.RowTemplate.Height = 28;
            this.tableDataGridView.Size = new System.Drawing.Size(623, 118);
            this.tableDataGridView.TabIndex = 90;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "score";
            this.dataGridViewTextBoxColumn3.HeaderText = "score";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "level";
            this.dataGridViewTextBoxColumn4.HeaderText = "level";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // ActivityReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1390, 1050);
            this.Controls.Add(this.tableDataGridView);
            this.Controls.Add(this.webBrowser3);
            this.Controls.Add(this.webBrowser2);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.ReportrichTextBox);
            this.Controls.Add(this.currentLevelLbl);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ActivityReport";
            this.Text = "ActivityReport";
            this.Load += new System.EventHandler(this.ActivityReport_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label nutritionReportLabel;
        private System.Windows.Forms.Label currentLevelLbl;
        private System.Windows.Forms.RichTextBox ReportrichTextBox;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.WebBrowser webBrowser3;
        private UserDataSet userDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private UserDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private UserDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}