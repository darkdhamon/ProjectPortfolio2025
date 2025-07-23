var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.WebAppRazor>("webapprazor");

builder.AddProject<Projects.WebAPI>("webapi");

builder.Build().Run();
