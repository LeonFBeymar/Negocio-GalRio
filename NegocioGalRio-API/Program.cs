using Microsoft.EntityFrameworkCore;
using NegocioGalRio_API.Contexts;
using NegocioGalRio_API.Controllers;
using NegocioGalRio_API.Repository;
using NegocioGalRio_API.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//coneccion a la vase de datos
var connectionString = builder.Configuration.GetConnectionString("dbConection");
builder.Services.AddDbContext<ConectionSQLServer>(options => options.UseSqlServer(connectionString));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();  

//Registro de servicios y repositorios
builder.Services.AddScoped<RolRepository>();
builder.Services.AddScoped<RolService>();

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
