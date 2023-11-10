# Overview


This is a Library GUI that uses a SQL database to keep track of the books, and library members. Using windows forms, the program submits queries to SQL in order to retrieve information and update book information. Users are able to check books in, check them out, look up membership information and search the book catalog.

This project was meant to help me discover SQL and how I can use other programs to interact with it.

[Software Demo Video](https://youtu.be/dM-Iwr0GK24)

# Relational Database

SQL, or Structured Query Language, is designed for creating and managing relational databases. It allows user's to enter specific commands or "queries" in order to retrieve, modify, or create information from data tables. 

This program makes use of two tables: The LibraryMembers table, and the BookCatalog table. They are connected by the "Borrower" column in the book catalog which keeps track of member IDs. The BookCatalog keeps track of the information of several books such as, title, author, genre etc. The Library Members table keeps track of the IDs, card numbers, and names of library patrons.


# Development Environment
-MySQL
-Visual Studio
-Windows Forms

Besides SQL, this program was developed using C# and Windows Forms. MySQLClient was used to facilitate the connection between C# and SQL.

# Useful Websites

- [Videos 1-3 of MySQL Database App](https://www.youtube.com/watch?v=9CM4NAH7gTg&list=PLhPyEFL5u-i3Tyw0GtekMrHCukldmtf7k&index=4)
- [Learn Basic SQL in 15 Minutes](https://www.youtube.com/watch?v=kbKty5ZVKMY&t=173s)

# Future Work

- Look into keeping track of books checked out in the libraryMembers table.
- Add more items to the database
- Refine the look and feel of the GUI
