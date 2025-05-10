namespace ITAcademyManager
{
    partial class InstructorsForm
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
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.btnEditInstructor = new System.Windows.Forms.Button();
            this.btnDeleteInstructor = new System.Windows.Forms.Button();
            this.btnAddInstructor = new System.Windows.Forms.Button();
            this.panelClients = new System.Windows.Forms.Panel();
            this.textBoxExperience = new System.Windows.Forms.TextBox();
            this.comboBoxSpecializations = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSpecializationID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxInstructorID = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewInstructors = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panelClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInstructors)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.btnClear.Location = new System.Drawing.Point(1084, 274);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 49);
            this.btnClear.TabIndex = 56;
            this.btnClear.Text = "Очистити";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(968, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 23);
            this.label13.TabIndex = 54;
            this.label13.Text = "Пошук:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearch.Location = new System.Drawing.Point(1047, 25);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(167, 27);
            this.textBoxSearch.TabIndex = 55;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // btnEditInstructor
            // 
            this.btnEditInstructor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditInstructor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btnEditInstructor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditInstructor.FlatAppearance.BorderSize = 0;
            this.btnEditInstructor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditInstructor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEditInstructor.ForeColor = System.Drawing.Color.White;
            this.btnEditInstructor.Location = new System.Drawing.Point(1084, 137);
            this.btnEditInstructor.Name = "btnEditInstructor";
            this.btnEditInstructor.Size = new System.Drawing.Size(130, 48);
            this.btnEditInstructor.TabIndex = 53;
            this.btnEditInstructor.Text = "Редагувати";
            this.btnEditInstructor.UseVisualStyleBackColor = false;
            this.btnEditInstructor.Click += new System.EventHandler(this.btnEditInstructor_Click);
            // 
            // btnDeleteInstructor
            // 
            this.btnDeleteInstructor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteInstructor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btnDeleteInstructor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteInstructor.FlatAppearance.BorderSize = 0;
            this.btnDeleteInstructor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteInstructor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDeleteInstructor.ForeColor = System.Drawing.Color.White;
            this.btnDeleteInstructor.Location = new System.Drawing.Point(1084, 206);
            this.btnDeleteInstructor.Name = "btnDeleteInstructor";
            this.btnDeleteInstructor.Size = new System.Drawing.Size(130, 49);
            this.btnDeleteInstructor.TabIndex = 52;
            this.btnDeleteInstructor.Text = "Видалити";
            this.btnDeleteInstructor.UseVisualStyleBackColor = false;
            this.btnDeleteInstructor.Click += new System.EventHandler(this.btnDeleteInstructor_Click);
            // 
            // btnAddInstructor
            // 
            this.btnAddInstructor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddInstructor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btnAddInstructor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddInstructor.FlatAppearance.BorderSize = 0;
            this.btnAddInstructor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddInstructor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddInstructor.ForeColor = System.Drawing.Color.White;
            this.btnAddInstructor.Location = new System.Drawing.Point(1084, 69);
            this.btnAddInstructor.Name = "btnAddInstructor";
            this.btnAddInstructor.Size = new System.Drawing.Size(130, 49);
            this.btnAddInstructor.TabIndex = 51;
            this.btnAddInstructor.Text = "Додати";
            this.btnAddInstructor.UseVisualStyleBackColor = false;
            this.btnAddInstructor.Click += new System.EventHandler(this.btnAddInstructor_Click);
            // 
            // panelClients
            // 
            this.panelClients.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelClients.BackColor = System.Drawing.Color.White;
            this.panelClients.Controls.Add(this.textBoxExperience);
            this.panelClients.Controls.Add(this.comboBoxSpecializations);
            this.panelClients.Controls.Add(this.btnClear);
            this.panelClients.Controls.Add(this.label9);
            this.panelClients.Controls.Add(this.btnEditInstructor);
            this.panelClients.Controls.Add(this.textBoxPhone);
            this.panelClients.Controls.Add(this.btnDeleteInstructor);
            this.panelClients.Controls.Add(this.label8);
            this.panelClients.Controls.Add(this.btnAddInstructor);
            this.panelClients.Controls.Add(this.textBoxMiddleName);
            this.panelClients.Controls.Add(this.label1);
            this.panelClients.Controls.Add(this.textBoxSpecializationID);
            this.panelClients.Controls.Add(this.label6);
            this.panelClients.Controls.Add(this.label2);
            this.panelClients.Controls.Add(this.textBoxInstructorID);
            this.panelClients.Controls.Add(this.textBoxLastName);
            this.panelClients.Controls.Add(this.textBoxFirstName);
            this.panelClients.Controls.Add(this.label3);
            this.panelClients.Controls.Add(this.label4);
            this.panelClients.Controls.Add(this.label5);
            this.panelClients.Controls.Add(this.label7);
            this.panelClients.Location = new System.Drawing.Point(12, 426);
            this.panelClients.Name = "panelClients";
            this.panelClients.Size = new System.Drawing.Size(1228, 337);
            this.panelClients.TabIndex = 50;
            // 
            // textBoxExperience
            // 
            this.textBoxExperience.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxExperience.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxExperience.Location = new System.Drawing.Point(756, 65);
            this.textBoxExperience.MaxLength = 20;
            this.textBoxExperience.Name = "textBoxExperience";
            this.textBoxExperience.Size = new System.Drawing.Size(200, 27);
            this.textBoxExperience.TabIndex = 52;
            // 
            // comboBoxSpecializations
            // 
            this.comboBoxSpecializations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxSpecializations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSpecializations.FormattingEnabled = true;
            this.comboBoxSpecializations.IntegralHeight = false;
            this.comboBoxSpecializations.Location = new System.Drawing.Point(756, 206);
            this.comboBoxSpecializations.Name = "comboBoxSpecializations";
            this.comboBoxSpecializations.Size = new System.Drawing.Size(200, 24);
            this.comboBoxSpecializations.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(510, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(198, 23);
            this.label9.TabIndex = 50;
            this.label9.Text = "Список спеціальностей:";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPhone.Location = new System.Drawing.Point(258, 292);
            this.textBoxPhone.MaxLength = 15;
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(200, 27);
            this.textBoxPhone.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 23);
            this.label8.TabIndex = 36;
            this.label8.Text = "Номер телефону:";
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMiddleName.Location = new System.Drawing.Point(258, 247);
            this.textBoxMiddleName.MaxLength = 20;
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(200, 27);
            this.textBoxMiddleName.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 23);
            this.label1.TabIndex = 34;
            this.label1.Text = "По-батькові викладача:";
            // 
            // textBoxSpecializationID
            // 
            this.textBoxSpecializationID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSpecializationID.Enabled = false;
            this.textBoxSpecializationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSpecializationID.Location = new System.Drawing.Point(258, 112);
            this.textBoxSpecializationID.Name = "textBoxSpecializationID";
            this.textBoxSpecializationID.Size = new System.Drawing.Size(200, 27);
            this.textBoxSpecializationID.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 23);
            this.label6.TabIndex = 31;
            this.label6.Text = "ID спеціальності:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(485, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 37);
            this.label2.TabIndex = 28;
            this.label2.Text = "Новий викладач";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxInstructorID
            // 
            this.textBoxInstructorID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInstructorID.Enabled = false;
            this.textBoxInstructorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInstructorID.Location = new System.Drawing.Point(258, 68);
            this.textBoxInstructorID.Name = "textBoxInstructorID";
            this.textBoxInstructorID.Size = new System.Drawing.Size(200, 27);
            this.textBoxInstructorID.TabIndex = 2;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLastName.Location = new System.Drawing.Point(258, 156);
            this.textBoxLastName.MaxLength = 20;
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(200, 27);
            this.textBoxLastName.TabIndex = 3;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFirstName.Location = new System.Drawing.Point(258, 202);
            this.textBoxFirstName.MaxLength = 20;
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(200, 27);
            this.textBoxFirstName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "ID викладача:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "Ім\'я викладача:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 23);
            this.label5.TabIndex = 19;
            this.label5.Text = "Прізвище викладача:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(510, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 23);
            this.label7.TabIndex = 21;
            this.label7.Text = "Досвід роботи:";
            // 
            // dataGridViewInstructors
            // 
            this.dataGridViewInstructors.AllowUserToAddRows = false;
            this.dataGridViewInstructors.AllowUserToDeleteRows = false;
            this.dataGridViewInstructors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewInstructors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewInstructors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInstructors.Location = new System.Drawing.Point(28, 83);
            this.dataGridViewInstructors.Name = "dataGridViewInstructors";
            this.dataGridViewInstructors.ReadOnly = true;
            this.dataGridViewInstructors.RowHeadersWidth = 51;
            this.dataGridViewInstructors.RowTemplate.Height = 24;
            this.dataGridViewInstructors.Size = new System.Drawing.Size(1198, 303);
            this.dataGridViewInstructors.TabIndex = 49;
            this.dataGridViewInstructors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInstructors_CellClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.textBoxSearch);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1228, 390);
            this.panel1.TabIndex = 57;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(9, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(271, 37);
            this.label11.TabIndex = 66;
            this.label11.Text = "Список викладачів";
            // 
            // InstructorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 846);
            this.Controls.Add(this.dataGridViewInstructors);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelClients);
            this.Name = "InstructorsForm";
            this.Text = "InstructorsForm";
            this.Resize += new System.EventHandler(this.InstructorsForm_Resize);
            this.panelClients.ResumeLayout(false);
            this.panelClients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInstructors)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button btnEditInstructor;
        private System.Windows.Forms.Button btnDeleteInstructor;
        private System.Windows.Forms.Button btnAddInstructor;
        private System.Windows.Forms.Panel panelClients;
        private System.Windows.Forms.TextBox textBoxExperience;
        private System.Windows.Forms.ComboBox comboBoxSpecializations;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSpecializationID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxInstructorID;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridViewInstructors;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
    }
}