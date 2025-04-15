using LibraryManager.GUI;
using LibraryManager.Services;
using Microsoft.Data.Sqlite;

namespace LibraryManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadBooks();
        }
        private void LoadBooks()
        {
            dataGridMainBooks.Rows.Clear();

            using var conn = new SqliteConnection(DatabaseService.ConnectionString);
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = @"
        SELECT Books.Id, Books.Title, Books.Year, Authors.FullName, Readers.FullName, Books.BorrowedDate
        FROM Books
        LEFT JOIN Authors ON Books.AuthorId = Authors.Id
        LEFT JOIN Readers ON Books.ReaderId = Readers.Id";

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dataGridMainBooks.Rows.Add(
                    reader.GetInt32(0),                      // Id
                    reader.GetString(1),                     // Title
                    reader.GetInt32(2),                      // Year
                    reader.IsDBNull(3) ? "Ч" : reader.GetString(3), // Author
                    reader.IsDBNull(4) ? "Ч" : reader.GetString(4), // Reader
                    reader.IsDBNull(5) ? "Ч" : reader.GetString(5)  // Date
                );
            }
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            var booksForm = new BooksForm();
            booksForm.ShowDialog();
        }

        private void btnAuthors_Click(object sender, EventArgs e)
        {
            var AuthorsForm = new AuthorsForm();
            AuthorsForm.ShowDialog();
        }

        private void btnReaders_Click(object sender, EventArgs e)
        {
            var ReadersForm = new ReadersForm();
            ReadersForm.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadBooks(); // просто перезагружаем таблицу
        }

        private void dataGridMainBooks_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dataGridMainBooks.Rows.Count)
                return;

            var row = dataGridMainBooks.Rows[e.RowIndex];
            if (row.IsNewRow || row.Cells[0].Value == null)
                return;

            try
            {
                int id = Convert.ToInt32(row.Cells[0].Value);
                string title = row.Cells[1].Value?.ToString() ?? "";
                int year = int.TryParse(row.Cells[2].Value?.ToString(), out var y) ? y : 0;

                using var conn = new SqliteConnection(DatabaseService.ConnectionString);
                conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"
            UPDATE Books
            SET Title = $title, Year = $year
            WHERE Id = $id";
                cmd.Parameters.AddWithValue("$id", id);
                cmd.Parameters.AddWithValue("$title", title);
                cmd.Parameters.AddWithValue("$year", year);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while maintaining a line: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}

