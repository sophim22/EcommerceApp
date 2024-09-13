# EcommerceApp

This is an ASP.NET Core MVC project for a simple eCommerce application with user registration, login, and logout features.

## Features

- User registration with hashed passwords
- Login/Logout functionality
- Home, About, and Contact pages
- SQLite database integration

## Requirements

- .NET 7.0 SDK or later

## Setup Instructions

### 1. Clone the repository

```bash
git clone https://github.com/yourusername/EcommerceApp.git
cd EcommerceApp

2. Configure the database connection

The project uses SQLite as the database. The database configuration is set in the appsettings.json file, which is located in the root of the project.

```{
  "ConnectionStrings": {
    "DefaultConnection": "Data Source=YourApp.db;"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "AllowedHosts": "*"
}```

This configuration specifies that SQLite will store the database in a file called EcommerceApp.db in the root folder of the project.

3. Apply Migrations

To create the SQLite database and apply the migrations, run the following command:

```dotnet ef database update```

This command will generate the EcommerceApp.db file.

4. Run the Application

Start the application by running:

```dotnet run```

Once the application starts, open your browser and navigate to https://localhost:5001 to view the app.

5. Register a New User

To create a new user account, visit /Account/Register.

6. Login/Logout

	•	To log in, visit /Account/Login.
	•	To log out, visit /Account/Logout.

Database Configuration

The application is configured to use SQLite by default. SQLite is a lightweight, file-based database, and it does not require any additional setup or installation.

7. Optional: Entity Framework Migrations

If you need to modify the database schema, you can create new migrations using the following command:

```dotnet ef migrations add MigrationName
dotnet ef database update```# EcommerceApp
