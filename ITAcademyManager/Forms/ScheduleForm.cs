using ITAcademyManager.Styles;
using System;
using System.Windows.Forms;

namespace ITAcademyManager
{
    public partial class ScheduleForm : Form
    {
        private readonly ScheduleService _scheduleService = new ScheduleService();

        public ScheduleForm()
        {
            InitializeComponent();
            InitializeForm();

            int formWidth = this.ClientSize.Width;
            DataGridViewStyler.ApplyDefaultStylesWithWidthCheck(dataGridViewSchedule, formWidth, 1200);
        }

        private void ScheduleForm_Resize(object sender, EventArgs e)
        {
            int formWidth = this.ClientSize.Width;
            DataGridViewStyler.ApplyDefaultStylesWithWidthCheck(dataGridViewSchedule, formWidth, 1200);
        }

        private void InitializeForm()
        {
            LoadSchedule();
            LoadComboBoxes();
        }

        private void LoadSchedule()
        {
            dataGridViewSchedule.DataSource = _scheduleService.LoadSchedule();
        }

        private void LoadComboBoxes()
        {
            comboBoxInstructors.DataSource = _scheduleService.LoadInstructors();
            comboBoxInstructors.DisplayMember = "InstructorName";
            comboBoxInstructors.ValueMember = "InstructorID";

            comboBoxGroups.DataSource = _scheduleService.LoadGroups();
            comboBoxGroups.DisplayMember = "GroupName";
            comboBoxGroups.ValueMember = "GroupID";

            comboBoxPlaces.DataSource = _scheduleService.LoadPlaces();
            comboBoxPlaces.DisplayMember = "PlaceName";
            comboBoxPlaces.ValueMember = "PlaceID";

            comboBoxStatus.Items.AddRange(new string[] { "Scheduled", "Completed", "Cancelled" });
            comboBoxStatus.SelectedIndex = 0;
        }

        private void btnAddSchedule_Click(object sender, EventArgs e)
        {
            if (IsInputValid())
            {
                int instructorID = Convert.ToInt32(comboBoxInstructors.SelectedValue);
                int groupID = Convert.ToInt32(comboBoxGroups.SelectedValue);
                int placeID = Convert.ToInt32(comboBoxPlaces.SelectedValue);
                DateTime date = dateTimePickerDate.Value;
                TimeSpan startTime = dateTimePickerStartTime.Value.TimeOfDay;
                TimeSpan endTime = dateTimePickerEndTime.Value.TimeOfDay;
                string status = comboBoxStatus.SelectedItem.ToString();

                if (startTime >= endTime)
                {
                    ShowErrorMessage("Час початку не може бути пізніше або дорівнювати часу завершення.");
                    return;
                }

                try
                {
                    _scheduleService.AddSchedule(instructorID, groupID, placeID, date, startTime, endTime, status);
                    LoadSchedule();
                    ClearFields();

                    ShowSuccessMessage("Розклад успішно додано.");
                }
                catch (Exception ex)
                {
                    ShowErrorMessage(ex.Message);
                }
            }
        }

        private void btnEditSchedule_Click(object sender, EventArgs e)
        {
            if (dataGridViewSchedule.SelectedCells.Count == 0)
            {
                ShowErrorMessage("Будь ласка, оберіть комірку розкладу для редагування.");
                return;
            }

            if (!IsInputValid())
            {
                return;
            }

            int rowIndex = dataGridViewSchedule.SelectedCells[0].RowIndex;
            int scheduleID = Convert.ToInt32(dataGridViewSchedule.Rows[rowIndex].Cells["ScheduleID"].Value);
            int instructorID = Convert.ToInt32(comboBoxInstructors.SelectedValue);
            int groupID = Convert.ToInt32(comboBoxGroups.SelectedValue);
            int placeID = Convert.ToInt32(comboBoxPlaces.SelectedValue);
            DateTime date = dateTimePickerDate.Value;
            TimeSpan startTime = dateTimePickerStartTime.Value.TimeOfDay;
            TimeSpan endTime = dateTimePickerEndTime.Value.TimeOfDay;
            string status = comboBoxStatus.SelectedItem.ToString();

            if (startTime >= endTime)
            {
                ShowErrorMessage("Час початку не може бути пізніше або дорівнювати часу завершення.");
                return;
            }

            try
            {
                _scheduleService.EditSchedule(scheduleID, instructorID, groupID, placeID, date, startTime, endTime, status);
                LoadSchedule();
                ClearFields();

                ShowSuccessMessage("Розклад успішно відредаговано.");
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Помилка при редагуванні розкладу: {ex.Message}");
            }
        }

        private void btnDeleteSchedule_Click(object sender, EventArgs e)
        {
            if (dataGridViewSchedule.SelectedCells.Count == 0)
            {
                ShowErrorMessage("Будь ласка, оберіть комірку розкладу для видалення.");
                return;
            }

            int rowIndex = dataGridViewSchedule.SelectedCells[0].RowIndex;
            int scheduleID = Convert.ToInt32(dataGridViewSchedule.Rows[rowIndex].Cells["ScheduleID"].Value);

            var result = MessageBox.Show(
                "Ви впевнені, що хочете видалити цей запис із розкладу?",
                "Підтвердження видалення",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    _scheduleService.DeleteSchedule(scheduleID);
                    LoadSchedule();
                    ClearFields();

                    ShowSuccessMessage("Розклад успішно видалено.");
                }
                catch (Exception ex)
                {
                    ShowErrorMessage($"Помилка при видаленні розкладу: {ex.Message}");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dateTimePickerEndTime_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerEndTime.Value < dateTimePickerStartTime.Value)
            {
                ShowErrorMessage("Час кінця не може бути раніше, ніж час початку.");
                dateTimePickerEndTime.Value = dateTimePickerStartTime.Value;
            }
        }

        private void dataGridViewSchedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewSchedule.Rows[e.RowIndex];
                textBoxScheduleID.Text = row.Cells["ScheduleID"].Value.ToString();
                textBoxInstructorID.Text = row.Cells["InstructorID"].Value.ToString();
                textBoxGroupID.Text = row.Cells["GroupID"].Value.ToString();
                textBoxPlaceID.Text = row.Cells["PlaceID"].Value.ToString();

                if (row.Cells["InstructorID"].Value != DBNull.Value)
                {
                    comboBoxInstructors.SelectedValue = row.Cells["InstructorID"].Value;
                }
                else
                {
                    comboBoxInstructors.SelectedIndex = -1;
                }

                comboBoxGroups.SelectedValue = row.Cells["GroupID"].Value;
                comboBoxPlaces.SelectedValue = row.Cells["PlaceID"].Value;
                dateTimePickerDate.Value = Convert.ToDateTime(row.Cells["Date"].Value);

                string startTimeStr = row.Cells["StartTime"].Value.ToString();
                string endTimeStr = row.Cells["EndTime"].Value.ToString();
                dateTimePickerStartTime.Value = DateTime.Today.Add(TimeSpan.Parse(startTimeStr));
                dateTimePickerEndTime.Value = DateTime.Today.Add(TimeSpan.Parse(endTimeStr));

                comboBoxStatus.SelectedItem = row.Cells["Status"].Value.ToString();
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = textBoxSearch.Text.Trim();
            dataGridViewSchedule.DataSource = _scheduleService.FilterSchedule(searchQuery);
        }

        private bool IsInputValid()
        {
            if (comboBoxInstructors.SelectedIndex == -1)
            {
                ShowErrorMessage("Будь ласка, оберіть інструктора.");
                return false;
            }

            if (comboBoxGroups.SelectedIndex == -1)
            {
                ShowErrorMessage("Будь ласка, оберіть групу.");
                return false;
            }

            if (comboBoxPlaces.SelectedIndex == -1)
            {
                ShowErrorMessage("Будь ласка, оберіть місце.");
                return false;
            }

            if (dateTimePickerStartTime.Value.TimeOfDay >= dateTimePickerEndTime.Value.TimeOfDay)
            {
                ShowErrorMessage("Час початку не може бути пізніше або дорівнювати часу завершення.");
                return false;
            }

            return true;
        }

        private void ClearFields()
        {
            textBoxScheduleID.Text = "";
            comboBoxInstructors.SelectedIndex = -1;
            comboBoxGroups.SelectedIndex = -1;
            comboBoxPlaces.SelectedIndex = -1;
            dateTimePickerDate.Value = DateTime.Now;
            dateTimePickerStartTime.Value = DateTime.Now;
            dateTimePickerEndTime.Value = DateTime.Now;
            comboBoxStatus.SelectedIndex = 0;
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