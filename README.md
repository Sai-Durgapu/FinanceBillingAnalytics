Finance Billing Analytics Platform
Project Description
Finance Billing Analytics Platform is a web-based financial management system developed using ASP.NET Core 8, Entity Framework Core, SQL Server, MVC, Web API and Clean Architecture principles.
Objectives
Customer Management, Invoice Management, Payment Management and Dashboard Analytics.
Technologies Used
ASP.NET Core 8, C#, SQL Server, Entity Framework Core, MVC, Web API, AutoMapper, FluentValidation, JWT Authentication, Swagger and Bootstrap.
Architecture
User -> MVC Web Application -> Web API -> Application Layer -> Infrastructure Layer -> SQL Server Database
Domain Layer Folder contains
Contains Entities, Enums, Exceptions and Business Rules.
Application Layer folder contains
Contains DTOs, Interfaces, Services, Validators and AutoMapper Profiles.
Infrastructure Layer contains
Contains DbContext, Repositories, Configurations, Identity and Security.
API Layer contains
Contains Controllers, Middleware, Swagger Configuration and Authentication.
MVC Layer contains
Contains Controllers, Views, Models and User Interface components.
Database Relationships
Customer (1:N) Invoice, Invoice (1:N) Payment.
Project Flow
User -> View -> Controller -> API -> Service -> Repository -> DbContext -> SQL Server -> Response
Advantages of Clean Architecture
Separation of Concerns, Maintainability, Scalability, Reusability and Testability.
Complete Folder Structure
FinanceBillingAnalytics
|- FinanceBilling.Domain
|- FinanceBilling.Application
|- FinanceBilling.Infrastructure
|- FinanceBilling.API
|- FinanceBilling.Web
