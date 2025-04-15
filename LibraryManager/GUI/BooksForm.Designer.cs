namespace LibraryManager.GUI
{
    partial class BooksForm
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
            dataGridBooks = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colTitle = new DataGridViewTextBoxColumn();
            colYear = new DataGridViewTextBoxColumn();
            colAuthor = new DataGridViewTextBoxColumn();
            colReader = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            txtYear = new TextBox();
            txtTitle = new TextBox();
            cmbAuthor = new ComboBox();
            cmbReader = new ComboBox();
            btnAdd = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridBooks).BeginInit();
            SuspendLayout();
            // 
            // dataGridBooks
            // 
            dataGridBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridBooks.Columns.AddRange(new DataGridViewColumn[] { colId, colTitle, colYear, colAuthor, colReader, colDate });
            dataGridBooks.Location = new Point(12, 12);
            dataGridBooks.Name = "dataGridBooks";
            dataGridBooks.Size = new Size(776, 324);
            dataGridBooks.TabIndex = 0;
            dataGridBooks.CellContentClick += dataGridView1_CellContentClick;
            dataGridBooks.RowValidated += dataGridBooks_RowValidated;
            // 
            // colId
            // 
            colId.HeaderText = "Id";
            colId.Name = "colId";
            colId.Visible = false;
            // 
            // colTitle
            // 
            colTitle.HeaderText = "Title";
            colTitle.Name = "colTitle";
            // 
            // colYear
            // 
            colYear.HeaderText = "Year";
            colYear.Name = "colYear";
            // 
            // colAuthor
            // 
            colAuthor.HeaderText = "Author";
            colAuthor.Name = "colAuthor";
            // 
            // colReader
            // 
            colReader.HeaderText = "Reader";
            colReader.Name = "colReader";
            // 
            // colDate
            // 
            colDate.HeaderText = "Borrowed Date";
            colDate.Name = "colDate";
            // 
            // txtYear
            // 
            txtYear.Location = new Point(673, 354);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(115, 23);
            txtYear.TabIndex = 1;
            txtYear.Text = "Year of publication";
            txtYear.TextAlign = HorizontalAlignment.Center;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(430, 354);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(237, 23);
            txtTitle.TabIndex = 2;
            txtTitle.Text = "The name of the book";
            txtTitle.TextAlign = HorizontalAlignment.Center;
            // 
            // cmbAuthor
            // 
            cmbAuthor.FormattingEnabled = true;
            cmbAuthor.Location = new Point(228, 354);
            cmbAuthor.Name = "cmbAuthor";
            cmbAuthor.Size = new Size(196, 23);
            cmbAuthor.TabIndex = 3;
            cmbAuthor.Text = "Author";
            // 
            // cmbReader
            // 
            cmbReader.FormattingEnabled = true;
            cmbReader.Location = new Point(12, 354);
            cmbReader.Name = "cmbReader";
            cmbReader.Size = new Size(208, 23);
            cmbReader.TabIndex = 4;
            cmbReader.Text = "Reader";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 383);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(208, 58);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(430, 383);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(358, 58);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(226, 383);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(198, 58);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // BooksForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 443);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnAdd);
            Controls.Add(cmbReader);
            Controls.Add(cmbAuthor);
            Controls.Add(txtTitle);
            Controls.Add(txtYear);
            Controls.Add(dataGridBooks);
            Name = "BooksForm";
            Text = "BooksForm";
            Load += BooksForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridBooks;
        private TextBox txtYear;
        private TextBox txtTitle;
        private ComboBox cmbAuthor;
        private ComboBox cmbReader;
        private Button btnAdd;
        private Button btnSave;
        private Button btnDelete;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colTitle;
        private DataGridViewTextBoxColumn colYear;
        private DataGridViewTextBoxColumn colAuthor;
        private DataGridViewTextBoxColumn colReader;
        private DataGridViewTextBoxColumn colDate;
    }
}