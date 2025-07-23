# ProjectPortfolio2025

This repository contains a sample .NET project portfolio. The `Model` project defines entities that describe a person's professional profile, employment history, education and skills.

## Profile model

The `Profile` class includes identity details useful for rendering a portfolio site:

- `FirstName` and `LastName`
- `Title` (professional headline)
- `Location`
- `ContactEmail` and `Phone`
- `SelfDescription` for a short biography
- Lists of employment records, education records, certifications and personal projects

Each project has been updated so that every class resides in its own file.

## Database migrations

The `Model` project includes an EF Core `DbContext` so you can generate a
database schema using code-first migrations. To add the initial migration run:

```bash
dotnet ef migrations add InitialCreate --project ProjectPortfolio/Model --startup-project ProjectPortfolio/ProjectPortfolio.AppHost
```

Migrations will be placed in the `Model` project and can be applied with
`dotnet ef database update`.
