using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManager.Services;
using Microsoft.Data.Sqlite;

namespace LibraryManager.GUI
{
    public partial class BooksForm : Form
    {
        public BooksForm()
        {
            InitializeComponent();
        }

        private void BooksForm_Load(object sender, EventArgs e)
        {
            LoadAuthorsAndReaders();
            LoadBooks();
        }

        private void LoadBooks()
        {
            dataGridBooks.Rows.Clear();

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
                dataGridBooks.Rows.Add(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetInt32(2),
                    reader.IsDBNull(3) ? "—" : reader.GetString(3),
                    reader.IsDBNull(4) ? "—" : reader.GetString(4),
                    reader.IsDBNull(5) ? "—" : reader.GetString(5)
                );
            }
        }


        private void LoadAuthorsAndReaders()
        {
            using var conn = new SqliteConnection(DatabaseService.ConnectionString);
            conn.Open();

            // === Загрузка авторов ===
            var cmd1 = conn.CreateCommand();
            cmd1.CommandText = "SELECT Id, FullName FROM Authors";
            using var reader1 = cmd1.ExecuteReader();

            var authors = new List<KeyValuePair<int, string>>();
            while (reader1.Read())
            {
                authors.Add(new KeyValuePair<int, string>(
                    reader1.GetInt32(0),
                    reader1.GetString(1)
                ));
            }

            cmbAuthor.DataSource = new BindingSource(authors, null);
            cmbAuthor.DisplayMember = "Value";
            cmbAuthor.ValueMember = "Key";

            // === Загрузка читателей ===
            var cmd2 = conn.CreateCommand();
            cmd2.CommandText = "SELECT Id, FullName FROM Readers";
            using var reader2 = cmd2.ExecuteReader();

            var readers = new List<KeyValuePair<int, string>>();
            readers.Add(new KeyValuePair<int, string>(-1, "— (не выдана)"));  // опция "нет читателя"
            while (reader2.Read())
            {
                readers.Add(new KeyValuePair<int, string>(
                    reader2.GetInt32(0),
                    reader2.GetString(1)
                ));
            }

            cmbReader.DataSource = new BindingSource(readers, null);
            cmbReader.DisplayMember = "Value";
            cmbReader.ValueMember = "Key";
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            int year = int.TryParse(txtYear.Text, out var y) ? y : 0;
            int authorId = ((KeyValuePair<int, string>)cmbAuthor.SelectedItem).Key;
            int readerId = ((KeyValuePair<int, string>)cmbReader.SelectedItem).Key;

            using var conn = new SqliteConnection(DatabaseService.ConnectionString);
            conn.Open();
            var cmd = conn.CreateCommand();
            cmd.CommandText = @"
        INSERT INTO Books (Title, Year, AuthorId, ReaderId, BorrowedDate)
        VALUES ($title, $year, $author, $reader, $date)";
            cmd.Parameters.AddWithValue("$title", title);
            cmd.Parameters.AddWithValue("$year", year);
            cmd.Parameters.AddWithValue("$author", authorId);
            cmd.Parameters.AddWithValue("$reader", readerId == -1 ? DBNull.Value : (object)readerId);
            cmd.Parameters.AddWithValue("$date", readerId == -1 ? DBNull.Value : DateTime.Now.ToString("s"));
            cmd.ExecuteNonQuery();

            LoadBooks();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridBooks.SelectedRows.Count > 0)
            {
                int id = (int)dataGridBooks.SelectedRows[0].Cells[0].Value;

                var confirm = MessageBox.Show("Delete the selected book?", "Confirmation", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    using var conn = new SqliteConnection(DatabaseService.ConnectionString);
                    conn.Open();
                    var cmd = conn.CreateCommand();
                    cmd.CommandText = "DELETE FROM Books WHERE Id = $id";
                    cmd.Parameters.AddWithValue("$id", id);
                    cmd.ExecuteNonQuery();

                    LoadBooks();
                }
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            LoadBooks();
            this.Close();
        }

        private void dataGridBooks_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dataGridBooks.Rows.Count)
                return;

            var row = dataGridBooks.Rows[e.RowIndex];
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
