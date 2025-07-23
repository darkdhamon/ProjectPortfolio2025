var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

var apiBaseUrl = builder.Configuration.GetValue<string>("PortfolioApiBaseUrl");

builder.Services.AddHttpClient<WebAppRazor.Services.PortfolioApiClient>(client =>
{
    var baseAddress = string.IsNullOrEmpty(apiBaseUrl) ? "http://webapi" : apiBaseUrl;
    client.BaseAddress = new Uri(baseAddress);
});

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

app.MapDefaultEndpoints();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
