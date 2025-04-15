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

![image](https://github.com/user-attachments/assets/02a5cb4f-1629-4b00-ac19-fcd3b81a7ec1)


---

## 🧩 Main Features

- View, add, delete, and edit:
  - 📘 Books
  - 👨‍🎨 Authors
  - 🧍 Readers
- Automatic database saving when editing rows (`RowValidated`)
- Manual table refresh via the **Refresh** button
- Dialog forms with input validation (e.g. numeric-only year field)
- Book-to-author and book-to-reader linking
- Book borrowing with timestamp

---

## 🗃️ Database Schema

![image](https://github.com/user-attachments/assets/02234f3e-aada-4824-b1e8-ed2522d25542)

---

## 🖼️ User Interface

The application consists of four main forms:

### 🏠 MainForm

- Serves as the main menu of the application.
- Includes buttons to open:
  - **Books Form**
  - **Authors Form**
  - **Readers Form**
- Displays a table of all books with their titles, authors, borrowers, and borrowed dates.
- Includes a **Refresh** button to reload data from the database.

### 📘 BooksForm

- Allows adding, editing, and deleting book records.
- Provides:
  - `TextBox` for book title
  - `TextBox` for publication year
  - `ComboBox` to select the author
  - `ComboBox` to assign the book to a reader (optional)
- Books are displayed in a `DataGridView`
- Supports direct row editing with automatic saving

### 👨‍🎨 AuthorsForm

- Manages authors in the library
- Provides:
  - `TextBox` for full name
  - `TextBox` for country
  - `TextBox` for birth year
- Authors are displayed in a `DataGridView`
- Inline editing is supported (auto-save on row validation)

### 🧍 ReadersForm

- Manages readers (people who borrow books)
- Provides:
  - `TextBox` for full name
  - `TextBox` for contact information
  - `DateTimePicker` for registration date
- Readers are displayed in a `DataGridView`
- Supports adding and editing reader information

All forms feature:
- Clean, responsive layout
- Input validation and user-friendly warnings
- Automatic database synchronization on row changes

