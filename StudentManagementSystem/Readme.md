# Student Management Software

## Description

This **console-based student management application** is built in C# and designed to manage student records. It allows users to easily perform various operations such as adding, updating, removing, and searching for students. The application also includes features for sorting and filtering students based on attributes like GPA and age.

The software is designed for simple student record management, where each student has a unique ID, name, age, and GPA. Users can interact with the program through a text-based menu, making it easy to perform CRUD operations on student data.

### Features
- **Add a Student**: Allows users to input and add new student records to the system.
- **Search by ID**: Find a student by their unique ID.
- **Remove a Student**: Delete a student record by their ID.
- **Search by Name**: Search for a student by their name.
- **Update Student**: Modify existing student information, including name, age, and GPA.
- **View All Students**: Display a list of all student records.
- **Sort Students**: Sort the student list by name, age, or GPA.
- **Filter Students**: Filter students based on GPA (lower bound, range) or age.

## How It Works

The program runs in a loop, continuously offering the user options from a menu. The user can select from various options such as adding a student, updating data, or sorting the list. The program performs the corresponding operation based on the user's input and displays the result.

The student data is stored temporarily in a list during the program's runtime. Once the program closes, all the data is lost (persistence can be added in future versions).

### Operations

- **Adding a Student**: Users can press `1` to add a new student by entering their name, age, and GPA. A unique ID is assigned automatically.
- **Searching and Removing Students**: Press `2` to search for a student by ID, or `3` to remove a student by ID.
- **Sorting and Filtering**: Users can sort students by their name, age, or GPA, and can also filter students based on GPA or age criteria.

## Future Improvements

While this is a basic console-based application, there are several potential improvements to consider:

### 1. **Error Handling and Validation**
   - Implement more detailed `try-catch` blocks and input validation to handle incorrect or unexpected inputs (e.g., non-numeric values for age or GPA).
   - Provide user-friendly error messages when invalid data is entered.

### 2. **Persistent Data Storage**
   - Currently, all student data is stored in memory and is lost when the program exits. To improve this, we can integrate a **SQL Server (MSSQL)** database using **Entity Framework Core** to persist student records.
   - Using an ORM like **Entity Framework** allows you to work with the database in an object-oriented way, making it easier to perform CRUD operations.

### 3. **Graphical User Interface (GUI)**
   - The current application is purely console-based. To improve the user experience, you can transition to a **Windows Forms** or **WPF** application for desktop environments, or even build a web-based UI with **ASP.NET Core Blazor**.
   - A GUI would allow for more intuitive interaction with the software through buttons, forms, and data grids.

### 4. **MVC Architecture for Backend Service**
   - Refactor the application to follow **MVC (Model-View-Controller)** architecture for better scalability and maintainability.
   - **Model**: Represents the data (student) and business logic (CRUD operations).
   - **View**: The front-end user interface (CLI, Windows Forms, or Web UI).
   - **Controller**: Handles user input, processes the data, and updates the view accordingly.

### 5. **API Integration**
   - Transition the application to a **Web API** using **ASP.NET Core**. This would allow students' data to be accessed and managed over HTTP requests, enabling integration with other systems or a front-end UI.
   - The backend API could expose endpoints for CRUD operations and other features like sorting and filtering.

---

This project serves as a starting point for a fully-fledged student management system, with the potential for enhancement in many areas such as **error handling**, **data persistence**, and **user interface**. The flexibility of the software allows for growth in terms of features and architecture.

