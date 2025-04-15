# LibraryManager
# 📚 LibraryManager — Book Management System for a Library

LibraryManager is a simple Windows Forms application for managing a small library using a local SQLite database. It allows users to manage books, authors, and readers, assign books to readers, and automatically saves all changes made in tables.

--- 

## 🔧 Technologies Used

- Language: **C#**
- GUI: **Windows Forms (.NET 8)**
- Database: **SQLite** via `Microsoft.Data.Sqlite`
- IDE: **Visual Studio 2022**
- Version Control: **Git + GitHub**

---

## 📁 Project Structure


![image](https://github.com/user-attachments/assets/01cda266-2ca4-4b30-a229-c1e2666930ab)


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

The application uses a local SQLite database named `library.db`, which is automatically created on the first launch. It contains three main tables with foreign key relationships:

---

### 📘 Books

Stores information about books and their current lending status.

| Column         | Type     | Description                             |
|----------------|----------|-----------------------------------------|
| `Id`           | INTEGER  | Primary key (autoincrement)             |
| `Title`        | TEXT     | Book title                              |
| `Year`         | INTEGER  | Year of publication                     |
| `AuthorId`     | INTEGER  | Foreign key → `Authors(Id)`             |
| `ReaderId`     | INTEGER  | Foreign key → `Readers(Id)` (nullable)  |
| `BorrowedDate` | TEXT     | Date when the book was borrowed (nullable, ISO 8601 format) |

---

### 👨‍🎨 Authors

Stores data about authors.

| Column       | Type     | Description                      |
|--------------|----------|----------------------------------|
| `Id`         | INTEGER  | Primary key (autoincrement)      |
| `FullName`   | TEXT     | Author's full name               |
| `Country`    | TEXT     | Country of origin (optional)     |
| `BirthYear`  | INTEGER  | Year of birth (optional)         |

---

### 🧍 Readers

Stores data about library readers (borrowers).

| Column        | Type     | Description                        |
|---------------|----------|------------------------------------|
| `Id`          | INTEGER  | Primary key (autoincrement)        |
| `FullName`    | TEXT     | Reader's full name                 |
| `Contact`     | TEXT     | Contact information (optional)     |
| `Registered`  | TEXT     | Date of registration (ISO format)  |

---

### 🔗 Relationships

- Each **Book** is linked to **one Author** via `AuthorId`.
- Each **Book** may optionally be linked to a **Reader** via `ReaderId`.
- `BorrowedDate` is only set if the book is currently borrowed.

All foreign keys are enforced by SQLite using `FOREIGN KEY` constraints.

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

