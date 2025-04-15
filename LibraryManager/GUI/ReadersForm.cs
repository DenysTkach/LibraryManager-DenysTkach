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
    public partial class ReadersForm : Form
    {
        public ReadersForm()
        {
            InitializeComponent();
        }

        private void ReadersForm_Load(object sender, EventArgs e)
        {
            LoadReaders();
        }

        private void LoadReaders()
        {
            dataGridReaders.Rows.Clear();

            using var conn = new SqliteConnection(DatabaseService.ConnectionString);
            conn.Open();
            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Readers";

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dataGridReaders.Rows.Add(
                    reader.GetInt32(0),                        // Id
                    reader.GetString(1),                       // FullName
                    reader.GetString(2),                       // Contact
                    DateTime.Parse(reader.GetString(3)).ToShortDateString()  // Registered
                );
            }
        }



        private void txtFullName_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = !string.IsNullOrWhiteSpace(txtFullName.Text);
        }


        private void dataGridReaders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridReaders.Rows[e.RowIndex];
                txtFullName.Text = row.Cells[1].Value.ToString();
                txtContact.Text = row.Cells[2].Value.ToString();
                dtpRegistered.Value = DateTime.Parse(row.Cells[3].Value.ToString());
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtFullName.Text;
            string contact = txtContact.Text;
            string date = dtpRegistered.Value.ToString("s");

            using var conn = new SqliteConnection(DatabaseService.ConnectionString);
            conn.Open();
            var cmd = conn.CreateCommand();
            cmd.CommandText = @"INSERT INTO Readers (FullName, Contact, Registered)
                        VALUES ($name, $contact, $date)";
            cmd.Parameters.AddWithValue("$name", name);
            cmd.Parameters.AddWithValue("$contact", contact);
            cmd.Parameters.AddWithValue("$date", date);
            cmd.ExecuteNonQuery();

            LoadReaders();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridReaders.SelectedRows.Count > 0)
            {
                // Получаем ID из первой ячейки выбранной строки
                int id = (int)dataGridReaders.SelectedRows[0].Cells[0].Value;

                // Подтверждение удаления
                var confirm = MessageBox.Show("Вы действительно хотите удалить выбранного читателя?",
                                              "Подтверждение удаления",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    using var conn = new SqliteConnection(DatabaseService.ConnectionString);
                    conn.Open();
                    var cmd = conn.CreateCommand();
                    cmd.CommandText = "DELETE FROM Readers WHERE Id = $id";
                    cmd.Parameters.AddWithValue("$id", id);
                    cmd.ExecuteNonQuery();

                    // Обновим список после удаления
                    LoadReaders();
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите строку для удаления.", "Нет выбранной строки",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridReaders_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dataGridReaders.Rows.Count)
                return;

            var row = dataGridReaders.Rows[e.RowIndex];
            if (row.IsNewRow || row.Cells[0].Value == null)
                return;

            try
            {
                int id = Convert.ToInt32(row.Cells[0].Value);
                string fullName = row.Cells[1].Value?.ToString() ?? "";
                string contact = row.Cells[2].Value?.ToString() ?? "";
                string registered = row.Cells[3].Value?.ToString();

                using var conn = new SqliteConnection(DatabaseService.ConnectionString);
                conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"
            UPDATE Readers
            SET FullName = $name,
                Contact = $contact,
                Registered = $reg
            WHERE Id = $id";
                cmd.Parameters.AddWithValue("$id", id);
                cmd.Parameters.AddWithValue("$name", fullName);
                cmd.Parameters.AddWithValue("$contact", contact);
                cmd.Parameters.AddWithValue("$reg", registered);
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
