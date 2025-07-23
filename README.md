# ProjectPortfolio2025

This repository contains a sample .NET project portfolio. The `Model` project defines entities that describe a person's professional profile, employment history, education and skills.

## Model overview

Portfolios are now associated with a `Person` so a single person can publish multiple portfolios.

`Person` contains contact information:

- `FirstName` and `LastName`
- `Location`
- `ContactEmail` and `Phone`

`Profile` represents an individual portfolio and references a `Person`. It includes:

- `Title` (professional headline for the portfolio)
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

## Local debugging

When running the solution from Visual Studio, start both the `WebAPI` and
`WebAppRazor` projects using their HTTPS profiles. The API listens on
`https://localhost:7130` while the web app runs on `https://localhost:7177`.
`WebAppRazor` reads the API endpoint from the `PortfolioApiBaseUrl`
configuration value, which is preconfigured in
`WebAppRazor/appsettings.Development.json` for local debugging.
