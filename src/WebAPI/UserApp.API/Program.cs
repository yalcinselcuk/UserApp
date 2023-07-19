using Microsoft.Extensions.Configuration;
using System;
using UserApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("db");
builder.Services.AddDbContext<UserDbContext>(option => option.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();//migration'da oluşabilecek hataları döndürür

builder.Services.AddCors(opt =>
{
    opt.AddPolicy("allow", builder =>//allow = her şeye izin ver
    {
        builder.AllowAnyHeader();//her request header'a izin ver
        builder.AllowAnyMethod();
        builder.AllowAnyOrigin();//http ile https farklı origin'ler.bunlara izin ver dedik
    });
});

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
