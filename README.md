🌟 ASP.NET Core User Management Web API

A full-featured User Management Web API built with ASP.NET Core in Visual Studio, designed to manage users across South African universities and their campuses 🎓🌍 for the Nazareth Baptist church Tetiary Students Assosiation (NATESA).
This application provides secure registration, login, and role management, complete with Entity Framework Core database integration and JWT authentication for safe, production-ready user management.

✨ Core Features

User Registration & Login 🔑

Strong password validation (8–15 characters, at least 1 uppercase letter and 1 special character)

Password hashing with BCrypt for enhanced security

Role & Status Management ⚡

Roles: Admin, BranchRep, Alumni, Member

Status: Pending, Active, Inactive

University & Campus Data 🏫

Pre-seeded South African universities and their campuses with fixed GUIDs for stable migrations

Secure API 🔒

JWT token-based authentication for protected endpoints

TECNOLOGY USED:

ASP.NET Core (Web API development)
Entity Framework Core (Database ORM)
SQL Server / SQLite	(Database options)
JWT	(Authentication)
BCrypt	(Password hashing)
C#	(Backend programming language)
🚀 Getting Started

1️⃣ Prerequisites

Ensure you have the following installed:

Visual Studio 2022 (with the ASP.NET and web development workload)

.NET 7 or later SDK

SQL Server or SQLite

2️⃣ Clone the Repository

   (git clone https://github.com/<your-username>/<your-repository>.git
cd <your-repository>)

3️⃣ Open the Project:
    Open the solution (.sln file) in Visual Studio.

4️⃣ Configure the Database Connection:

        Update the connection string in appsettings.json to match your database setup:
        ("ConnectionStrings": {
    "DefaultConnection": "Server=.;Database=UserManagementDb;Trusted_Connection=True;MultipleActiveResultSets=true"
    }
    )
5️⃣ Run Database Migrations

    Open the Package Manager Console in Visual Studio and run:
        Add-Migration "InitialCreate"
    Update-Database
    This will create the database and seed it with universities, campuses, and any default data.

6️⃣ Run the Application:
    The API will start (default: https://localhost:5001 or http://localhost:5000).


🔑 API Endpoints
Method-Endpoint-Description	Auth Required
POST-/api/auth/register-Register a new user	❌
POST-/api/auth/login-Authenticate user & return JWT	❌
GET-/api/users-Get a list of all users	✅
GET-/api/users/{id}-Retrieve details of a specific user	✅
PUT-/api/users/{id}-Update a user	✅
DELETE-/api/users/{id}-Delete a user	✅  

🏫 Seeded Universities and Campuses

Below is a list of example seeded data (with GUIDs) that you can use when registering or testing users:

University-GUID (Example)-Campus Name-Campus Code-Campus GUID (Example)
North-West University (NWU)_11111111-1111-1111-1111-111111111111_PotchefstroomCampus_1A_aaaa1111-1111-1111-1111-111111111111
	 Vaal Triangle Campus_1B_aaaa2222-2222-2222-2222-222222222222
		Mahikeng Campus_1C_aaaa3333-3333-3333-3333-333333333333

⚡ Note: GUIDs above is an example used during seeding in OnModelCreating.
It remains constant after migrations, ensuring consistent testing.

📜 License

This project is licensed under the MIT License – see the LICENSE file for details.
 


        

