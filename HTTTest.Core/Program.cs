using System.Text.Json.Serialization;
using AutoMapper;
using HTTTest.Core.Configuration;
using HTTTest.Core.Interfaces;
using HTTTest.Core.Services;
using HTTTest.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
    .AddJsonOptions(options => options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles );

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Регистрация сервисов и контекста бд
builder.Services.AddScoped<IItemService, ItemService>();
builder.Services.AddScoped<IRepository, RepositoryService>();
builder.Services.AddSingleton<Mapper>(provider => AutoMapperConfiguration.CreateMapper());
builder.Services.AddDbContext<LocalDataBaseContext>(
    options => options.UseNpgsql(builder.Configuration.GetConnectionString("LocalDatabase")));

var app = builder.Build();

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