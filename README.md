# CleanArchitectureAPI

This repo will showcase the use of Clean Architecture in.NetCore Application using CQRS - Mediatr and Repository pattern. This Project can also act as a template for creating new APIs using CQRS and Repository pattern.

# Project Set Up

1. Make sure that database connection string is set up properly in AppSettings.Json
2. dotnet build
3. Run Migrations:
   - add-migration InitialMigration
   - update-database
     It will create the tables and seed data in the both product and category tables
4. dotnet run
5. Swagger will open with all the APIs

# Note
To be able to run the program, you need to:
* If you create a new Model, you need to declare the model in the CleanArchitectureDbContext.cs file located in the Repository folder under CleanArchitecture.Infrastructure to avoid errors during program execution.
* Change your connectionString in the `appsettings.json` file located in the `CleanArchitecture.API` folder.
