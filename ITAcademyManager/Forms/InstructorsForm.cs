using ITAcademyManager.Styles;
using System;
using System.Windows.Forms;

namespace ITAcademyManager
{
    public partial class InstructorsForm : Form
    {
        private readonly InstructorService _instructorService = new InstructorService();

        public InstructorsForm()
        {
            InitializeComponent();
            LoadInstructors();
            LoadSpecializationsComboBox();

            int formWidth = this.ClientSize.Width;
            DataGridViewStyler.ApplyDefaultStylesWithWidthCheck(dataGridViewInstructors, formWidth, 1070);
        }

        private void InstructorsForm_Resize(object sender, EventArgs e)
        {
            int formWidth = this.ClientSize.Width;
            DataGridViewStyler.ApplyDefaultStylesWithWidthCheck(dataGridViewInstructors, formWidth, 1070);
        }

        private void LoadInstructors()
        {
            var instructors = _instructorService.LoadInstructors();
            dataGridViewInstructors.DataSource = instructors;
        }

        private void LoadSpecializationsComboBox()
        {
            var specializations = _instructorService.LoadSpecializations();
            comboBoxSpecializations.DataSource = specializations;
            comboBoxSpecializations.DisplayMember = "SpecializationName";
            comboBoxSpecializations.ValueMember = "SpecializationID";
        }

        private void btnAddInstructor_Click(object sender, EventArgs e)
        {
            if (IsInputValid())
            {
                int? specializationID = comboBoxSpecializations.SelectedIndex == -1 ? (int?)null : (int)comboBoxSpecializations.SelectedValue;
                string lastName = textBoxLastName.Text.Trim();
                string firstName = textBoxFirstName.Text.Trim();
                string middleName = textBoxMiddleName.Text.Trim();
                string phone = textBoxPhone.Text.Trim();
                string experience = textBoxExperience.Text.Trim();

                try
                {
                    _instructorService.AddInstructor(specializationID, lastName, firstName, middleName, phone, experience);
                    LoadInstructors();
                    ClearFields();

                    ShowSuccessMessage("Інструктор успішно доданий.");
                }
                catch (Exception ex)
                {
                    ShowErrorMessage(ex.Message);
                }
            }
        }

        private void btnEditInstructor_Click(object sender, EventArgs e)
        {
            if (dataGridViewInstructors.SelectedCells.Count == 0)
            {
                ShowErrorMessage("Будь ласка, оберіть комірку інструктора для редагування.");
                return;
            }

            if (!IsInputValid())
            {
                return;
            }

            int rowIndex = dataGridViewInstructors.SelectedCells[0].RowIndex;
            int instructorID = Convert.ToInt32(dataGridViewInstructors.Rows[rowIndex].Cells["InstructorID"].Value);
            int? specializationID = comboBoxSpecializations.SelectedIndex == -1 ? (int?)null : (int)comboBoxSpecializations.SelectedValue;
            string lastName = textBoxLastName.Text.Trim();
            string firstName = textBoxFirstName.Text.Trim();
            string middleName = textBoxMiddleName.Text.Trim();
            string phone = textBoxPhone.Text.Trim();
            string experience = textBoxExperience.Text.Trim();

            try
            {
                _instructorService.EditInstructor(instructorID, specializationID, lastName, firstName, middleName, phone, experience);
                LoadInstructors();
                ClearFields();

                ShowSuccessMessage("Інструктор успішно відредагований.");
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Помилка при редагуванні інструктора: {ex.Message}");
            }
        }

        private void btnDeleteInstructor_Click(object sender, EventArgs e)
        {
            if (dataGridViewInstructors.SelectedCells.Count == 0)
            {
                ShowErrorMessage("Будь ласка, оберіть комірку інструктора для видалення.");
                return;
            }

            int rowIndex = dataGridViewInstructors.SelectedCells[0].RowIndex;
            int instructorID = Convert.ToInt32(dataGridViewInstructors.Rows[rowIndex].Cells["InstructorID"].Value);

            var result = MessageBox.Show(
                "Ви впевнені, що хочете видалити цього інструктора?",
                "Підтвердження видалення",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    _instructorService.DeleteInstructor(instructorID);
                    LoadInstructors();
                    ClearFields();

                    ShowSuccessMessage("Інструктор успішно видалений.");
                }
                catch (Exception ex)
                {
                    ShowErrorMessage($"Помилка при видаленні інструктора: {ex.Message}");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dataGridViewInstructors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewInstructors.Rows[e.RowIndex];
                textBoxInstructorID.Text = row.Cells["InstructorID"].Value.ToString();
                textBoxSpecializationID.Text = row.Cells["SpecializationID"].Value.ToString();
                textBoxLastName.Text = row.Cells["LastName"].Value.ToString();
                textBoxFirstName.Text = row.Cells["FirstName"].Value.ToString();
                textBoxMiddleName.Text = row.Cells["MiddleName"].Value.ToString();
                textBoxPhone.Text = row.Cells["Phone"].Value.ToString();
                textBoxExperience.Text = row.Cells["Experience"].Value.ToString();

                if (row.Cells["SpecializationID"].Value != DBNull.Value && Convert.ToInt32(row.Cells["SpecializationID"].Value) != 0)
                {
                    comboBoxSpecializations.SelectedValue = row.Cells["SpecializationID"].Value;
                }
                else
                {
                    comboBoxSpecializations.SelectedIndex = -1;
                }
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = textBoxSearch.Text.Trim();
            var filteredInstructors = _instructorService.FilterInstructors(searchQuery);
            dataGridViewInstructors.DataSource = filteredInstructors;
        }

        private bool IsInputValid()
        {
            if (string.IsNullOrWhiteSpace(textBoxLastName.Text) ||
                string.IsNullOrWhiteSpace(textBoxFirstName.Text) ||
                string.IsNullOrWhiteSpace(textBoxPhone.Text))
            {
                ShowErrorMessage("Будь ласка, заповніть обов'язкові поля (Прізвище, Ім'я, Телефон).");
                return false;
            }

            if (!long.TryParse(textBoxPhone.Text, out _))
            {
                ShowErrorMessage("Будь ласка, введіть коректний номер телефону.");
                return false;
            }

            return true;
        }

        private void ClearFields()
        {
            textBoxInstructorID.Text = "";
            textBoxSpecializationID.Text = "";
            textBoxLastName.Text = "";
            textBoxFirstName.Text = "";
            textBoxMiddleName.Text = "";
            textBoxPhone.Text = "";
            textBoxExperience.Text = "";
            comboBoxSpecializations.SelectedIndex = -1;
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