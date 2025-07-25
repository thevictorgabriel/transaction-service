using Application.Services;
using Infrastructure.Repositories;
using Domain.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Mongo Connection String via appsettings
var mongoConn = builder.Configuration.GetConnectionString("MongoDb");

// DI
builder.Services.AddSingleton<ITransactionRepository>(new MongoTransactionRepository(mongoConn));
builder.Services.AddScoped<TransactionService>();

builder.Services.AddControllers();
var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

app.MapControllers();
app.Run();

app.UseDefaultFiles(); // procura por index.html
app.UseStaticFiles();  // serve wwwroot
