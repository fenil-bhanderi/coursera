# User Management API

This project is a simple ASP.NET Core Web API for managing users. It supports CRUD operations and includes validation and custom middleware.

## Features

- Get all users
- Get user by ID
- Create user
- Update user
- Delete user
- Input validation
- Request logging middleware

## Endpoints

- GET /api/users
- GET /api/users/{id}
- POST /api/users
- PUT /api/users/{id}
- DELETE /api/users/{id}

## Validation

- Name is required
- Email is required and must be valid
- Age must be greater than 0

## Middleware

- Custom request logging middleware logs request method and path

## Copilot Usage

GitHub Copilot was used to help debug controller logic, improve validation handling, and fix middleware registration issues.

## Run the project

1. Clone the repository
2. Open in VS Code or Visual Studio
3. Run:
   ```
   dotnet restore
   dotnet run
   ```