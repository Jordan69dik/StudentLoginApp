StudentLoginApp - Visual Studio 2022 ASP.NET MVC (VB) sample
======================================================

Open the solution file: StudentLoginApp.sln in Visual Studio 2022.

Before running:
1. In Visual Studio's Package Manager Console run:
   Install-Package EntityFramework -Version 6.4.4
   Install-Package MySql.Data -Version 8.0.37
   Install-Package MySql.Data.EntityFramework -Version 8.0.37

2. Update Web.config connection string (StudentRegisterConnection) with your MySQL settings.

3. Build the solution. Entity Framework will create the database on first use (Code-First), or you can enable migrations.
   - To enable migrations: Enable-Migrations (then Add-Migration Initial and Update-Database)

Security note:
- Passwords are stored in plain text for demo simplicity. Replace with hashing for production.

If you want I can also add a .user or .vsconfig file, or pre-populate the database initializer. 
