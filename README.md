Article:

# MyOnionApp

A clean, modular solution following the **Onion Architecture** pattern, built with ASP.NET Core. This structure separates concerns across layers to improve maintainability, testability, and scalability.

## 🧅 Architecture Overview

```
/Onion
├── Onion.Domain // Core business logic and entities (pure domain layer)
├── Onion.Application // Application services, interfaces, DTOs, business rules
├── Onion.Infrastructure // Implementations for data access, external services, etc.
└── Onion.Web // Web API layer (entry point)
```


### 🔁 Layer Responsibilities

| Layer              | Responsibility                                                                 |
|-------------------|----------------------------------------------------------------------------------|
| **Domain**         | Contains business entities, enums, value objects, and domain interfaces         |
| **Application**    | Coordinates business logic, use cases, and defines service contracts            |
| **Infrastructure** | Implements application and domain interfaces (e.g., repositories, file storage) |
| **Web**            | ASP.NET Core API that handles HTTP requests and delegates to application layer  |

---

## ✅ Features

- Clean separation of concerns
- Testable core logic (Domain + Application)
- Flexible infrastructure layer
- Follows Dependency Inversion and SOLID principles
- Ready for DI, unit testing, and expansion

---

## 🚀 Getting Started

### Prerequisites

- [.NET 7 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/7.0) or later
- IDE like Visual Studio or Rider


