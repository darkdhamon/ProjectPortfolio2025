using Microsoft.EntityFrameworkCore;
using Model;
using Model.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

// Add services to the container.
builder.Services.AddDbContext<Model.PortfolioContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection") ?? "Data Source=portfolio.db"));
builder.Services.AddRepositories();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// apply database migrations and seed test data on startup
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<PortfolioContext>();
    db.Database.Migrate();

    if (!db.Persons.Any())
    {
        var person = new Model.Entity.Person
        {
            FirstName = "John",
            LastName = "Doe",
            Location = "Unknown",
            ContactEmail = "john@example.com",
            Phone = "123-456-7890"
        };

        var profile = new Model.Entity.Profile
        {
            Person = person,
            Title = "Developer",
            SelfDescription = "Sample portfolio"
        };

        db.Persons.Add(person);
        db.Profiles.Add(profile);
        db.SaveChanges();
    }
}

app.MapDefaultEndpoints();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
