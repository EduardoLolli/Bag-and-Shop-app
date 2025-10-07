using Microsoft.EntityFrameworkCore;
using Bag_and_Shop_app.Infraestructure.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddEntityFrameworkSqlServer().AddDbContext<BagAndShopDBContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DataBase"))
    );

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
