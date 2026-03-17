# MyBackendApi
.NET 10 Backend Service using Clean Architecture. Linked to the angular-dashboard project

1. Project Structure
MyBackendApi/
├── src/
│   ├── MyBackendApi.Domain/          ← Pure domain: no framework deps
│   │   ├── Common/                   BaseEntity, BaseAuditableEntity, BaseEvent
│   │   ├── Entities/                 (domain entities go here)
│   │   ├── Enums/
│   │   ├── Exceptions/               DomainException
│   │   ├── Interfaces/Repositories/  IGenericRepository<T>
│   │   └── ValueObjects/
│   ├── MyBackendApi.Application/     ← Use cases, CQRS, DTOs
│   │   ├── Common/Behaviors/         LoggingBehavior, ValidationBehavior (MediatR pipeline)
│   │   ├── Common/Exceptions/        NotFoundException, ValidationException
│   │   ├── Common/Interfaces/        IApplicationDbContext, ICurrentUserService, IUnitOfWork
│   │   ├── Common/Mappings/          IMapFrom<T>, MappingProfile (AutoMapper)
│   │   ├── DTOs/                     (DTOs go here)
│   │   ├── Features/                 (CQRS commands/queries organized by feature)
│   │   └── DependencyInjection.cs
│   ├── MyBackendApi.Infrastructure/  ← EF Core, external services
│   │   ├── Persistence/Context/      ApplicationDbContext
│   │   ├── Persistence/Repositories/ GenericRepository<T>
│   │   ├── Persistence/Configurations/  (IEntityTypeConfiguration<T> files)
│   │   ├── Persistence/Migrations/
│   │   ├── Services/
│   │   └── DependencyInjection.cs
│   └── MyBackendApi.API/             ← Entry point, controllers, middleware
│       ├── Controllers/
│       ├── Middleware/               ExceptionHandlingMiddleware
│       ├── Filters/
│       ├── Extensions/               ServiceExtensions (CORS helper)
│       └── Program.cs
└── tests/
    ├── MyBackendApi.Domain.Tests/
    ├── MyBackendApi.Application.Tests/
    └── MyBackendApi.Infrastructure.Tests/