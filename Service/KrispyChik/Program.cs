using KrispyChik.Business_Contracts;
using KrispyChik.Business_Manager;
using KrispyChik.Data_Access;
using KrispyChik.Data_Contracts;
using KrispyChik.Entities;
using KrispyChik.Framework;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDependencies();
builder.Services.AddDbContext<UserDb>(options =>
    options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=KrispyChik;Integrated Security=True;"));

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
