using ITAcademyManager.Styles;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ITAcademyManager
{
    public partial class CoursesForm : Form
    {
        private readonly CourseService _courseService = new CourseService();

        public CoursesForm()
        {
            InitializeComponent();
            LoadCourses();

            DataGridViewStyler.ApplyDefaultStyles(dataGridViewCourses);
        }

        private void LoadCourses()
        {
            var courses = _courseService.LoadCourses();
            dataGridViewCourses.DataSource = courses;
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            if (IsInputValid() && ValidateDates())
            {
                try
                {
                    _courseService.AddCourse(textBoxCourseName.Text, Convert.ToDecimal(textBoxPrice.Text), dateTimePickerStartDate.Value, dateTimePickerEndDate.Value);
                    LoadCourses();
                    ClearFields();

                    var mainForm = Application.OpenForms["MainForm"] as MainForm;
                    mainForm?.LoadAverageGradesChart();
                    mainForm?.LoadGroupCapacityChart();

                    ShowSuccessMessage("Курс успішно додано.");
                }
                catch (Exception ex)
                {
                    ShowErrorMessage($"Помилка при додаванні курсу: {ex.Message}");
                }
            }
        }

        private void btnEditCourse_Click(object sender, EventArgs e)
        {
            if (dataGridViewCourses.SelectedCells.Count == 0)
            {
                ShowErrorMessage("Будь ласка, оберіть комірку курсу для редагування.");
                return;
            }

            if (!IsInputValid() || !ValidateDates())
            {
                return;
            }

            int rowIndex = dataGridViewCourses.SelectedCells[0].RowIndex;
            int courseID = Convert.ToInt32(dataGridViewCourses.Rows[rowIndex].Cells["CourseID"].Value);
            string courseName = textBoxCourseName.Text;
            decimal price = Convert.ToDecimal(textBoxPrice.Text);
            DateTime startDate = dateTimePickerStartDate.Value;
            DateTime endDate = dateTimePickerEndDate.Value;

            try
            {
                _courseService.EditCourse(courseID, courseName, price, startDate, endDate);
                LoadCourses();
                ClearFields();

                var mainForm = Application.OpenForms["MainForm"] as MainForm;
                mainForm?.LoadAverageGradesChart();
                mainForm?.LoadGroupCapacityChart();

                ShowSuccessMessage("Курс успішно відредаговано.");
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Помилка при редагуванні курсу: {ex.Message}");
            }
        }

        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            if (dataGridViewCourses.SelectedCells.Count == 0)
            {
                ShowErrorMessage("Будь ласка, оберіть комірку курсу для видалення.");
                return;
            }

            int rowIndex = dataGridViewCourses.SelectedCells[0].RowIndex;
            int courseID = Convert.ToInt32(dataGridViewCourses.Rows[rowIndex].Cells["CourseID"].Value);

            var result = MessageBox.Show(
                "Видалення курсу призведе до видалення всіх пов'язаних даних. Ви впевнені?",
                "Попередження",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    _courseService.DeleteRelatedData(courseID);
                    _courseService.DeleteCourse(courseID);
                    LoadCourses();
                    ClearFields();

                    var mainForm = Application.OpenForms["MainForm"] as MainForm;
                    mainForm?.LoadAverageGradesChart();
                    mainForm?.LoadGroupCapacityChart();

                    ShowSuccessMessage("Курс та всі пов'язані дані успішно видалено.");
                }
                catch (Exception ex)
                {
                    ShowErrorMessage($"Помилка при видаленні курсу: {ex.Message}");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dataGridViewCourses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewCourses.Rows[e.RowIndex];
                textBoxCourseID.Text = row.Cells["CourseID"].Value.ToString();
                textBoxCourseName.Text = row.Cells["CourseName"].Value.ToString();
                textBoxPrice.Text = row.Cells["Price"].Value.ToString();
                dateTimePickerStartDate.Value = Convert.ToDateTime(row.Cells["StartDate"].Value);
                dateTimePickerEndDate.Value = Convert.ToDateTime(row.Cells["EndDate"].Value);
            }
        }

        private bool IsInputValid()
        {
            if (string.IsNullOrWhiteSpace(textBoxCourseName.Text))
            {
                ShowErrorMessage("Назва курсу не може бути пустою.");
                return false;
            }

            if (!decimal.TryParse(textBoxPrice.Text, out var price) || price < 0 || price > 99999999.99m)
            {
                ShowErrorMessage("Будь ласка, введіть коректну ціну (ціна не може бути від'ємною).");
                return false;
            }

            return true;
        }

        private bool ValidateDates()
        {
            if (dateTimePickerEndDate.Value < dateTimePickerStartDate.Value)
            {
                ShowErrorMessage("Дата завершення не може бути раніше дати початку.");
                return false;
            }
            return true;
        }

        private void ClearFields()
        {
            textBoxCourseID.Text = "";
            textBoxCourseName.Text = "";
            textBoxPrice.Text = "";
            dateTimePickerStartDate.Value = DateTime.Now;
            dateTimePickerEndDate.Value = DateTime.Now;
        }

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowSuccessMessage(string message)
        {
            MessageBox.Show(message, "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            var searchQuery = Regex.Replace(textBoxSearch.Text.Trim(), @"\b(\d{1,2})\.(\d{1,2})\.(\d{4})\b", "$1/$2/$3").Replace(',', '.');
            var filteredCourses = _courseService.FilterCourses(searchQuery);
            dataGridViewCourses.DataSource = filteredCourses;
        }
    }
}