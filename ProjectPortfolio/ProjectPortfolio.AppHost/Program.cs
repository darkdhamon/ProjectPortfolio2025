var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.WebAppRazor>("webapprazor");

builder.Build().Run();
