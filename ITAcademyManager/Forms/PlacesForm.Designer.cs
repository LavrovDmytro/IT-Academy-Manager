namespace ITAcademyManager
{
    partial class PlacesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEditPlace = new System.Windows.Forms.Button();
            this.btnDeletePlace = new System.Windows.Forms.Button();
            this.btnAddPlace = new System.Windows.Forms.Button();
            this.panelClients = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPlaceID = new System.Windows.Forms.TextBox();
            this.textBoxPlaceName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewPlaces = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlaces)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(25, 441);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 49);
            this.btnClear.TabIndex = 94;
            this.btnClear.Text = "Очистити";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEditPlace
            // 
            this.btnEditPlace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btnEditPlace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditPlace.FlatAppearance.BorderSize = 0;
            this.btnEditPlace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPlace.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEditPlace.ForeColor = System.Drawing.Color.White;
            this.btnEditPlace.Location = new System.Drawing.Point(25, 307);
            this.btnEditPlace.Name = "btnEditPlace";
            this.btnEditPlace.Size = new System.Drawing.Size(130, 48);
            this.btnEditPlace.TabIndex = 93;
            this.btnEditPlace.Text = "Редагувати";
            this.btnEditPlace.UseVisualStyleBackColor = false;
            this.btnEditPlace.Click += new System.EventHandler(this.btnEditPlace_Click);
            // 
            // btnDeletePlace
            // 
            this.btnDeletePlace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btnDeletePlace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletePlace.FlatAppearance.BorderSize = 0;
            this.btnDeletePlace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePlace.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDeletePlace.ForeColor = System.Drawing.Color.White;
            this.btnDeletePlace.Location = new System.Drawing.Point(25, 373);
            this.btnDeletePlace.Name = "btnDeletePlace";
            this.btnDeletePlace.Size = new System.Drawing.Size(130, 49);
            this.btnDeletePlace.TabIndex = 92;
            this.btnDeletePlace.Text = "Видалити";
            this.btnDeletePlace.UseVisualStyleBackColor = false;
            this.btnDeletePlace.Click += new System.EventHandler(this.btnDeletePlace_Click);
            // 
            // btnAddPlace
            // 
            this.btnAddPlace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btnAddPlace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPlace.FlatAppearance.BorderSize = 0;
            this.btnAddPlace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPlace.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddPlace.ForeColor = System.Drawing.Color.White;
            this.btnAddPlace.Location = new System.Drawing.Point(25, 238);
            this.btnAddPlace.Name = "btnAddPlace";
            this.btnAddPlace.Size = new System.Drawing.Size(130, 49);
            this.btnAddPlace.TabIndex = 91;
            this.btnAddPlace.Text = "Додати";
            this.btnAddPlace.UseVisualStyleBackColor = false;
            this.btnAddPlace.Click += new System.EventHandler(this.btnAddPlace_Click);
            // 
            // panelClients
            // 
            this.panelClients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelClients.BackColor = System.Drawing.Color.White;
            this.panelClients.Controls.Add(this.label2);
            this.panelClients.Controls.Add(this.btnClear);
            this.panelClients.Controls.Add(this.textBoxPlaceID);
            this.panelClients.Controls.Add(this.btnDeletePlace);
            this.panelClients.Controls.Add(this.btnEditPlace);
            this.panelClients.Controls.Add(this.textBoxPlaceName);
            this.panelClients.Controls.Add(this.label3);
            this.panelClients.Controls.Add(this.btnAddPlace);
            this.panelClients.Controls.Add(this.label5);
            this.panelClients.Location = new System.Drawing.Point(725, 15);
            this.panelClients.Name = "panelClients";
            this.panelClients.Size = new System.Drawing.Size(513, 509);
            this.panelClients.TabIndex = 90;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(18, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 74);
            this.label2.TabIndex = 28;
            this.label2.Text = "Нове місце проведення\r\nгрупового заняття";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxPlaceID
            // 
            this.textBoxPlaceID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPlaceID.Enabled = false;
            this.textBoxPlaceID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPlaceID.Location = new System.Drawing.Point(274, 129);
            this.textBoxPlaceID.Name = "textBoxPlaceID";
            this.textBoxPlaceID.Size = new System.Drawing.Size(200, 27);
            this.textBoxPlaceID.TabIndex = 2;
            // 
            // textBoxPlaceName
            // 
            this.textBoxPlaceName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPlaceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPlaceName.Location = new System.Drawing.Point(274, 183);
            this.textBoxPlaceName.MaxLength = 50;
            this.textBoxPlaceName.Name = "textBoxPlaceName";
            this.textBoxPlaceName.Size = new System.Drawing.Size(200, 27);
            this.textBoxPlaceName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(21, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "ID місця проведення:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(21, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 23);
            this.label5.TabIndex = 19;
            this.label5.Text = "Назва місця проведення:";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(417, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 23);
            this.label13.TabIndex = 88;
            this.label13.Text = "Пошук:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearch.Location = new System.Drawing.Point(496, 59);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(167, 27);
            this.textBoxSearch.TabIndex = 89;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 74);
            this.label1.TabIndex = 87;
            this.label1.Text = "Список місць проведення \r\nгрупових занять";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridViewPlaces
            // 
            this.dataGridViewPlaces.AllowUserToAddRows = false;
            this.dataGridViewPlaces.AllowUserToDeleteRows = false;
            this.dataGridViewPlaces.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPlaces.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPlaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlaces.Location = new System.Drawing.Point(19, 122);
            this.dataGridViewPlaces.Name = "dataGridViewPlaces";
            this.dataGridViewPlaces.ReadOnly = true;
            this.dataGridViewPlaces.RowHeadersWidth = 51;
            this.dataGridViewPlaces.RowTemplate.Height = 24;
            this.dataGridViewPlaces.Size = new System.Drawing.Size(644, 368);
            this.dataGridViewPlaces.TabIndex = 86;
            this.dataGridViewPlaces.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPlaces_CellClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridViewPlaces);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.textBoxSearch);
            this.panel1.Location = new System.Drawing.Point(12, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 509);
            this.panel1.TabIndex = 95;
            // 
            // PlacesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 846);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelClients);
            this.Name = "PlacesForm";
            this.Text = "PlacesForm";
            this.panelClients.ResumeLayout(false);
            this.panelClients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlaces)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEditPlace;
        private System.Windows.Forms.Button btnDeletePlace;
        private System.Windows.Forms.Button btnAddPlace;
        private System.Windows.Forms.Panel panelClients;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPlaceID;
        private System.Windows.Forms.TextBox textBoxPlaceName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewPlaces;
        private System.Windows.Forms.Panel panel1;
    }
}