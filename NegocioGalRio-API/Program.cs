using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using NegocioGalRio_API.Contexts;
using NegocioGalRio_API.Controllers;
using NegocioGalRio_API.Repository;
using NegocioGalRio_API.Services;
using AutoMapper;
using NegocioGalRio_API.Models;
using NegocioGalRio_API.ViewModel;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        //coneccion a la vase de datos
        var connectionString = builder.Configuration.GetConnectionString("dbConection");
        builder.Services.AddDbContext<ConectionSQLServer>(options => options.UseSqlServer(connectionString));

        var mapper = ConfigureMapper();
        builder.Services.AddSingleton(mapper);
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
    }
    private static IMapper ConfigureMapper()
    {
        var mapperConfig = new MapperConfiguration(cfg =>
        {
            // Agrega aquí tus perfiles de AutoMapper
            cfg.AddProfile<MappingProfile>();
            // Agrega más perfiles si es necesario
        });

        return mapperConfig.CreateMapper();
    }
}
public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Rol, RolViewModel>(); // Define cómo mapear de Rol a RolViewModel
        CreateMap<RolViewModel, Rol>(); // Define cómo mapear de RolViewModel a Rol
    }
}