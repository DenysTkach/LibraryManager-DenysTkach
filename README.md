# LibraryManager
# 📚 LibraryManager — Book Management System for a Library

LibraryManager is a simple Windows Forms application for managing a small library using a local SQLite database. It allows users to manage books, authors, and readers, assign books to readers, and automatically saves all changes made in tables.

---

## 🔧 Technologies Used

- Language: **C#**
- GUI: **Windows Forms (.NET 6/8)**
- Database: **SQLite** via `Microsoft.Data.Sqlite`
- IDE: **Visual Studio 2022**
- Version Control: **Git + GitHub**

---

## 📦 Project Structure

LibraryManager/ ├── Models/ # Book, Author, Reader classes ├── Forms/ # GUI Forms: BooksForm, AuthorsForm, ReadersForm, MainForm ├── Services/ # DatabaseService.cs ├── Program.cs # Entry point ├── library.db # SQLite database (created on first launch) └── README.md # Project documentation

