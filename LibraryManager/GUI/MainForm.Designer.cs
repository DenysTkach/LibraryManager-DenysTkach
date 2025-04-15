namespace LibraryManager
{
    partial class MainForm
    {
        /// <summary>  
        ///  Required designer variable.  
        /// </summary>  
        private System.ComponentModel.IContainer components = null;

        /// <summary>  
        ///  Clean up any resources being used.  
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
        ///  Required method for Designer support - do not modify  
        ///  the contents of this method with the code editor.  
        /// </summary>  
        private void InitializeComponent()
        {
            btnBooks = new Button();
            btnReaders = new Button();
            btnAuthors = new Button();
            dataGridMainBooks = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colTitle = new DataGridViewTextBoxColumn();
            colYear = new DataGridViewTextBoxColumn();
            colAuthor = new DataGridViewTextBoxColumn();
            colReader = new DataGridViewTextBoxColumn();
            colBorrowed = new DataGridViewTextBoxColumn();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridMainBooks).BeginInit();
            SuspendLayout();
            // 
            // btnBooks
            // 
            btnBooks.Location = new Point(138, 365);
            btnBooks.Name = "btnBooks";
            btnBooks.Size = new Size(217, 81);
            btnBooks.TabIndex = 0;
            btnBooks.Text = "Books";
            btnBooks.UseVisualStyleBackColor = true;
            btnBooks.Click += btnBooks_Click;
            // 
            // btnReaders
            // 
            btnReaders.Location = new Point(568, 365);
            btnReaders.Name = "btnReaders";
            btnReaders.Size = new Size(230, 81);
            btnReaders.TabIndex = 1;
            btnReaders.Text = "Readers";
            btnReaders.UseVisualStyleBackColor = true;
            btnReaders.Click += btnReaders_Click;
            // 
            // btnAuthors
            // 
            btnAuthors.Location = new Point(361, 365);
            btnAuthors.Name = "btnAuthors";
            btnAuthors.Size = new Size(201, 81);
            btnAuthors.TabIndex = 2;
            btnAuthors.Text = "Authors";
            btnAuthors.UseVisualStyleBackColor = true;
            btnAuthors.Click += btnAuthors_Click;
            // 
            // dataGridMainBooks
            // 
            dataGridMainBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridMainBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridMainBooks.Columns.AddRange(new DataGridViewColumn[] { colId, colTitle, colYear, colAuthor, colReader, colBorrowed });
            dataGridMainBooks.Location = new Point(1, 0);
            dataGridMainBooks.Name = "dataGridMainBooks";
            dataGridMainBooks.Size = new Size(797, 359);
            dataGridMainBooks.TabIndex = 3;
            dataGridMainBooks.CellContentClick += dataGridMainBooks_CellContentClick;
            dataGridMainBooks.RowValidated += this.dataGridMainBooks_RowValidated;
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
            // colBorrowed
            // 
            colBorrowed.HeaderText = "Borrowed Time";
            colBorrowed.Name = "colBorrowed";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(1, 365);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(131, 81);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRefresh);
            Controls.Add(dataGridMainBooks);
            Controls.Add(btnAuthors);
            Controls.Add(btnReaders);
            Controls.Add(btnBooks);
            Name = "MainForm";
            Text = "Library";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridMainBooks).EndInit();
            ResumeLayout(false);
        }

        // Add the missing event handler method to resolve the error.
        private void dataGridMainBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Add logic here if needed, or leave empty if no action is required.
        }

        #endregion

        private Button btnBooks;
        private Button btnReaders;
        private Button btnAuthors;
        private DataGridView dataGridMainBooks;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colTitle;
        private DataGridViewTextBoxColumn colYear;
        private DataGridViewTextBoxColumn colAuthor;
        private DataGridViewTextBoxColumn colReader;
        private DataGridViewTextBoxColumn colBorrowed;
        private Button btnRefresh;
    }
}
