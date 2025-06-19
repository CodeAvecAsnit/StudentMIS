# 🧑‍💼 Employee Management System (ASP.NET Core)

This project is an **Employee Management System** built with **ASP.NET Core Web API**. It allows tech companies to post and manage employee data such as name, phone number, salary, and address. It uses a CSV file (`Users.csv`) for data storage instead of a database, making it simple and portable.

---

## Features

- Add new employees
- Retrieve all employees
- Search employees by:
  - Username
  - Phone number
  - Address
- Filter employees by:
  - Minimum salary
  - Maximum salary
  - Salary range (min and max)
- CSV-based persistence using CsvHelper

---

##  API Endpoints

| Method | Endpoint                           | Query Params         | Description                        |
|--------|------------------------------------|----------------------|------------------------------------|
| GET    | `/api/user/employees/all`          | —                    | Returns all employees              |
| POST   | `/api/user/post`                   | — (JSON body)        | Inserts a new employee             |
| GET    | `/api/user/username`               | `userName=...`       | Gets employee by username          |
| GET    | `/api/user/phone`                  | `number=...`         | Gets employee by phone number      |
| GET    | `/api/user/address`                | `address=...`        | Finds employees by address         |
| GET    | `/api/user/salary/min`             | `min=...`            | Filters employees with salary > min |
| GET    | `/api/user/salary/max`             | `max=...`            | Filters employees with salary < max |
| GET    | `/api/user/salary/range`           | `min=...&max=...`    | Filters employees within salary range |

---

##  Data Format

All employee data is stored in a CSV file located at `Data/Users.csv`. Each record includes:

- Username
- Phone number
- Salary
- Address

