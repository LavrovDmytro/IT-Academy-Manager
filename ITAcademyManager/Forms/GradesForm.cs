using ITAcademyManager.Styles;
using System;
using System.Windows.Forms;

namespace ITAcademyManager
{
    public partial class GradesForm : Form
    {
        private readonly GradeService _gradeService = new GradeService();

        public GradesForm()
        {
            InitializeComponent();
            LoadCoursesComboBox();

            DataGridViewStyler.ApplyDefaultStyles(dataGridViewGrades);
        }

        private void LoadCoursesComboBox()
        {
            var courses = _gradeService.LoadCourses();
            comboBoxCourses.DataSource = courses;
            comboBoxCourses.DisplayMember = "CourseName";
            comboBoxCourses.ValueMember = "CourseID";
            comboBoxCourses.SelectedIndex = -1;
        }

        private void LoadGroupsComboBox(int courseID)
        {
            var groups = _gradeService.LoadGroupsByCourse(courseID);
            comboBoxGroups.DataSource = groups;
            comboBoxGroups.DisplayMember = "GroupName";
            comboBoxGroups.ValueMember = "GroupID";
            comboBoxGroups.SelectedIndex = -1;
        }

        private void LoadStudentsComboBox(int groupID)
        {
            var students = _gradeService.LoadStudentsByGroup(groupID);
            comboBoxStudents.DataSource = students;
            comboBoxStudents.DisplayMember = "FullName";
            comboBoxStudents.ValueMember = "StudentID";
            comboBoxStudents.SelectedIndex = -1;
        }

        private void LoadGradesForStudent(int studentID)
        {
            var grades = _gradeService.LoadGradesForStudent(studentID);
            dataGridViewGrades.DataSource = grades;
        }

        private void UpdateAverageGrade(int studentID)
        {
            double averageGrade = _gradeService.CalculateAverageGrade(studentID);
            labelAverageGrade.Text = $"Середня оцінка: {averageGrade:F2}";
        }

        private void LoadStudentGrades(int studentID)
        {
            LoadGradesForStudent(studentID);
            UpdateAverageGrade(studentID);
        }

        private void comboBoxCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCourses.SelectedValue != null && int.TryParse(comboBoxCourses.SelectedValue.ToString(), out int courseID))
            {
                LoadGroupsComboBox(courseID);
            }
        }

        private void comboBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxGroups.SelectedValue != null && int.TryParse(comboBoxGroups.SelectedValue.ToString(), out int groupID))
            {
                LoadStudentsComboBox(groupID);
            }
        }

        private void comboBoxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxStudents.SelectedValue != null && int.TryParse(comboBoxStudents.SelectedValue.ToString(), out int studentID))
            {
                LoadStudentGrades(studentID);
            }
        }

        private void btnAddGrade_Click(object sender, EventArgs e)
        {
            if (!IsInputValid()) return;

            int studentID = (int)comboBoxStudents.SelectedValue;
            decimal grade = Convert.ToDecimal(textBoxGrade.Text);
            DateTime date = dateTimePickerDate.Value;

            if (!IsGradeValid(grade)) return;

            try
            {
                _gradeService.AddGrade(studentID, grade, date);
                LoadStudentGrades(studentID);
                ClearFields();

                var mainForm = Application.OpenForms["MainForm"] as MainForm;
                mainForm?.LoadAverageGradesChart();

                ShowSuccessMessage("Оцінка успішно додана.");
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        private void btnEditGrade_Click(object sender, EventArgs e)
        {
            if (dataGridViewGrades.SelectedCells.Count == 0)
            {
                ShowErrorMessage("Будь ласка, оберіть комірку оцінки для редагування.");
                return;
            }

            if (!IsInputValid())
            {
                return;
            }

            int rowIndex = dataGridViewGrades.SelectedCells[0].RowIndex;
            int gradeID = Convert.ToInt32(dataGridViewGrades.Rows[rowIndex].Cells["GradeID"].Value);
            int studentID = (int)comboBoxStudents.SelectedValue;
            decimal grade = Convert.ToDecimal(textBoxGrade.Text);
            DateTime date = dateTimePickerDate.Value;

            if (!IsGradeValid(grade))
            {
                return;
            }

            try
            {
                _gradeService.EditGrade(gradeID, studentID, grade, date);
                LoadStudentGrades(studentID);
                ClearFields();

                var mainForm = Application.OpenForms["MainForm"] as MainForm;
                mainForm?.LoadAverageGradesChart();

                ShowSuccessMessage("Оцінка успішно відредагована.");
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Помилка при редагуванні оцінки: {ex.Message}");
            }
        }

        private void btnDeleteGrade_Click(object sender, EventArgs e)
        {
            if (dataGridViewGrades.SelectedCells.Count == 0)
            {
                ShowErrorMessage("Будь ласка, оберіть комірку оцінки для видалення.");
                return;
            }

            int rowIndex = dataGridViewGrades.SelectedCells[0].RowIndex;
            int gradeID = Convert.ToInt32(dataGridViewGrades.Rows[rowIndex].Cells["GradeID"].Value);

            var result = MessageBox.Show(
                "Ви впевнені, що хочете видалити цю оцінку?",
                "Підтвердження видалення",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    int studentID = (int)comboBoxStudents.SelectedValue;
                    _gradeService.DeleteGrade(gradeID);
                    LoadStudentGrades(studentID);
                    ClearFields();

                    var mainForm = Application.OpenForms["MainForm"] as MainForm;
                    mainForm?.LoadAverageGradesChart();

                    ShowSuccessMessage("Оцінка успішно видалена.");
                }
                catch (Exception ex)
                {
                    ShowErrorMessage($"Помилка при видаленні оцінки: {ex.Message}");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dataGridViewGrades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewGrades.Rows[e.RowIndex];
                textBoxGradeID.Text = row.Cells["GradeID"].Value.ToString();
                textBoxGrade.Text = row.Cells["Grade"].Value.ToString();
                dateTimePickerDate.Value = Convert.ToDateTime(row.Cells["Date"].Value);
            }
        }

        private bool IsInputValid()
        {
            if (comboBoxStudents.SelectedIndex == -1)
            {
                ShowErrorMessage("Будь ласка, оберіть студента.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxGrade.Text) || !decimal.TryParse(textBoxGrade.Text, out _))
            {
                ShowErrorMessage("Будь ласка, введіть дійсну оцінку.");
                return false;
            }

            return true;
        }

        private bool IsGradeValid(decimal grade)
        {
            if (grade < 0 || grade > 100)
            {
                ShowErrorMessage("Оцінка повинна бути в діапазоні від 0 до 100.");
                return false;
            }
            return true;
        }

        private void ClearFields()
        {
            textBoxGradeID.Text = "";
            textBoxGrade.Text = "";
            dateTimePickerDate.Value = DateTime.Now;
        }

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowSuccessMessage(string message)
        {
            MessageBox.Show(message, "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}