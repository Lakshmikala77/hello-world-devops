var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.MapGet("/", () =>
{
    return "Hello World from .NET running in Docker and Kubernetes!";
});

app.MapGet("/health", () =>
{
    return Results.Ok("Healthy");
});

app.Run();