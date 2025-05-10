using ITAcademyManager.Styles;
using System;
using System.Windows.Forms;

namespace ITAcademyManager
{
    public partial class StudentsForm : Form
    {
        private readonly StudentService _studentService = new StudentService();

        public StudentsForm()
        {
            InitializeComponent();
            LoadStudents();
            LoadGroupsComboBox();

            DataGridViewStyler.ApplyDefaultStyles(dataGridViewStudents);
        }

        private void LoadStudents()
        {
            var students = _studentService.LoadStudents();
            dataGridViewStudents.DataSource = students;

            dataGridViewStudents.Columns["GroupName"].HeaderText = "GroupName";
        }

        private void LoadGroupsComboBox()
        {
            var groups = _studentService.LoadGroups();
            comboBoxGroups.DataSource = groups;
            comboBoxGroups.DisplayMember = "GroupName";
            comboBoxGroups.ValueMember = "GroupID";
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (IsInputValid())
            {
                int? groupID = comboBoxGroups.SelectedIndex == -1 ? (int?)null : (int)comboBoxGroups.SelectedValue;
                string firstName = textBoxFirstName.Text;
                string lastName = textBoxLastName.Text;
                string email = textBoxEmail.Text;
                string phone = textBoxPhone.Text;
                DateTime dateOfBirth = dateTimePickerDOB.Value;

                try
                {
                    _studentService.AddStudent(groupID, firstName, lastName, email, phone, dateOfBirth);
                    LoadStudents();
                    ClearFields();

                    var mainForm = Application.OpenForms["MainForm"] as MainForm;
                    mainForm?.LoadGroupCapacityChart();

                    ShowSuccessMessage("Студент успішно доданий.");
                }
                catch (Exception ex)
                {
                    ShowErrorMessage(ex.Message);
                }
            }
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudents.SelectedCells.Count == 0)
            {
                ShowErrorMessage("Будь ласка, оберіть комірку студента для редагування.");
                return;
            }

            if (!IsInputValid())
            {
                return;
            }

            int rowIndex = dataGridViewStudents.SelectedCells[0].RowIndex;
            int studentID = Convert.ToInt32(dataGridViewStudents.Rows[rowIndex].Cells["StudentID"].Value);
            int? groupID = comboBoxGroups.SelectedIndex == -1 ? (int?)null : (int)comboBoxGroups.SelectedValue;
            string firstName = textBoxFirstName.Text.Trim();
            string lastName = textBoxLastName.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            string phone = textBoxPhone.Text.Trim();
            DateTime dateOfBirth = dateTimePickerDOB.Value;

            try
            {
                _studentService.EditStudent(studentID, groupID, firstName, lastName, email, phone, dateOfBirth);
                LoadStudents();
                ClearFields();

                var mainForm = Application.OpenForms["MainForm"] as MainForm;
                mainForm?.LoadGroupCapacityChart();

                ShowSuccessMessage("Студент успішно відредагований.");
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Помилка при редагуванні студента: {ex.Message}");
            }
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudents.SelectedCells.Count == 0)
            {
                ShowErrorMessage("Будь ласка, оберіть комірку студента для видалення.");
                return;
            }

            int rowIndex = dataGridViewStudents.SelectedCells[0].RowIndex;
            int studentID = Convert.ToInt32(dataGridViewStudents.Rows[rowIndex].Cells["StudentID"].Value);

            var result = MessageBox.Show(
                "Ви впевнені, що хочете видалити цього студента?",
                "Підтвердження видалення",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    _studentService.DeleteStudent(studentID);
                    LoadStudents();
                    ClearFields();

                    var mainForm = Application.OpenForms["MainForm"] as MainForm;
                    mainForm?.LoadGroupCapacityChart();
                    mainForm?.LoadAverageGradesChart();

                    ShowSuccessMessage("Студент успішно видалений.");
                }
                catch (Exception ex)
                {
                    ShowErrorMessage($"Помилка при видаленні студента: {ex.Message}");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dataGridViewStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridViewStudents.Rows[e.RowIndex];
                textBoxStudentID.Text = row.Cells["StudentID"].Value.ToString();
                textBoxGroupID.Text = row.Cells["GroupID"].Value.ToString();
                textBoxFirstName.Text = row.Cells["FirstName"].Value.ToString();
                textBoxLastName.Text = row.Cells["LastName"].Value.ToString();
                textBoxEmail.Text = row.Cells["Email"].Value.ToString();
                textBoxPhone.Text = row.Cells["Phone"].Value.ToString();
                dateTimePickerDOB.Value = Convert.ToDateTime(row.Cells["DateOfBirth"].Value);

                if (row.Cells["GroupID"].Value != DBNull.Value && Convert.ToInt32(row.Cells["GroupID"].Value) != 0)
                {
                    comboBoxGroups.SelectedValue = row.Cells["GroupID"].Value;
                }
                else
                {
                    comboBoxGroups.SelectedIndex = -1;
                }
            }
        }
        private bool IsInputValid()
        {
            if (string.IsNullOrWhiteSpace(textBoxFirstName.Text))
            {
                ShowErrorMessage("Будь ласка, введіть ім'я студента.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxLastName.Text))
            {
                ShowErrorMessage("Будь ласка, введіть прізвище студента.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                ShowErrorMessage("Будь ласка, введіть email студента.");
                return false;
            }

            if (!_studentService.IsEmailValid(textBoxEmail.Text))
            {
                ShowErrorMessage("Невірний формат email. Введіть коректний email.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxPhone.Text))
            {
                ShowErrorMessage("Будь ласка, введіть телефон студента.");
                return false;
            }

            if (dateTimePickerDOB.Value > DateTime.Now)
            {
                ShowErrorMessage("Дата народження не може бути пізніше поточної дати.");
                return false;
            }

            return true;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = textBoxSearch.Text.Trim();
            var filteredStudents = _studentService.FilterStudents(searchQuery);
            dataGridViewStudents.DataSource = filteredStudents;
        }

        private void ClearFields()
        {
            textBoxStudentID.Text = "";
            textBoxGroupID.Text = "";
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxEmail.Text = "";
            textBoxPhone.Text = "";
            dateTimePickerDOB.Value = DateTime.Now;

            if (comboBoxGroups.Items.Count > 0)
            {
                comboBoxGroups.SelectedIndex = 0;
            }
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