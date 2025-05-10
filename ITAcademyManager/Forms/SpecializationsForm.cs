using ITAcademyManager.Styles;
using System;
using System.Windows.Forms;

namespace ITAcademyManager
{
    public partial class SpecializationsForm : Form
    {
        private readonly SpecializationService _specializationService = new SpecializationService();

        public SpecializationsForm()
        {
            InitializeComponent();
            LoadData();

            DataGridViewStyler.ApplyDefaultStyles(dataGridViewSpecializations);
            DataGridViewStyler.ApplyDefaultStyles(dataGridViewInstructorSpecializations);
        }

        private void LoadData()
        {
            LoadSpecializations();
            LoadInstructorSpecializations();
            LoadComboBoxSpecializations();
        }

        private void LoadSpecializations()
        {
            dataGridViewSpecializations.DataSource = _specializationService.LoadSpecializations();
        }

        private void LoadInstructorSpecializations()
        {
            dataGridViewInstructorSpecializations.DataSource = _specializationService.LoadInstructorSpecializations();
        }

        private void LoadComboBoxSpecializations()
        {
            comboBoxSpecializations.Items.Clear();
            comboBoxSpecializations.Items.AddRange(_specializationService.LoadComboBoxSpecializations().ToArray());
        }

        private void btnAddSpecialization_Click(object sender, EventArgs e)
        {
            if (IsInputValid())
            {
                string specializationName = textBoxSpecializationName.Text.Trim();

                try
                {
                    _specializationService.AddSpecialization(specializationName);
                    LoadData();
                    ClearFields();

                    ShowSuccessMessage("Спеціалізація успішно додана.");
                }
                catch (Exception ex)
                {
                    ShowErrorMessage(ex.Message);
                }
            }
        }

        private void btnEditSpecialization_Click(object sender, EventArgs e)
        {
            if (dataGridViewSpecializations.SelectedCells.Count == 0)
            {
                ShowErrorMessage("Будь ласка, оберіть комірку спеціалізації для редагування.");
                return;
            }

            if (!IsInputValid())
            {
                return;
            }

            int rowIndex = dataGridViewSpecializations.SelectedCells[0].RowIndex;
            int specializationID = Convert.ToInt32(dataGridViewSpecializations.Rows[rowIndex].Cells["SpecializationID"].Value);
            string specializationName = textBoxSpecializationName.Text.Trim();

            try
            {
                _specializationService.EditSpecialization(specializationID, specializationName);
                LoadData();
                ClearFields();

                ShowSuccessMessage("Спеціалізація успішно відредагована.");
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Помилка при редагуванні спеціалізації: {ex.Message}");
            }
        }

        private void btnDeleteSpecialization_Click(object sender, EventArgs e)
        {
            if (dataGridViewSpecializations.SelectedCells.Count == 0)
            {
                ShowErrorMessage("Будь ласка, оберіть комірку спеціалізації для видалення.");
                return;
            }

            int rowIndex = dataGridViewSpecializations.SelectedCells[0].RowIndex;
            int specializationID = Convert.ToInt32(dataGridViewSpecializations.Rows[rowIndex].Cells["SpecializationID"].Value);

            var result = MessageBox.Show(
                "Ви впевнені, що хочете видалити цю спеціалізацію?",
                "Підтвердження видалення",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    _specializationService.DeleteSpecialization(specializationID);
                    LoadData();
                    ClearFields();

                    ShowSuccessMessage("Спеціалізація успішно видалена.");
                }
                catch (Exception ex)
                {
                    ShowErrorMessage($"Помилка при видаленні спеціалізації: {ex.Message}");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = textBoxSearch.Text.Trim();
            dataGridViewSpecializations.DataSource = _specializationService.FilterSpecializations(searchQuery);
        }

        private void textBoxSearch2_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = textBoxSearch2.Text.Trim();
            dataGridViewInstructorSpecializations.DataSource = _specializationService.FilterInstructorSpecializations(searchQuery);
        }

        private void comboBoxSpecializations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSpecializations.SelectedItem != null)
            {
                string selectedSpecialization = comboBoxSpecializations.SelectedItem.ToString();
                dataGridViewInstructorSpecializations.DataSource = _specializationService.FilterInstructorSpecializationsBySpecialization(selectedSpecialization);
            }
        }

        private void dataGridViewSpecializations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewSpecializations.Rows[e.RowIndex];
                textBoxSpecializationID.Text = row.Cells["SpecializationID"].Value.ToString();
                textBoxSpecializationName.Text = row.Cells["SpecializationName"].Value.ToString();
            }
        }

        private bool IsInputValid()
        {
            if (string.IsNullOrWhiteSpace(textBoxSpecializationName.Text))
            {
                ShowErrorMessage("Назва спеціалізації не може бути пустою.");
                return false;
            }

            return true;
        }

        private void ClearFields()
        {
            textBoxSpecializationID.Text = "";
            textBoxSpecializationName.Text = "";
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