using ITAcademyManager.Services;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ITAcademyManager
{
    public partial class MainForm : Form
    {
        private readonly Color _defaultBackColor;
        private readonly Color _selectedBackColor = Color.FromArgb(8, 118, 122);

        private readonly StudentService _studentService = new StudentService();
        private readonly CourseService _courseService = new CourseService();
        private readonly InstructorService _instructorService = new InstructorService();
        private readonly ScheduleService _scheduleService = new ScheduleService();

        public MainForm()
        {
            InitializeComponent();
            InitializeCharts();
            UpdateDashboard();
        }

        private void InitializeCharts()
        {
            StyleCharts();
            LoadAverageGradesChart();
            LoadGroupCapacityChart();
        }

        public void LoadAverageGradesChart()
        {
            var data = _studentService.GetAverageGradesByCourse();
            UpdateChart(chartSuccess, data, "Середній бал студентів за курсами", "Курси", "Середній бал");
        }

        public void LoadGroupCapacityChart()
        {
            var data = _courseService.GetGroupCapacity();
            UpdateChart(chartGroupCapacity, data, "Заповненість груп студентами", "Групи", "Кількість студентів");
        }

        private void UpdateChart(Chart chart, DataTable data, string title, string xAxisTitle, string yAxisTitle)
        {
            chart.Series["Series1"].Points.Clear();

            if (chart.Titles.Count == 0)
            {
                chart.Titles.Add(title);
            }

            chart.ChartAreas[0].AxisX.Title = xAxisTitle;
            chart.ChartAreas[0].AxisY.Title = yAxisTitle;
            chart.Series["Series1"].IsVisibleInLegend = false;

            if (data.Rows.Count > 0)
            {
                foreach (DataRow row in data.Rows)
                {
                    string name = row[0].ToString();
                    double value = Convert.ToDouble(row[1]);
                    chart.Series["Series1"].Points.AddXY(name, value);
                }
            }
            else
            {
                chart.Series["Series1"].Points.AddXY("Немає даних", 0);
            }
        }

        private void StyleCharts()
        {
            ChartStyler.StyleSuccessChart(chartSuccess);
            ChartStyler.StyleGroupCapacityChart(chartGroupCapacity);
        }

        private void ShowForm(Form form, string title)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(form);
            form.BringToFront();
            form.Show();
            labelTitle.Text = title;
        }

        private void ChangeButtonColor(Button button, Color backColor)
        {
            button.BackColor = backColor;
            button.ForeColor = Color.White;
        }

        private void ResetButtonColors()
        {
            var buttons = new[] { btnViewCourses, btnViewStudents, btnViewGrades, btnViewInstructors, btnViewSpecializations, btnViewGroups, btnViewPlaces, btnViewSchedule };
            buttons.ToList().ForEach(button => ChangeButtonColor(button, _defaultBackColor));
        }

        private void OpenForm(Form form, Button button, Panel panel)
        {
            ResetButtonColors();
            ShowForm(form, button.Text);
            ChangeButtonColor(button, _selectedBackColor);
            HideAllPanels();
            panel.Visible = true;
        }

        private void HideAllPanels()
        {
            var panels = new[] { panelViewCourses, panelViewStudents, panelViewGrades, panelViewInstructors, panelViewSpecializations, panelViewGroups, panelViewPlaces, panelViewSchedule };
            panels.ToList().ForEach(panel => panel.Visible = false);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            mainPanel.Controls.Clear();
            HideAllPanels();

            mainPanel.Controls.AddRange(new Control[] { panelTotalStudents, panelTotalCourses, panelTotalInstructors, panelTotalScheduled, chartSuccess, chartGroupCapacity });
            labelTitle.Text = "Головна Форма";
            UpdateDashboard();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви впевнені, що хочете вийти?", "Підтвердження виходу", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void UpdateDashboard()
        {
            labelTotalStudents.Text = _studentService.GetTotalStudents().ToString();
            labelTotalCourses.Text = _courseService.GetTotalCourses().ToString();
            labelTotalInstructors.Text = _instructorService.GetTotalInstructors().ToString();
            labelTotalScheduled.Text = _scheduleService.GetScheduledCount().ToString();
        }

        private void btnViewCourses_Click(object sender, EventArgs e) => OpenForm(new CoursesForm(), btnViewCourses, panelViewCourses);
        private void btnViewStudents_Click(object sender, EventArgs e) => OpenForm(new StudentsForm(), btnViewStudents, panelViewStudents);
        private void btnViewGrades_Click(object sender, EventArgs e) => OpenForm(new GradesForm(), btnViewGrades, panelViewGrades);
        private void btnViewInstructors_Click(object sender, EventArgs e) => OpenForm(new InstructorsForm(), btnViewInstructors, panelViewInstructors);
        private void btnViewSpecializations_Click(object sender, EventArgs e) => OpenForm(new SpecializationsForm(), btnViewSpecializations, panelViewSpecializations);
        private void btnViewGroups_Click(object sender, EventArgs e) => OpenForm(new GroupsForm(), btnViewGroups, panelViewGroups);
        private void btnViewPlaces_Click(object sender, EventArgs e) => OpenForm(new PlacesForm(), btnViewPlaces, panelViewPlaces);
        private void btnViewSchedule_Click(object sender, EventArgs e) => OpenForm(new ScheduleForm(), btnViewSchedule, panelViewSchedule);
    }
}