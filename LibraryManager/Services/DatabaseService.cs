using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using System.IO;


namespace LibraryManager.Services
{
    public static class DatabaseService
    {
        private const string DatabaseFile = "library.db";

        public static string ConnectionString => $"Data Source={DatabaseFile}";

        public static void InitializeDatabase()
        {
            if (!File.Exists(DatabaseFile))
            {
                using var connection = new SqliteConnection(ConnectionString);
                connection.Open();

                var cmd = connection.CreateCommand();

                cmd.CommandText = @"
            CREATE TABLE Authors (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                FullName TEXT,
                Country TEXT,
                BirthYear INTEGER
            );

            CREATE TABLE Readers (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                FullName TEXT,
                Contact TEXT,
                Registered TEXT
            );

            CREATE TABLE Books (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Title TEXT NOT NULL,
                Year INTEGER,
                AuthorId INTEGER NULL,
                ReaderId INTEGER,
                BorrowedDate TEXT,
                FOREIGN KEY (AuthorId) REFERENCES Authors(Id) ON DELETE SET NULL,
                FOREIGN KEY (ReaderId) REFERENCES Readers(Id)
            );

            ";
                cmd.ExecuteNonQuery();
            }
        }
    }

}
