# EduFlow LMS Showcase

> ASP.NET Core LMS portfolio snapshot - clean architecture, Identity auth, EF Core, SQLite, SignalR notifications, dashboards, and xUnit tests.

![status](https://img.shields.io/badge/status-portfolio_snapshot-5cf2c1?labelColor=0a0e14)
![source](https://img.shields.io/badge/source-private-red?labelColor=0a0e14)
![stack](https://img.shields.io/badge/stack-ASP.NET_Core-5cf2c1?labelColor=0a0e14)
![database](https://img.shields.io/badge/database-SQLite_|_EF_Core-5cf2c1?labelColor=0a0e14)

This repository is a public showcase for my academic LMS project. The full application source code is intentionally not published here. The repo contains documentation, architecture notes, diagrams, and small illustrative snippets so the project can be reviewed without exposing the complete implementation.

## What this is

EduFlow is an e-learning platform built with ASP.NET Core MVC and a layered architecture:

- Public catalog and lesson preview pages.
- Authentication and role-based dashboards for admin, trainer, and learner flows.
- Course, lesson, theme, payment, enrollment, and progression management.
- Recommendation logic, video progress tracking, notifications, and analytics.
- EF Core persistence with seeded demo data and xUnit coverage for core services.

## Architecture

```text
EduFlow.Web
  MVC controllers, Razor views, SignalR hub, middleware

EduFlow.Application
  DTOs, service interfaces, use-case services, validators

EduFlow.Domain
  Course, lesson, user, enrollment, payment and progression models

EduFlow.Infrastructure
  EF Core DbContext, repositories, data seeding, email/log services

EduFlow.Tests
  Unit and integration-style tests around service behavior
```

## Public Snapshot

| Path | Purpose |
|---|---|
| `screenshots/aspnet-identity-mindmap.png` | ASP.NET MVC + Identity study map |
| `code-snippets/eduflow-service-pattern.cs` | Short illustrative service pattern |

## Screenshots / Diagrams

| ASP.NET MVC + Identity Mind Map |
|:--:|
| ![ASP.NET Identity mind map](screenshots/aspnet-identity-mindmap.png) |

## What is private

The complete `.cs`, `.cshtml`, `.slnx`, migration, configuration, database, and build output files are kept private. This avoids publishing the full academic source while still documenting the architecture and learning outcomes.

## Lessons Learned

1. Keep business rules out of controllers. The project became easier to test once workflows lived in application services.
2. Identity is more than login pages. Roles, lockout, password policy, seeded accounts, and authorization filters need to be designed together.
3. A useful LMS is stateful. Progression, enrollments, payment status, and notifications all need consistent persistence rules.
4. Tests are cheaper at the service boundary. xUnit tests on service results caught mistakes faster than browser-only testing.

## License

Portfolio snapshot only - see [LICENSE](LICENSE). Full source code remains private.

## About Me

I am **Yassir Zahidi**, a Computer Engineering student focused on cybersecurity, backend engineering, and practical academic projects.

- Portfolio: <https://y-zahidi.github.io>
- GitHub: <https://github.com/y-zahidi>

