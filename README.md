# backend
ASP.NET Core News Management CRUD Web App
A full-featured web application built with ASP.NET Core that demonstrates complete CRUD (Create, Read, Update, Delete) functionality for managing news articles. The application features a public-facing page to display the latest news and a dedicated management page to handle all administrative tasks.

✨ Core Features
News Display: A homepage that fetches and displays the latest news articles from the backend.

Create: Add new news articles through a user-friendly form.

Read: View all existing articles in a clean, structured table.

Update: Edit and save changes to existing articles seamlessly.

Delete: Remove articles with a confirmation prompt to prevent accidental deletion.

RESTful Backend API: A well-structured API built with ASP.NET Core Web API to handle all data operations.

Database Integration: Uses Entity Framework Core to interact with a AWS database.

🛠️ Technologies Used
.NET 8 (Can be adapted for .NET 6+)

ASP.NET Core MVC (For serving web pages)

ASP.NET Core Web API (For the backend API)

Entity Framework Core (For database object-relational mapping)

PostgreSQL (Database)

C#

🚀 Getting Started
Follow these instructions to get a copy of the project up and running on your local machine for development and testing.

Prerequisites
You will need the following software installed on your machine:

Visual Studio 2022 (with the ASP.NET and web development workload)

.NET 8 SDK

PostgreSQL

Installation and Setup
Clone the Repository

git clone (https://github.com/your-username/your-repository-name.git)
cd your-repository-name

Open the Project in Visual Studio

Open the .sln file in Visual Studio.

Configure the Database Connection

Open the appsettings.json file.

Modify the DefaultConnection string to point to your local PostgreSQL instance. You may only need to change the Server name.

"ConnectionStrings": {
  "DefaultConnection": "Host=name_of_endpoint;Database=natesa-spiritsquad-db;Trusted_Connection=True;TrustServerCertificate=True;"
}

Run Database Migrations

This will create the database and the News table based on the code.

In Visual Studio, go to Tools > NuGet Package Manager > Package Manager Console.

Run the following commands:

Add-Migration "InitialCreate"
Update-Database

Run the Application

Press F5 or click the "Run" button in Visual Studio to launch the application.

The homepage will display the latest news.

Navigate to /Home/Manage to access the CRUD management page.

📁 Project Structure
The project follows a standard ASP.NET Core MVC structure:

/Controllers: Contains the HomeController (for serving views) and NewsController (the API).

/Data: Contains ApplicationDbContext.cs, which manages the database connection and tables.

/Models: Defines the NewsArticle.cs data model and its attributes..

appsettings.json: Configuration file for the application, including the database connection string.

Program.cs: The application's entry point, where services like the DbContext are registered.

📝 API Endpoints
The backend exposes the following RESTful API endpoints:

Method

Endpoint

Description

GET

/api/news

Retrieves a list of all news articles.

GET

/api/news/{id}

Retrieves a single news article by its ID.

POST

/api/news

Creates a new news article.

PUT

/api/news/{id}

Updates an existing news article.

DELETE

/api/news/{id}

Deletes a news article.

📜 License
This project is licensed under the MIT License - see the LICENSE file for details.
