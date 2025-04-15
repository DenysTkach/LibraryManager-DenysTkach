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
    public partial class AuthorsForm : Form
    {
        public AuthorsForm()
        {
            InitializeComponent();
        }

        private void AuthorsForm_Load(object sender, EventArgs e)
        {
            LoadAuthors();
        }


        private void LoadAuthors()
        {
            dataGridViewAuthors.Rows.Clear();

            using var conn = new SqliteConnection(DatabaseService.ConnectionString);
            conn.Open();
            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Authors";
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dataGridViewAuthors.Rows.Add(
                    reader.GetInt32(0),                    // Id
                    reader.GetString(1),                   // FullName
                    reader.GetString(2),                   // Country
                    reader.GetInt32(3)                     // BirthYear
                );
            }
        }


        private void dataGridViewAuthors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtFullName.Text;
            string country = txtCountry.Text;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Enter the name of the author.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtBirth.Text, out int year))
            {
                MessageBox.Show("The year of birth should be a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var conn = new SqliteConnection(DatabaseService.ConnectionString);
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = @"INSERT INTO Authors (FullName, Country, BirthYear)
                        VALUES ($name, $country, $year)";
            cmd.Parameters.AddWithValue("$name", name);
            cmd.Parameters.AddWithValue("$country", country);
            cmd.Parameters.AddWithValue("$year", year);
            cmd.ExecuteNonQuery();

            txtFullName.Clear();
            txtCountry.Clear();
            txtBirth.Clear();

            LoadAuthors();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewAuthors.SelectedRows.Count > 0)
            {
                int id = (int)dataGridViewAuthors.SelectedRows[0].Cells[0].Value;
                using var conn = new SqliteConnection(DatabaseService.ConnectionString);
                conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM Authors WHERE Id = $id";
                cmd.Parameters.AddWithValue("$id", id);
                cmd.ExecuteNonQuery();

                LoadAuthors();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            LoadAuthors(); // просто обновляет список
            this.Close();

        }

        private void dataGridAuthors_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dataGridViewAuthors.Rows.Count)
                return;

            var row = dataGridViewAuthors.Rows[e.RowIndex];
            if (row.IsNewRow || row.Cells[0].Value == null)
                return;

            try
            {
                int id = Convert.ToInt32(row.Cells[0].Value);
                string fullName = row.Cells[1].Value?.ToString() ?? "";
                string country = row.Cells[2].Value?.ToString() ?? "";
                int birthYear = int.TryParse(row.Cells[3].Value?.ToString(), out var y) ? y : 0;

                using var conn = new SqliteConnection(DatabaseService.ConnectionString);
                conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"
            UPDATE Authors
            SET FullName = $name,
                Country = $country,
                BirthYear = $year
            WHERE Id = $id";
                cmd.Parameters.AddWithValue("$id", id);
                cmd.Parameters.AddWithValue("$name", fullName);
                cmd.Parameters.AddWithValue("$country", country);
                cmd.Parameters.AddWithValue("$year", birthYear);
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
