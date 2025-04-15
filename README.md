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

##🗃️ Database Schema

![image](https://github.com/user-attachments/assets/02234f3e-aada-4824-b1e8-ed2522d25542)


