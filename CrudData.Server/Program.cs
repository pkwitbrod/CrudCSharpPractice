using CrudData.Server.Accessors;
using CrudData.Server.Engines;
using CrudData.Server.Interfaces;
using CrudData.Server.Managers;
using Microsoft.EntityFrameworkCore;
using StoreTestData.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<CrudDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IWeatherAccessor, WeatherAccessor>();
builder.Services.AddTransient<IWeatherEngine, WeatherEngine>();
builder.Services.AddTransient<IWeatherManager, WeatherManager>();

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();
