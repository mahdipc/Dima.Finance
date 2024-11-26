# Dima.Finance - Enterprise Financial Management System

## Overview
Dima.Finance is a robust, enterprise-grade financial management system built with .NET 8, following Clean Architecture, Domain-Driven Design (DDD), and SOLID principles. 
The system provides comprehensive functionality for account management, customer relations, transaction processing, and loan management.

## Table of Contents
- [Technology Stack](#technology-stack)
- [Architecture](#architecture)
- [Project Structure](#project-structure)
- [Getting Started](#getting-started)
- [Configuration](#configuration)
- [API Documentation](#api-documentation)
- [Development](#development)
- [Testing](#testing)
- [Deployment](#deployment)
- [Contributing](#contributing)

## Technology Stack
- **.NET 7**: Core framework
- **Entity Framework Core**: ORM and database operations
- **SQL Server**: Primary database
- **Redis**: Distributed caching
- **MediatR**: CQRS and messaging
- **FluentValidation**: Request validation
- **Swagger/OpenAPI**: API documentation
- **IdentityServer4**: Authentication and authorization
- **Serilog**: Logging
- **xUnit**: Testing framework

## Architecture
The solution follows Clean Architecture principles with four main layers:

### Domain Layer (Core)
- Business entities
- Value objects
- Domain events
- Business rules and logic
- Repository interfaces

### Application Layer
- Use cases (Commands/Queries)
- DTOs
- Interfaces
- Validation rules
- Business services

### Infrastructure Layer
- Database context
- Repository implementations
- External service integrations
- Caching implementation
- Identity services

### API Layer
- REST API endpoints
- Controllers
- Middleware
- API models
- Documentation

## Project Structure
```
Dima.Finance/
├── src/
│   ├── Core/
│   │   ├── Dima.Finance.Domain/
│   │   └── Dima.Finance.Application/
│   ├── Infrastructure/
│   │   ├── Dima.Finance.Infrastructure/
│   │   ├── Dima.Finance.Persistence/
│   │   └── Dima.Finance.Identity/
│   ├── Presentation/
│   │   ├── Dima.Finance.Api/
│   │   └── Dima.Finance.Admin/
│   └── Shared/
│       └── Dima.Finance.Shared/
├── tests/
│   ├── Dima.Finance.UnitTests/
│   ├── Dima.Finance.IntegrationTests/
│   └── Dima.Finance.FunctionalTests/
└── tools/
    └── Dima.Finance.DbMigrator/
```

## Getting Started

### Prerequisites
- .NET 8 SDK
- SQL Server 2019+
- Redis 6+
- Visual Studio 2022 / VS Code
- Docker (optional)

### Installation

1. Clone the repository:
```bash
git clone https://github.com/your-username/dima-finance.git
cd dima-finance
```

2. Update database connection strings in `appsettings.json`:
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=.;Database=DimaFinance;Trusted_Connection=True;MultipleActiveResultSets=true",
    "RedisConnection": "localhost:6379"
  }
}
```

3. Apply database migrations:
```bash
dotnet ef database update --project src/Infrastructure/Dima.Finance.Persistence --startup-project src/Presentation/Dima.Finance.Api
```

4. Run the application:
```bash
dotnet run --project src/Presentation/Dima.Finance.Api
```

### Docker Support
```bash
docker-compose up -d
```

## Configuration

### Application Settings
Key configuration options in `appsettings.json`:

```json
{
  "UseInMemoryDatabase": false,
  "ConnectionStrings": {
    "DefaultConnection": "",
    "RedisConnection": ""
  },
  "Jwt": {
    "Issuer": "dima-finance",
    "Audience": "dima-finance-api",
    "Key": "your-secret-key-here",
    "ExpiryInDays": 7
  },
  "Serilog": {
    "MinimumLevel": "Information",
    "WriteTo": ["Console", "File"]
  }
}
```

## API Documentation

### Available Endpoints

#### Accounts
- `GET /api/v1/accounts` - Get all accounts (paginated)
- `GET /api/v1/accounts/{id}` - Get account by ID
- `POST /api/v1/accounts` - Create new account
- `PUT /api/v1/accounts/{id}` - Update account
- `POST /api/v1/accounts/{id}/deposit` - Deposit funds
- `POST /api/v1/accounts/{id}/withdraw` - Withdraw funds

#### Customers
- `GET /api/v1/customers` - Get all customers (paginated)
- `GET /api/v1/customers/{id}` - Get customer by ID
- `POST /api/v1/customers` - Create new customer
- `PUT /api/v1/customers/{id}` - Update customer

#### Loans
- `POST /api/v1/loans/apply` - Submit loan application
- `GET /api/v1/loans/{id}` - Get loan application status
- `PUT /api/v1/loans/{id}/approve` - Approve loan application
- `PUT /api/v1/loans/{id}/reject` - Reject loan application

## Development

### Adding New Features
1. Create domain entities in Domain layer
2. Define interfaces in Application layer
3. Implement business logic
4. Create API endpoints
5. Add tests

### Coding Standards
- Follow Microsoft's C# coding conventions
- Use async/await for asynchronous operations
- Implement proper exception handling
- Add XML documentation for public APIs
- Write unit tests for business logic

## Testing

### Running Tests
```bash
# Run all tests
dotnet test

# Run specific test project
dotnet test tests/Dima.Finance.UnitTests

# Run with coverage
dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=opencover
```

## Deployment

### Production Checklist
- Update connection strings
- Configure proper logging
- Set up monitoring
- Configure CORS policies
- Enable HTTPS
- Set up CI/CD pipeline
- Configure health checks

### Environment Variables
```
ASPNETCORE_ENVIRONMENT=Production
ConnectionStrings__DefaultConnection=<production-db-connection>
ConnectionStrings__RedisConnection=<redis-connection>
Jwt__Key=<your-secret-key>