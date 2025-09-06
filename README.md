# HR Management System

A lightweight and modular web application for managing employee data, built with **ASP.NET Core 9**, following the **N-Tier Architecture** and **MVC pattern**. This project is designed to help HR departments manage employee records efficiently through a clean UI and RESTful API.

---

## 📌 Features

### 🧾 Employee Management
- Add new employee
- Edit employee details
- Delete employee
- View a list of all employees

### 🔍 Search & Filter
- Search employees by **name** or **email**
- Filter by **department** or **employment status**

### 🧑‍💼 Employee Model
Each employee record contains:
- `Id`: Unique identifier (auto-increment)
- `Name`: Full name
- `DateOfBirth`: Date of birth
- `Email`: Email address
- `Phone`: Phone number
- `Department`: (e.g., HR, Tech, Sales)
- `JobTitle`: Job title
- `HireDate`: Date of hiring
- `Status`: (e.g., Active, On Leave, Terminated)

---

## 🏗️ Tech Stack

| Layer            | Tech                                    |
|------------------|------------------------------------------|
| Frontend         | Tailwind CSS                             |
| Backend API      | ASP.NET Core 9 Web API                   |
| Architecture     | N-Tier (DAL, BLL, Presentation)          |
| ORM              | Entity Framework Core 9                  |
| Database         | SQL Server                               |
| Mapping          |Mapster                                   |

---

## 🧱 Architecture Overview

- **Presentation Layer** (`.Web`): Hosts the RESTful API endpoints and UI
- **Business Logic Layer (BLL)**: Contains service classes and business rules
- **Data Access Layer (DAL)**: Handles database operations using EF Core
- **Model Example:**


---

## 🚀 Getting Started

1. **Clone the repository**
```bash
git clone https://github.com/s0if/HRManagementSystem.git
```
## 📄 Project Report

للاطّلاع على تقرير المشروع باللغة العربية (HTML) والذي يشرح الفكرة، التقنيات، التحديات، والدروس المستفادة:

🔗 [عرض التقرير](https://s0if.github.io/HR_Management_System_Report_Arabic/)
```

2. **Update connection string** in `appsettings.json` to match your local SQL Server / SQLite setup.

3. **Apply migrations**
```bash
dotnet ef database update
```

4. **Run the project**
```bash
dotnet run --project HRManagementSystem.Web
```

---

## 🛠 Packages Used

- `Microsoft.EntityFrameworkCore.SqlServer`
- `Microsoft.EntityFrameworkCore.Design`
- `Microsoft.EntityFrameworkCore.Tools`
- `Microsoft.VisualStudio.Web.CodeGeneration.Design`
- `Mapster`

---


## 📬 Contact

| Platform | Link |
|----------|------|
| **Email**    | [saifalkomi@gmail.com](mailto:saifalkomi@gmail.com) |
| **LinkedIn** | [Saif Al-Din Komi](https://www.linkedin.com/in/saif-aldin-komi) |
| **GitHub**   | [saifaldin komi](https://github.com/s0if) |

---

> This project was created to practice and apply ASP.NET Core MVC principles, Entity Framework Core, and clean architecture in a real-world use case.
