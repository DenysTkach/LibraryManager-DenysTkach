namespace LibraryManager.GUI
{
    partial class AuthorsForm
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
            dataGridViewAuthors = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colBirth = new DataGridViewTextBoxColumn();
            colCountry = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            txtBirth = new TextBox();
            txtCountry = new TextBox();
            txtFullName = new TextBox();
            btnSave = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAuthors).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewAuthors
            // 
            dataGridViewAuthors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAuthors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAuthors.Columns.AddRange(new DataGridViewColumn[] { colId, colBirth, colCountry, colName });
            dataGridViewAuthors.Dock = DockStyle.Top;
            dataGridViewAuthors.Location = new Point(0, 0);
            dataGridViewAuthors.Name = "dataGridViewAuthors";
            dataGridViewAuthors.Size = new Size(800, 330);
            dataGridViewAuthors.TabIndex = 0;
            dataGridViewAuthors.CellContentClick += dataGridViewAuthors_CellContentClick;
            dataGridViewAuthors.RowValidated += dataGridAuthors_RowValidated;
            // 
            // colId
            // 
            colId.HeaderText = "Id";
            colId.Name = "colId";
            colId.Visible = false;
            // 
            // colBirth
            // 
            colBirth.HeaderText = "BirthYear";
            colBirth.Name = "colBirth";
            // 
            // colCountry
            // 
            colCountry.HeaderText = "Country";
            colCountry.Name = "colCountry";
            // 
            // colName
            // 
            colName.HeaderText = "Full Name";
            colName.Name = "colName";
            // 
            // txtBirth
            // 
            txtBirth.Location = new Point(0, 336);
            txtBirth.Name = "txtBirth";
            txtBirth.Size = new Size(231, 23);
            txtBirth.TabIndex = 1;
            txtBirth.Text = "BirthYear";
            txtBirth.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(237, 336);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(232, 23);
            txtCountry.TabIndex = 2;
            txtCountry.Text = "Country";
            txtCountry.TextAlign = HorizontalAlignment.Center;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(475, 336);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(313, 23);
            txtFullName.TabIndex = 3;
            txtFullName.Text = "Full name";
            txtFullName.TextAlign = HorizontalAlignment.Center;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(475, 376);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(313, 62);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(0, 376);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(231, 62);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(237, 376);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(232, 62);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // AuthorsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(btnSave);
            Controls.Add(txtFullName);
            Controls.Add(txtCountry);
            Controls.Add(txtBirth);
            Controls.Add(dataGridViewAuthors);
            Name = "AuthorsForm";
            Text = "AuthorsForm";
            Load += AuthorsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAuthors).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewAuthors;
        private TextBox txtBirth;
        private TextBox txtCountry;
        private TextBox txtFullName;
        private Button btnSave;
        private Button btnAdd;
        private Button btnDelete;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colBirth;
        private DataGridViewTextBoxColumn colCountry;
        private DataGridViewTextBoxColumn colName;
    }
}