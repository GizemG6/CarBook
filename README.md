CarBook Project
-------------------
Course Link: https://www.udemy.com/course/aspnet-core-api-8-onion-architecture-ile-bookcar-projesi/

I would like to express my gratitude to Murat Yücedağ for their support and guidance.

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

Below are a few screenshots from the project
---------------------------------------------
Login/Index

•Secure authentication and authorization implemented using JWT tokens.

![Ekran görüntüsü 2024-12-12 233536](https://github.com/user-attachments/assets/fdb3d12c-5a78-47b8-9753-058969d64440)

Default/Index

![Ekran görüntüsü 2024-12-12 233606](https://github.com/user-attachments/assets/165547b2-ab39-48df-afbd-6d6b88902594)

Default/Index

•Here is a section listing suitable vehicles.

![Ekran görüntüsü 2024-12-12 233617](https://github.com/user-attachments/assets/426108fd-5d87-428c-9236-b9fd2d3ba07d)

About/Index

![Ekran görüntüsü 2024-12-12 233643](https://github.com/user-attachments/assets/92f1abcc-78fb-4539-b7c6-72d2c3faf718)

Default/Index

•The section on the home page where the latest blog posts are located

•When clicked "Devamını Oku" it will be sent to Blog/Index page.

![Ekran görüntüsü 2024-12-12 233658](https://github.com/user-attachments/assets/c755e02f-4d3f-4b37-a319-098d857a8d3d)

Footer

![Ekran görüntüsü 2024-12-12 233718](https://github.com/user-attachments/assets/3a10f89e-e711-4057-a36e-8ab679aa2cbc)

Customer Reviews

![Ekran görüntüsü 2024-12-12 233805](https://github.com/user-attachments/assets/04e86ea8-5a4a-488b-a3fa-c2e0835f6a06)

Car/Index

![Ekran görüntüsü 2024-12-12 233828](https://github.com/user-attachments/assets/cac8b851-6c5c-4183-8bb0-ae039cbdc81b)

CarPricing/Index

![Ekran görüntüsü 2024-12-12 233848](https://github.com/user-attachments/assets/0f077ab8-db71-4f60-895d-47d2e56158bd)

Blog/BlogDetail

![Ekran görüntüsü 2024-12-12 233909](https://github.com/user-attachments/assets/309ce460-ef62-4d86-85df-c24b5eee36c1)

Contact/Index

![Ekran görüntüsü 2024-12-12 233930](https://github.com/user-attachments/assets/22b88166-0400-44b8-86d3-5ad754da9c34)

BOOKCAR ADMIN
-----------------------
•A separate panel that includes all admin operations

Admin/AdminStatistics/Index

•Here all statistics about carbook are shown

![Ekran görüntüsü 2024-12-12 234013](https://github.com/user-attachments/assets/d81f58fc-a775-4458-be01-d4115ecee809)

AdminCar/Index

•Where all transactions related to cars are located

•Admin can perform operations such as adding cars, deleting, updating, assigning features.

![Ekran görüntüsü 2024-12-12 234024](https://github.com/user-attachments/assets/e527459f-50d8-42df-8664-591841c9a754)

Admin/AdminBlog/Index

•Admin performs all blog-related operations here.

![Ekran görüntüsü 2024-12-12 234045](https://github.com/user-attachments/assets/d1c81fe3-557a-4f92-b6fb-6677a2219fcf)


