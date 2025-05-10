using ITAcademyManager.Services;
using ITAcademyManager.Styles;
using System;
using System.Data;
using System.Windows.Forms;

namespace ITAcademyManager
{
    public partial class GroupsForm : Form
    {
        private readonly GroupService _groupService = new GroupService();

        public GroupsForm()
        {
            InitializeComponent();
            LoadData();

            DataGridViewStyler.ApplyDefaultStyles(dataGridViewGroups);
            DataGridViewStyler.ApplyDefaultStyles(dataGridViewStudents);
        }

        private void LoadData()
        {
            LoadGroups();
            LoadCoursesComboBox();
            LoadGroupsComboBox();
        }

        private void LoadGroups()
        {
            dataGridViewGroups.DataSource = _groupService.LoadGroups();
        }

        private void LoadCoursesComboBox()
        {
            comboBoxCourses.DataSource = _groupService.LoadCourses();
            comboBoxCourses.DisplayMember = "CourseName";
            comboBoxCourses.ValueMember = "CourseID";
        }

        private void LoadGroupsComboBox()
        {
            comboBoxGroups.DataSource = _groupService.LoadGroups();
            comboBoxGroups.DisplayMember = "GroupName";
            comboBoxGroups.ValueMember = "GroupID";
        }

        private void LoadStudentsByGroup(int groupID)
        {
            dataGridViewStudents.DataSource = _groupService.LoadStudentsByGroup(groupID);
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            if (IsInputValid())
            {
                int courseID = (int)comboBoxCourses.SelectedValue;
                string groupName = textBoxGroupName.Text;

                try
                {
                    _groupService.AddGroup(courseID, groupName);
                    LoadData();
                    ClearFields();

                    var mainForm = Application.OpenForms["MainForm"] as MainForm;
                    mainForm?.LoadGroupCapacityChart();

                    ShowSuccessMessage("Група успішно додана.");
                }
                catch (Exception ex)
                {
                    ShowErrorMessage(ex.Message);
                }
            }
        }
        private void btnEditGroup_Click(object sender, EventArgs e)
        {
            if (dataGridViewGroups.SelectedCells.Count == 0)
            {
                ShowErrorMessage("Будь ласка, оберіть комірку групи для редагування.");
                return;
            }

            if (!IsInputValid())
            {
                return;
            }

            int rowIndex = dataGridViewGroups.SelectedCells[0].RowIndex;
            int groupID = Convert.ToInt32(dataGridViewGroups.Rows[rowIndex].Cells["GroupID"].Value);
            int courseID = (int)comboBoxCourses.SelectedValue;
            string groupName = textBoxGroupName.Text;

            try
            {
                _groupService.EditGroup(groupID, courseID, groupName);
                LoadData();
                ClearFields();

                var mainForm = Application.OpenForms["MainForm"] as MainForm;
                mainForm?.LoadGroupCapacityChart();

                ShowSuccessMessage("Група успішно відредагована.");
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Помилка при редагуванні групи: {ex.Message}");
            }
        }

        private void btnDeleteGroup_Click(object sender, EventArgs e)
        {
            if (dataGridViewGroups.SelectedCells.Count == 0)
            {
                ShowErrorMessage("Будь ласка, оберіть комірку групи для видалення.");
                return;
            }

            int rowIndex = dataGridViewGroups.SelectedCells[0].RowIndex;
            int groupID = Convert.ToInt32(dataGridViewGroups.Rows[rowIndex].Cells["GroupID"].Value);

            var result = MessageBox.Show(
                "Ви впевнені, що хочете видалити групу та всі пов'язані записи в розкладі?",
                "Попередження",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    _groupService.DeleteGroup(groupID);
                    LoadData();
                    ClearFields();

                    var mainForm = Application.OpenForms["MainForm"] as MainForm;
                    mainForm?.LoadGroupCapacityChart();

                    ShowSuccessMessage("Група успішно видалена.");
                }
                catch (Exception ex)
                {
                    ShowErrorMessage($"Помилка при видаленні групи: {ex.Message}");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dataGridViewGroups_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewGroups.Rows[e.RowIndex];
                textBoxGroupID.Text = row.Cells["GroupID"].Value.ToString();
                textBoxCourseID.Text = row.Cells["CourseID"].Value.ToString();
                textBoxGroupName.Text = row.Cells["GroupName"].Value.ToString();
                comboBoxCourses.SelectedValue = row.Cells["CourseID"].Value;
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = textBoxSearch.Text.Trim();
            dataGridViewGroups.DataSource = _groupService.FilterGroups(searchQuery);
        }

        private void comboBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxGroups.SelectedIndex != -1)
            {
                int groupID = Convert.ToInt32(((DataRowView)comboBoxGroups.SelectedItem)["GroupID"]);
                LoadStudentsByGroup(groupID);
            }
        }

        private void textBoxSearch2_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxGroups.SelectedIndex != -1)
            {
                string searchQuery = textBoxSearch2.Text.Trim();
                int groupID = Convert.ToInt32(((DataRowView)comboBoxGroups.SelectedItem)["GroupID"]);
                dataGridViewStudents.DataSource = _groupService.FilterStudentsByGroup(groupID, searchQuery);
            }
        }

        private bool IsInputValid()
        {
            if (string.IsNullOrWhiteSpace(textBoxGroupName.Text))
            {
                ShowErrorMessage("Назва групи не може бути пустою.");
                return false;
            }

            if (comboBoxCourses.SelectedIndex == -1)
            {
                ShowErrorMessage("Будь ласка, оберіть курс.");
                return false;
            }

            return true;
        }

        private void ClearFields()
        {
            textBoxGroupName.Text = "";
            comboBoxCourses.SelectedIndex = -1;
            textBoxGroupID.Text = "";
            textBoxCourseID.Text = "";

            if (comboBoxCourses.Items.Count > 0)
            {
                comboBoxCourses.SelectedIndex = 0;
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
