using Prestamax.Api.Common.Middleware;
using Prestamax.Application;
using Prestamax.Infrastructure;
using Prestamax.Infrastructure.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Services
builder.Services.AddControllers();

builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration);

// OpenAPI
builder.Services.AddOpenApi();

var app = builder.Build();

// Check database connection
await app.Services.CheckDatabaseConnectionAsync();

// HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseMiddleware<ExceptionHandlingMiddleware>();
app.UseMiddleware<RequestLoggingMiddleware>();

app.UseAuthorization();

app.MapControllers();

app.Run();