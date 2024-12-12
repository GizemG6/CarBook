CarBook Project
-------------------
Course Link: https://www.udemy.com/course/aspnet-core-api-8-onion-architecture-ile-bookcar-projesi/

About the Project
-------------------
CarBook is a car rental platform developed using ASP.NET Core API and .NET 8. The project adopts modern software development approaches and utilizes the following technologies and methodologies:

•Onion Architecture: Ensures separation of concerns with layered architecture.

•Authentication: Secure authentication and authorization implemented using JWT tokens.

•SignalR: Real-time communication and notifications enabled through SignalR.

•MediatR and CQRS: Command and query processing implemented using the MediatR library with the CQRS pattern.

Technologies Used
-------------------
•ASP.NET Core API

•.NET 8

•Entity Framework Core

•SignalR

•JWT (JSON Web Token) Authentication

•MediatR

•SQL Server (used as the database)

Project Architecture
-------------------
The project is structured following the Onion Architecture principles and consists of the following layers:

1-Core:

•Contains the core layer, including the fundamental business rules and models of the project.

•Interfaces and base structures are defined here.

2-Application:

•Contains business logic and services.

•Implements the CQRS pattern using MediatR.

3-Frontend-WebUI:

•UI operations such as View, ViewComponents, Admin Panel were performed.

4-Infrastructure:

•Handles database access and third-party service integrations.

•Repository pattern is used for data access operations.

5-Presentation:

•Hosts API endpoints.

•Processes user requests and routes them to the appropriate services.

Features
-------------------
1. User Authentication

•User login is handled securely using JWT tokens.

•Role-based authorization is implemented (e.g., Admin, User).

2. Vehicle Management

•Allows adding, updating, deleting, and listing vehicles.

3. Real-Time Notifications

•Users receive real-time notifications using SignalR (e.g., reservation approval notifications).

4. Reservation Management

•Users can make vehicle reservations and track their statuses.

Setup and Execution
-------------------
Prerequisites

•.NET 8 SDK

•SQL Server

•Visual Studio or Visual Studio Code

Installation Steps
-------------------
1-Clone the Repository:

```csharp
git clone https://github.com/GizemG6/CarBook
cd CarBook
```

2-Configure Database Connection:

•Update the ConnectionStrings section in the Infrastructure/Context/CarBookContext.cs file with your SQL Server details.

3-Apply Database Migrations:

```csharp
dotnet ef database update
```

4- Run the Project:

```csharp
dotnet run
```

5- Test API Endpoints:

•Use Postman or Swagger to test the endpoints.

