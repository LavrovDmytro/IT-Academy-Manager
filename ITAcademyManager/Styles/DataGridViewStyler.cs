using System.Drawing;
using System.Windows.Forms;

namespace ITAcademyManager.Styles
{
    public static class DataGridViewStyler
    {
        private static readonly Color HeaderBackColor = Color.FromArgb(8, 118, 122);
        private static readonly Color HeaderForeColor = Color.White;
        private static readonly Font HeaderFont = new Font("Segoe UI", 10, FontStyle.Bold);
        private static readonly DataGridViewContentAlignment HeaderAlignment = DataGridViewContentAlignment.MiddleCenter;

        private static readonly Color RowBackColor = Color.White;
        private static readonly Color RowForeColor = Color.Black;
        private static readonly Font RowFont = new Font("Segoe UI", 9);

        private static readonly Color AlternatingRowBackColor = Color.FromArgb(240, 240, 240);
        private static readonly Color AlternatingRowForeColor = Color.Black;

        private static readonly Color SelectedRowBackColor = Color.FromArgb(92, 171, 174);
        private static readonly Color SelectedRowForeColor = Color.White;

        public static void StyleHeaders(DataGridView dataGridView)
        {
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = HeaderBackColor;
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = HeaderForeColor;
            dataGridView.ColumnHeadersDefaultCellStyle.Font = HeaderFont;
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment = HeaderAlignment;
            dataGridView.EnableHeadersVisualStyles = false;
        }

        private static void StyleRows(DataGridView dataGridView)
        {
            dataGridView.DefaultCellStyle.BackColor = RowBackColor;
            dataGridView.DefaultCellStyle.ForeColor = RowForeColor;
            dataGridView.DefaultCellStyle.Font = RowFont;

            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = AlternatingRowBackColor;
            dataGridView.AlternatingRowsDefaultCellStyle.ForeColor = AlternatingRowForeColor;
        }

        public static void StyleSelectedRow(DataGridView dataGridView)
        {
            dataGridView.DefaultCellStyle.SelectionBackColor = SelectedRowBackColor;
            dataGridView.DefaultCellStyle.SelectionForeColor = SelectedRowForeColor;
        }

        public static void SetColumnSizeModeBasedOnWidth(DataGridView dataGridView, int width, int widthThreshold = 1200)
        {
            dataGridView.AutoSizeColumnsMode = width < widthThreshold
                ? DataGridViewAutoSizeColumnsMode.AllCells
                : DataGridViewAutoSizeColumnsMode.Fill;
        }

        public static void ApplyDefaultStyles(DataGridView dataGridView)
        {
            StyleHeaders(dataGridView);
            StyleRows(dataGridView);
            StyleSelectedRow(dataGridView);
        }

        public static void ApplyDefaultStylesWithWidthCheck(DataGridView dataGridView, int width, int widthThreshold = 1200)
        {
            ApplyDefaultStyles(dataGridView);
            SetColumnSizeModeBasedOnWidth(dataGridView, width, widthThreshold);
        }
    }
}