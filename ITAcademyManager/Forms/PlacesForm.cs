using ITAcademyManager.Services;
using ITAcademyManager.Styles;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ITAcademyManager
{
    public partial class PlacesForm : Form
    {
        private readonly PlaceService _placeService = new PlaceService();

        public PlacesForm()
        {
            InitializeComponent();
            LoadPlaces();

            DataGridViewStyler.ApplyDefaultStyles(dataGridViewPlaces);
        }

        private void LoadPlaces()
        {
            dataGridViewPlaces.DataSource = _placeService.LoadPlaces();
        }

        private void btnAddPlace_Click(object sender, EventArgs e)
        {
            if (IsInputValid())
            {
                string placeName = textBoxPlaceName.Text.Trim();

                try
                {
                    _placeService.AddPlace(placeName);
                    LoadPlaces();
                    ClearFields();

                    ShowSuccessMessage("Місце успішно додано.");
                }
                catch (Exception ex)
                {
                    ShowErrorMessage(ex.Message);
                }
            }
        }

        private void btnEditPlace_Click(object sender, EventArgs e)
        {
            if (dataGridViewPlaces.SelectedCells.Count == 0)
            {
                ShowErrorMessage("Будь ласка, оберіть комірку місця для редагування.");
                return;
            }

            if (!IsInputValid())
            {
                return;
            }

            int rowIndex = dataGridViewPlaces.SelectedCells[0].RowIndex;
            int placeID = Convert.ToInt32(dataGridViewPlaces.Rows[rowIndex].Cells["PlaceID"].Value);
            string placeName = textBoxPlaceName.Text.Trim();

            try
            {
                _placeService.EditPlace(placeID, placeName);
                LoadPlaces();
                ClearFields();

                ShowSuccessMessage("Місце успішно відредаговано.");
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Помилка при редагуванні місця: {ex.Message}");
            }
        }

        private void btnDeletePlace_Click(object sender, EventArgs e)
        {
            if (dataGridViewPlaces.SelectedCells.Count == 0)
            {
                ShowErrorMessage("Будь ласка, оберіть комірку місця для видалення.");
                return;
            }

            int rowIndex = dataGridViewPlaces.SelectedCells[0].RowIndex;
            int placeID = Convert.ToInt32(dataGridViewPlaces.Rows[rowIndex].Cells["PlaceID"].Value);

            var result = MessageBox.Show(
                "Ви впевнені, що хочете видалити це місце?",
                "Підтвердження видалення",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    _placeService.DeletePlace(placeID);
                    LoadPlaces();
                    ClearFields();

                    ShowSuccessMessage("Місце успішно видалено.");
                }
                catch (SqlException ex)
                {
                    ShowErrorMessage(GetErrorMessage(ex));
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
            dataGridViewPlaces.DataSource = _placeService.FilterPlaces(searchQuery);
        }

        private void dataGridViewPlaces_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewPlaces.Rows[e.RowIndex];
                textBoxPlaceID.Text = row.Cells["PlaceID"].Value.ToString();
                textBoxPlaceName.Text = row.Cells["PlaceName"].Value.ToString();
            }
        }

        private bool IsInputValid()
        {
            if (string.IsNullOrWhiteSpace(textBoxPlaceName.Text))
            {
                ShowErrorMessage("Будь ласка, введіть назву місця.");
                return false;
            }

            return true;
        }

        private void ClearFields()
        {
            textBoxPlaceID.Text = "";
            textBoxPlaceName.Text = "";
        }

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowSuccessMessage(string message)
        {
            MessageBox.Show(message, "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string GetErrorMessage(SqlException ex)
        {
            switch (ex.Number)
            {
                case 2627:
                    return "Місце з такою назвою вже існує.";
                default:
                    return ex.Message;
            }
        }
    }
}