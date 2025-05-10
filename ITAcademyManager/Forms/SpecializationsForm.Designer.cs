namespace ITAcademyManager
{
    partial class SpecializationsForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewInstructorSpecializations = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewSpecializations = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxSearch2 = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEditSpecialization = new System.Windows.Forms.Button();
            this.btnDeleteSpecialization = new System.Windows.Forms.Button();
            this.btnAddSpecialization = new System.Windows.Forms.Button();
            this.panelClients = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSpecializationID = new System.Windows.Forms.TextBox();
            this.textBoxSpecializationName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxSpecializations = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInstructorSpecializations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpecializations)).BeginInit();
            this.panelClients.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(14, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(235, 74);
            this.label6.TabIndex = 75;
            this.label6.Text = "Викладачі \r\nта спеціальності";
            // 
            // dataGridViewInstructorSpecializations
            // 
            this.dataGridViewInstructorSpecializations.AllowUserToAddRows = false;
            this.dataGridViewInstructorSpecializations.AllowUserToDeleteRows = false;
            this.dataGridViewInstructorSpecializations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewInstructorSpecializations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewInstructorSpecializations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInstructorSpecializations.Location = new System.Drawing.Point(711, 117);
            this.dataGridViewInstructorSpecializations.Name = "dataGridViewInstructorSpecializations";
            this.dataGridViewInstructorSpecializations.ReadOnly = true;
            this.dataGridViewInstructorSpecializations.RowHeadersWidth = 51;
            this.dataGridViewInstructorSpecializations.RowTemplate.Height = 24;
            this.dataGridViewInstructorSpecializations.Size = new System.Drawing.Size(507, 269);
            this.dataGridViewInstructorSpecializations.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 74);
            this.label1.TabIndex = 73;
            this.label1.Text = "Список спеціальностей \r\nвикладачів";
            // 
            // dataGridViewSpecializations
            // 
            this.dataGridViewSpecializations.AllowUserToAddRows = false;
            this.dataGridViewSpecializations.AllowUserToDeleteRows = false;
            this.dataGridViewSpecializations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSpecializations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSpecializations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSpecializations.Location = new System.Drawing.Point(16, 105);
            this.dataGridViewSpecializations.Name = "dataGridViewSpecializations";
            this.dataGridViewSpecializations.ReadOnly = true;
            this.dataGridViewSpecializations.RowHeadersWidth = 51;
            this.dataGridViewSpecializations.RowTemplate.Height = 24;
            this.dataGridViewSpecializations.Size = new System.Drawing.Size(562, 269);
            this.dataGridViewSpecializations.TabIndex = 66;
            this.dataGridViewSpecializations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSpecializations_CellClick);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(333, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 23);
            this.label13.TabIndex = 76;
            this.label13.Text = "Пошук:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearch.Location = new System.Drawing.Point(411, 59);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(167, 27);
            this.textBoxSearch.TabIndex = 77;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(283, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 23);
            this.label8.TabIndex = 78;
            this.label8.Text = "Пошук:";
            // 
            // textBoxSearch2
            // 
            this.textBoxSearch2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearch2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearch2.Location = new System.Drawing.Point(361, 59);
            this.textBoxSearch2.Name = "textBoxSearch2";
            this.textBoxSearch2.Size = new System.Drawing.Size(167, 27);
            this.textBoxSearch2.TabIndex = 79;
            this.textBoxSearch2.TextChanged += new System.EventHandler(this.textBoxSearch2_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(444, 255);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 49);
            this.btnClear.TabIndex = 85;
            this.btnClear.Text = "Очистити";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEditSpecialization
            // 
            this.btnEditSpecialization.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditSpecialization.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btnEditSpecialization.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditSpecialization.FlatAppearance.BorderSize = 0;
            this.btnEditSpecialization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditSpecialization.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEditSpecialization.ForeColor = System.Drawing.Color.White;
            this.btnEditSpecialization.Location = new System.Drawing.Point(444, 126);
            this.btnEditSpecialization.Name = "btnEditSpecialization";
            this.btnEditSpecialization.Size = new System.Drawing.Size(130, 48);
            this.btnEditSpecialization.TabIndex = 84;
            this.btnEditSpecialization.Text = "Редагувати";
            this.btnEditSpecialization.UseVisualStyleBackColor = false;
            this.btnEditSpecialization.Click += new System.EventHandler(this.btnEditSpecialization_Click);
            // 
            // btnDeleteSpecialization
            // 
            this.btnDeleteSpecialization.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteSpecialization.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btnDeleteSpecialization.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteSpecialization.FlatAppearance.BorderSize = 0;
            this.btnDeleteSpecialization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSpecialization.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDeleteSpecialization.ForeColor = System.Drawing.Color.White;
            this.btnDeleteSpecialization.Location = new System.Drawing.Point(444, 191);
            this.btnDeleteSpecialization.Name = "btnDeleteSpecialization";
            this.btnDeleteSpecialization.Size = new System.Drawing.Size(130, 49);
            this.btnDeleteSpecialization.TabIndex = 83;
            this.btnDeleteSpecialization.Text = "Видалити";
            this.btnDeleteSpecialization.UseVisualStyleBackColor = false;
            this.btnDeleteSpecialization.Click += new System.EventHandler(this.btnDeleteSpecialization_Click);
            // 
            // btnAddSpecialization
            // 
            this.btnAddSpecialization.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddSpecialization.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btnAddSpecialization.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSpecialization.FlatAppearance.BorderSize = 0;
            this.btnAddSpecialization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSpecialization.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddSpecialization.ForeColor = System.Drawing.Color.White;
            this.btnAddSpecialization.Location = new System.Drawing.Point(444, 62);
            this.btnAddSpecialization.Name = "btnAddSpecialization";
            this.btnAddSpecialization.Size = new System.Drawing.Size(130, 49);
            this.btnAddSpecialization.TabIndex = 82;
            this.btnAddSpecialization.Text = "Додати";
            this.btnAddSpecialization.UseVisualStyleBackColor = false;
            this.btnAddSpecialization.Click += new System.EventHandler(this.btnAddSpecialization_Click);
            // 
            // panelClients
            // 
            this.panelClients.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelClients.BackColor = System.Drawing.Color.White;
            this.panelClients.Controls.Add(this.label2);
            this.panelClients.Controls.Add(this.textBoxSpecializationID);
            this.panelClients.Controls.Add(this.textBoxSpecializationName);
            this.panelClients.Controls.Add(this.label3);
            this.panelClients.Controls.Add(this.btnEditSpecialization);
            this.panelClients.Controls.Add(this.btnClear);
            this.panelClients.Controls.Add(this.btnAddSpecialization);
            this.panelClients.Controls.Add(this.label5);
            this.panelClients.Controls.Add(this.btnDeleteSpecialization);
            this.panelClients.Location = new System.Drawing.Point(16, 429);
            this.panelClients.MaximumSize = new System.Drawing.Size(1594, 317);
            this.panelClients.Name = "panelClients";
            this.panelClients.Size = new System.Drawing.Size(594, 317);
            this.panelClients.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(82, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(424, 37);
            this.label2.TabIndex = 28;
            this.label2.Text = "Нова спеціальність викладача";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxSpecializationID
            // 
            this.textBoxSpecializationID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSpecializationID.Enabled = false;
            this.textBoxSpecializationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSpecializationID.Location = new System.Drawing.Point(201, 78);
            this.textBoxSpecializationID.Name = "textBoxSpecializationID";
            this.textBoxSpecializationID.Size = new System.Drawing.Size(200, 27);
            this.textBoxSpecializationID.TabIndex = 2;
            // 
            // textBoxSpecializationName
            // 
            this.textBoxSpecializationName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSpecializationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSpecializationName.Location = new System.Drawing.Point(201, 136);
            this.textBoxSpecializationName.MaxLength = 50;
            this.textBoxSpecializationName.Name = "textBoxSpecializationName";
            this.textBoxSpecializationName.Size = new System.Drawing.Size(200, 27);
            this.textBoxSpecializationName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(18, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "ID спеціальності:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(18, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 23);
            this.label5.TabIndex = 19;
            this.label5.Text = "Назва спеціальності:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBoxSpecializations);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Location = new System.Drawing.Point(690, 429);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 163);
            this.panel1.TabIndex = 86;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(117, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(335, 37);
            this.label4.TabIndex = 29;
            this.label4.Text = "Список спеціальностей ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBoxSpecializations
            // 
            this.comboBoxSpecializations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSpecializations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxSpecializations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSpecializations.FormattingEnabled = true;
            this.comboBoxSpecializations.IntegralHeight = false;
            this.comboBoxSpecializations.Location = new System.Drawing.Point(278, 87);
            this.comboBoxSpecializations.Name = "comboBoxSpecializations";
            this.comboBoxSpecializations.Size = new System.Drawing.Size(200, 24);
            this.comboBoxSpecializations.TabIndex = 49;
            this.comboBoxSpecializations.SelectedIndexChanged += new System.EventHandler(this.comboBoxSpecializations_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(22, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(198, 23);
            this.label12.TabIndex = 21;
            this.label12.Text = "Список спеціальностей:";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.textBoxSearch);
            this.panel3.Controls.Add(this.dataGridViewSpecializations);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.MaximumSize = new System.Drawing.Size(1598, 392);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(598, 392);
            this.panel3.TabIndex = 88;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.textBoxSearch2);
            this.panel4.Location = new System.Drawing.Point(690, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(551, 392);
            this.panel4.TabIndex = 89;
            // 
            // SpecializationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 846);
            this.Controls.Add(this.dataGridViewInstructorSpecializations);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelClients);
            this.Name = "SpecializationsForm";
            this.Text = "SpecializationsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInstructorSpecializations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpecializations)).EndInit();
            this.panelClients.ResumeLayout(false);
            this.panelClients.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewInstructorSpecializations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewSpecializations;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxSearch2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEditSpecialization;
        private System.Windows.Forms.Button btnDeleteSpecialization;
        private System.Windows.Forms.Button btnAddSpecialization;
        private System.Windows.Forms.Panel panelClients;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSpecializationID;
        private System.Windows.Forms.TextBox textBoxSpecializationName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxSpecializations;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}