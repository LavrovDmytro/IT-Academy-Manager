namespace ITAcademyManager
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelViewSchedule = new System.Windows.Forms.Panel();
            this.panelViewPlaces = new System.Windows.Forms.Panel();
            this.panelViewGroups = new System.Windows.Forms.Panel();
            this.panelViewSpecializations = new System.Windows.Forms.Panel();
            this.panelViewInstructors = new System.Windows.Forms.Panel();
            this.panelViewGrades = new System.Windows.Forms.Panel();
            this.panelViewStudents = new System.Windows.Forms.Panel();
            this.btnViewSchedule = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnViewPlaces = new System.Windows.Forms.Button();
            this.btnViewGroups = new System.Windows.Forms.Button();
            this.btnViewSpecializations = new System.Windows.Forms.Button();
            this.btnViewInstructors = new System.Windows.Forms.Button();
            this.btnViewGrades = new System.Windows.Forms.Button();
            this.btnViewStudents = new System.Windows.Forms.Button();
            this.btnViewCourses = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.chartGroupCapacity = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartSuccess = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTotalScheduled = new System.Windows.Forms.Panel();
            this.labelTotalScheduled = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panelTotalInstructors = new System.Windows.Forms.Panel();
            this.labelTotalInstructors = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelTotalStudents = new System.Windows.Forms.Panel();
            this.labelTotalStudents = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelTotalCourses = new System.Windows.Forms.Panel();
            this.labelTotalCourses = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelViewCourses = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelTitle.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGroupCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSuccess)).BeginInit();
            this.panelTotalScheduled.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panelTotalInstructors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelTotalStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelTotalCourses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Location = new System.Drawing.Point(267, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1817, 72);
            this.panelTitle.TabIndex = 12;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(15, 12);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(278, 46);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "Головна форма";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.panelMenu.Controls.Add(this.panelViewStudents);
            this.panelMenu.Controls.Add(this.btnViewStudents);
            this.panelMenu.Controls.Add(this.panelViewSchedule);
            this.panelMenu.Controls.Add(this.panelViewPlaces);
            this.panelMenu.Controls.Add(this.panelViewGroups);
            this.panelMenu.Controls.Add(this.panelViewSpecializations);
            this.panelMenu.Controls.Add(this.panelViewInstructors);
            this.panelMenu.Controls.Add(this.panelViewGrades);
            this.panelMenu.Controls.Add(this.btnViewSchedule);
            this.panelMenu.Controls.Add(this.btnExit);
            this.panelMenu.Controls.Add(this.btnViewPlaces);
            this.panelMenu.Controls.Add(this.btnViewGroups);
            this.panelMenu.Controls.Add(this.btnViewSpecializations);
            this.panelMenu.Controls.Add(this.btnViewInstructors);
            this.panelMenu.Controls.Add(this.btnViewGrades);
            this.panelMenu.Controls.Add(this.btnViewCourses);
            this.panelMenu.Location = new System.Drawing.Point(0, 72);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(267, 966);
            this.panelMenu.TabIndex = 13;
            // 
            // panelViewSchedule
            // 
            this.panelViewSchedule.BackColor = System.Drawing.Color.White;
            this.panelViewSchedule.Location = new System.Drawing.Point(0, 490);
            this.panelViewSchedule.Name = "panelViewSchedule";
            this.panelViewSchedule.Size = new System.Drawing.Size(8, 70);
            this.panelViewSchedule.TabIndex = 30;
            this.panelViewSchedule.Visible = false;
            // 
            // panelViewPlaces
            // 
            this.panelViewPlaces.BackColor = System.Drawing.Color.White;
            this.panelViewPlaces.Location = new System.Drawing.Point(0, 420);
            this.panelViewPlaces.Name = "panelViewPlaces";
            this.panelViewPlaces.Size = new System.Drawing.Size(8, 70);
            this.panelViewPlaces.TabIndex = 29;
            this.panelViewPlaces.Visible = false;
            // 
            // panelViewGroups
            // 
            this.panelViewGroups.BackColor = System.Drawing.Color.White;
            this.panelViewGroups.Location = new System.Drawing.Point(0, 70);
            this.panelViewGroups.Name = "panelViewGroups";
            this.panelViewGroups.Size = new System.Drawing.Size(8, 70);
            this.panelViewGroups.TabIndex = 28;
            this.panelViewGroups.Visible = false;
            // 
            // panelViewSpecializations
            // 
            this.panelViewSpecializations.BackColor = System.Drawing.Color.White;
            this.panelViewSpecializations.Location = new System.Drawing.Point(0, 140);
            this.panelViewSpecializations.Name = "panelViewSpecializations";
            this.panelViewSpecializations.Size = new System.Drawing.Size(8, 70);
            this.panelViewSpecializations.TabIndex = 27;
            this.panelViewSpecializations.Visible = false;
            // 
            // panelViewInstructors
            // 
            this.panelViewInstructors.BackColor = System.Drawing.Color.White;
            this.panelViewInstructors.Location = new System.Drawing.Point(0, 210);
            this.panelViewInstructors.Name = "panelViewInstructors";
            this.panelViewInstructors.Size = new System.Drawing.Size(8, 70);
            this.panelViewInstructors.TabIndex = 26;
            this.panelViewInstructors.Visible = false;
            // 
            // panelViewGrades
            // 
            this.panelViewGrades.BackColor = System.Drawing.Color.White;
            this.panelViewGrades.Location = new System.Drawing.Point(0, 350);
            this.panelViewGrades.Name = "panelViewGrades";
            this.panelViewGrades.Size = new System.Drawing.Size(8, 70);
            this.panelViewGrades.TabIndex = 10;
            this.panelViewGrades.Visible = false;
            // 
            // panelViewStudents
            // 
            this.panelViewStudents.BackColor = System.Drawing.Color.White;
            this.panelViewStudents.Location = new System.Drawing.Point(0, 280);
            this.panelViewStudents.Name = "panelViewStudents";
            this.panelViewStudents.Size = new System.Drawing.Size(8, 70);
            this.panelViewStudents.TabIndex = 9;
            this.panelViewStudents.Visible = false;
            // 
            // btnViewSchedule
            // 
            this.btnViewSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewSchedule.FlatAppearance.BorderSize = 0;
            this.btnViewSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewSchedule.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnViewSchedule.ForeColor = System.Drawing.Color.White;
            this.btnViewSchedule.Image = global::ITAcademyManager.Properties.Resources.schedule_icon_mini;
            this.btnViewSchedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewSchedule.Location = new System.Drawing.Point(0, 490);
            this.btnViewSchedule.Name = "btnViewSchedule";
            this.btnViewSchedule.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnViewSchedule.Size = new System.Drawing.Size(267, 70);
            this.btnViewSchedule.TabIndex = 25;
            this.btnViewSchedule.Text = "  Розклад";
            this.btnViewSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewSchedule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewSchedule.UseVisualStyleBackColor = true;
            this.btnViewSchedule.Click += new System.EventHandler(this.btnViewSchedule_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::ITAcademyManager.Properties.Resources.logout_icon_mini;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 560);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(267, 70);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "  Вихід";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnViewPlaces
            // 
            this.btnViewPlaces.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewPlaces.FlatAppearance.BorderSize = 0;
            this.btnViewPlaces.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewPlaces.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnViewPlaces.ForeColor = System.Drawing.Color.White;
            this.btnViewPlaces.Image = global::ITAcademyManager.Properties.Resources.place_icon_mini;
            this.btnViewPlaces.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewPlaces.Location = new System.Drawing.Point(0, 420);
            this.btnViewPlaces.Name = "btnViewPlaces";
            this.btnViewPlaces.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnViewPlaces.Size = new System.Drawing.Size(267, 70);
            this.btnViewPlaces.TabIndex = 23;
            this.btnViewPlaces.Text = "  Місця";
            this.btnViewPlaces.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewPlaces.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewPlaces.UseVisualStyleBackColor = true;
            this.btnViewPlaces.Click += new System.EventHandler(this.btnViewPlaces_Click);
            // 
            // btnViewGroups
            // 
            this.btnViewGroups.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewGroups.FlatAppearance.BorderSize = 0;
            this.btnViewGroups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewGroups.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnViewGroups.ForeColor = System.Drawing.Color.White;
            this.btnViewGroups.Image = global::ITAcademyManager.Properties.Resources.group_icon_mini;
            this.btnViewGroups.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewGroups.Location = new System.Drawing.Point(0, 70);
            this.btnViewGroups.Name = "btnViewGroups";
            this.btnViewGroups.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnViewGroups.Size = new System.Drawing.Size(267, 70);
            this.btnViewGroups.TabIndex = 22;
            this.btnViewGroups.Text = "  Групи";
            this.btnViewGroups.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewGroups.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewGroups.UseVisualStyleBackColor = true;
            this.btnViewGroups.Click += new System.EventHandler(this.btnViewGroups_Click);
            // 
            // btnViewSpecializations
            // 
            this.btnViewSpecializations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewSpecializations.FlatAppearance.BorderSize = 0;
            this.btnViewSpecializations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewSpecializations.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnViewSpecializations.ForeColor = System.Drawing.Color.White;
            this.btnViewSpecializations.Image = global::ITAcademyManager.Properties.Resources.specialization_icon_mini;
            this.btnViewSpecializations.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewSpecializations.Location = new System.Drawing.Point(0, 140);
            this.btnViewSpecializations.Name = "btnViewSpecializations";
            this.btnViewSpecializations.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnViewSpecializations.Size = new System.Drawing.Size(267, 70);
            this.btnViewSpecializations.TabIndex = 21;
            this.btnViewSpecializations.Text = "  Спеціальності";
            this.btnViewSpecializations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewSpecializations.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewSpecializations.UseVisualStyleBackColor = true;
            this.btnViewSpecializations.Click += new System.EventHandler(this.btnViewSpecializations_Click);
            // 
            // btnViewInstructors
            // 
            this.btnViewInstructors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewInstructors.FlatAppearance.BorderSize = 0;
            this.btnViewInstructors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewInstructors.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnViewInstructors.ForeColor = System.Drawing.Color.White;
            this.btnViewInstructors.Image = global::ITAcademyManager.Properties.Resources.instructor_icon_mini;
            this.btnViewInstructors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewInstructors.Location = new System.Drawing.Point(0, 210);
            this.btnViewInstructors.Name = "btnViewInstructors";
            this.btnViewInstructors.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnViewInstructors.Size = new System.Drawing.Size(267, 70);
            this.btnViewInstructors.TabIndex = 20;
            this.btnViewInstructors.Text = "  Викладачі";
            this.btnViewInstructors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewInstructors.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewInstructors.UseVisualStyleBackColor = true;
            this.btnViewInstructors.Click += new System.EventHandler(this.btnViewInstructors_Click);
            // 
            // btnViewGrades
            // 
            this.btnViewGrades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewGrades.FlatAppearance.BorderSize = 0;
            this.btnViewGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewGrades.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnViewGrades.ForeColor = System.Drawing.Color.White;
            this.btnViewGrades.Image = global::ITAcademyManager.Properties.Resources.grade_icon_mini;
            this.btnViewGrades.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewGrades.Location = new System.Drawing.Point(0, 350);
            this.btnViewGrades.Name = "btnViewGrades";
            this.btnViewGrades.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnViewGrades.Size = new System.Drawing.Size(267, 70);
            this.btnViewGrades.TabIndex = 19;
            this.btnViewGrades.Text = "  Оцінки";
            this.btnViewGrades.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewGrades.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewGrades.UseVisualStyleBackColor = true;
            this.btnViewGrades.Click += new System.EventHandler(this.btnViewGrades_Click);
            // 
            // btnViewStudents
            // 
            this.btnViewStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btnViewStudents.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnViewStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewStudents.FlatAppearance.BorderSize = 0;
            this.btnViewStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewStudents.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnViewStudents.ForeColor = System.Drawing.Color.White;
            this.btnViewStudents.Image = global::ITAcademyManager.Properties.Resources.student_icon_mini;
            this.btnViewStudents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewStudents.Location = new System.Drawing.Point(0, 280);
            this.btnViewStudents.Name = "btnViewStudents";
            this.btnViewStudents.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnViewStudents.Size = new System.Drawing.Size(267, 70);
            this.btnViewStudents.TabIndex = 18;
            this.btnViewStudents.Text = "  Студенти";
            this.btnViewStudents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewStudents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewStudents.UseVisualStyleBackColor = false;
            this.btnViewStudents.Click += new System.EventHandler(this.btnViewStudents_Click);
            // 
            // btnViewCourses
            // 
            this.btnViewCourses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnViewCourses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewCourses.FlatAppearance.BorderSize = 0;
            this.btnViewCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewCourses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnViewCourses.ForeColor = System.Drawing.Color.White;
            this.btnViewCourses.Image = global::ITAcademyManager.Properties.Resources.course_icon_mini;
            this.btnViewCourses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewCourses.Location = new System.Drawing.Point(0, 0);
            this.btnViewCourses.Name = "btnViewCourses";
            this.btnViewCourses.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnViewCourses.Size = new System.Drawing.Size(267, 70);
            this.btnViewCourses.TabIndex = 17;
            this.btnViewCourses.Text = "  Курси";
            this.btnViewCourses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewCourses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewCourses.UseVisualStyleBackColor = true;
            this.btnViewCourses.Click += new System.EventHandler(this.btnViewCourses_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.mainPanel.Controls.Add(this.chartGroupCapacity);
            this.mainPanel.Controls.Add(this.chartSuccess);
            this.mainPanel.Controls.Add(this.panelTotalScheduled);
            this.mainPanel.Controls.Add(this.panelTotalInstructors);
            this.mainPanel.Controls.Add(this.panelTotalStudents);
            this.mainPanel.Controls.Add(this.panelTotalCourses);
            this.mainPanel.Location = new System.Drawing.Point(267, 72);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1320, 966);
            this.mainPanel.TabIndex = 15;
            // 
            // chartGroupCapacity
            // 
            chartArea1.Name = "ChartArea1";
            this.chartGroupCapacity.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartGroupCapacity.Legends.Add(legend1);
            this.chartGroupCapacity.Location = new System.Drawing.Point(640, 221);
            this.chartGroupCapacity.Name = "chartGroupCapacity";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartGroupCapacity.Series.Add(series1);
            this.chartGroupCapacity.Size = new System.Drawing.Size(605, 444);
            this.chartGroupCapacity.TabIndex = 18;
            this.chartGroupCapacity.Text = "chart1";
            // 
            // chartSuccess
            // 
            chartArea2.Name = "ChartArea1";
            this.chartSuccess.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartSuccess.Legends.Add(legend2);
            this.chartSuccess.Location = new System.Drawing.Point(15, 221);
            this.chartSuccess.Name = "chartSuccess";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartSuccess.Series.Add(series2);
            this.chartSuccess.Size = new System.Drawing.Size(601, 444);
            this.chartSuccess.TabIndex = 17;
            this.chartSuccess.Text = "chart1";
            // 
            // panelTotalScheduled
            // 
            this.panelTotalScheduled.BackColor = System.Drawing.Color.DarkOrchid;
            this.panelTotalScheduled.Controls.Add(this.labelTotalScheduled);
            this.panelTotalScheduled.Controls.Add(this.pictureBox4);
            this.panelTotalScheduled.Controls.Add(this.label5);
            this.panelTotalScheduled.Location = new System.Drawing.Point(955, 35);
            this.panelTotalScheduled.MaximumSize = new System.Drawing.Size(345, 134);
            this.panelTotalScheduled.Name = "panelTotalScheduled";
            this.panelTotalScheduled.Size = new System.Drawing.Size(290, 134);
            this.panelTotalScheduled.TabIndex = 15;
            // 
            // labelTotalScheduled
            // 
            this.labelTotalScheduled.AutoSize = true;
            this.labelTotalScheduled.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.labelTotalScheduled.ForeColor = System.Drawing.Color.White;
            this.labelTotalScheduled.Location = new System.Drawing.Point(10, 12);
            this.labelTotalScheduled.Name = "labelTotalScheduled";
            this.labelTotalScheduled.Size = new System.Drawing.Size(159, 62);
            this.labelTotalScheduled.TabIndex = 10;
            this.labelTotalScheduled.Text = "label1";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackgroundImage = global::ITAcademyManager.Properties.Resources.schedule_icon;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(217, 22);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(48, 48);
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(258, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "Заплановані заняття";
            // 
            // panelTotalInstructors
            // 
            this.panelTotalInstructors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(123)))), ((int)(((byte)(34)))));
            this.panelTotalInstructors.Controls.Add(this.labelTotalInstructors);
            this.panelTotalInstructors.Controls.Add(this.pictureBox3);
            this.panelTotalInstructors.Controls.Add(this.label3);
            this.panelTotalInstructors.Location = new System.Drawing.Point(640, 35);
            this.panelTotalInstructors.MaximumSize = new System.Drawing.Size(345, 134);
            this.panelTotalInstructors.Name = "panelTotalInstructors";
            this.panelTotalInstructors.Size = new System.Drawing.Size(290, 134);
            this.panelTotalInstructors.TabIndex = 14;
            // 
            // labelTotalInstructors
            // 
            this.labelTotalInstructors.AutoSize = true;
            this.labelTotalInstructors.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.labelTotalInstructors.ForeColor = System.Drawing.Color.White;
            this.labelTotalInstructors.Location = new System.Drawing.Point(10, 12);
            this.labelTotalInstructors.Name = "labelTotalInstructors";
            this.labelTotalInstructors.Size = new System.Drawing.Size(159, 62);
            this.labelTotalInstructors.TabIndex = 10;
            this.labelTotalInstructors.Text = "label1";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackgroundImage = global::ITAcademyManager.Properties.Resources.instructor_icon;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(217, 22);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 48);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 37);
            this.label3.TabIndex = 10;
            this.label3.Text = "Викладачі";
            // 
            // panelTotalStudents
            // 
            this.panelTotalStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(35)))), ((int)(((byte)(58)))));
            this.panelTotalStudents.Controls.Add(this.labelTotalStudents);
            this.panelTotalStudents.Controls.Add(this.pictureBox2);
            this.panelTotalStudents.Controls.Add(this.label2);
            this.panelTotalStudents.Location = new System.Drawing.Point(326, 35);
            this.panelTotalStudents.MaximumSize = new System.Drawing.Size(290, 134);
            this.panelTotalStudents.Name = "panelTotalStudents";
            this.panelTotalStudents.Size = new System.Drawing.Size(290, 134);
            this.panelTotalStudents.TabIndex = 13;
            // 
            // labelTotalStudents
            // 
            this.labelTotalStudents.AutoSize = true;
            this.labelTotalStudents.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.labelTotalStudents.ForeColor = System.Drawing.Color.White;
            this.labelTotalStudents.Location = new System.Drawing.Point(5, 12);
            this.labelTotalStudents.Name = "labelTotalStudents";
            this.labelTotalStudents.Size = new System.Drawing.Size(159, 62);
            this.labelTotalStudents.TabIndex = 8;
            this.labelTotalStudents.Text = "label1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackgroundImage = global::ITAcademyManager.Properties.Resources.student_icon;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(217, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 37);
            this.label2.TabIndex = 10;
            this.label2.Text = "Студенти";
            // 
            // panelTotalCourses
            // 
            this.panelTotalCourses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
            this.panelTotalCourses.Controls.Add(this.labelTotalCourses);
            this.panelTotalCourses.Controls.Add(this.pictureBox1);
            this.panelTotalCourses.Controls.Add(this.label1);
            this.panelTotalCourses.Location = new System.Drawing.Point(15, 35);
            this.panelTotalCourses.MaximumSize = new System.Drawing.Size(340, 134);
            this.panelTotalCourses.Name = "panelTotalCourses";
            this.panelTotalCourses.Size = new System.Drawing.Size(290, 134);
            this.panelTotalCourses.TabIndex = 12;
            // 
            // labelTotalCourses
            // 
            this.labelTotalCourses.AutoSize = true;
            this.labelTotalCourses.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.labelTotalCourses.ForeColor = System.Drawing.Color.White;
            this.labelTotalCourses.Location = new System.Drawing.Point(7, 12);
            this.labelTotalCourses.Name = "labelTotalCourses";
            this.labelTotalCourses.Size = new System.Drawing.Size(159, 62);
            this.labelTotalCourses.TabIndex = 9;
            this.labelTotalCourses.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::ITAcademyManager.Properties.Resources.course_icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(217, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Курси";
            // 
            // panelViewCourses
            // 
            this.panelViewCourses.BackColor = System.Drawing.Color.White;
            this.panelViewCourses.Location = new System.Drawing.Point(0, 72);
            this.panelViewCourses.Name = "panelViewCourses";
            this.panelViewCourses.Size = new System.Drawing.Size(8, 70);
            this.panelViewCourses.TabIndex = 8;
            this.panelViewCourses.Visible = false;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.btnHome.BackgroundImage = global::ITAcademyManager.Properties.Resources.IT_ACADEMY_Manager_mini;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(267, 72);
            this.btnHome.TabIndex = 14;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1918, 985);
            this.Controls.Add(this.panelViewCourses);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1918, 985);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IT Academy Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartGroupCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSuccess)).EndInit();
            this.panelTotalScheduled.ResumeLayout(false);
            this.panelTotalScheduled.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panelTotalInstructors.ResumeLayout(false);
            this.panelTotalInstructors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelTotalStudents.ResumeLayout(false);
            this.panelTotalStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelTotalCourses.ResumeLayout(false);
            this.panelTotalCourses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button btnViewCourses;
        private System.Windows.Forms.Button btnViewStudents;
        private System.Windows.Forms.Button btnViewGrades;
        private System.Windows.Forms.Button btnViewInstructors;
        private System.Windows.Forms.Button btnViewPlaces;
        private System.Windows.Forms.Button btnViewGroups;
        private System.Windows.Forms.Button btnViewSpecializations;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnViewSchedule;
        private System.Windows.Forms.Panel panelViewCourses;
        private System.Windows.Forms.Panel panelViewStudents;
        private System.Windows.Forms.Panel panelViewGrades;
        private System.Windows.Forms.Panel panelViewInstructors;
        private System.Windows.Forms.Panel panelViewSpecializations;
        private System.Windows.Forms.Panel panelViewGroups;
        private System.Windows.Forms.Panel panelViewPlaces;
        private System.Windows.Forms.Panel panelViewSchedule;
        private System.Windows.Forms.Panel panelTotalCourses;
        private System.Windows.Forms.Label labelTotalCourses;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTotalStudents;
        private System.Windows.Forms.Label labelTotalStudents;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelTotalInstructors;
        private System.Windows.Forms.Label labelTotalInstructors;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelTotalScheduled;
        private System.Windows.Forms.Label labelTotalScheduled;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSuccess;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGroupCapacity;
    }
}

