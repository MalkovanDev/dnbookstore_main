using Domain.Ports;
using Infrastructure.Adapters;
using Infrastructure.Dapper;
using Infrastructure.Databases.dnBookstore;
using Infrastructure.Databases.Interfaces;
using Infrastructure.Repositories;
using Infrastructure.Repositories.Interfaces;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

public class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        ConfigureServices(builder.Services);

        //builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseSwagger();
        app.UseSwaggerUI();

        app.UseHttpsRedirection();

        app.MapControllers();

        app.Run();
    }

    private static void ConfigureServices(IServiceCollection services)
    {
        //Swagger
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        //Infrastructure
        services.AddScoped<IDapperWrapper, DapperWrapper>();

        services.AddSingleton<IDatabaseContext, DnBookstoreDatabaseContext>();
        services.AddScoped<IBookRepository, BookRepository>();

        services.AddScoped<IBookService, BookService>();

        //Api Controllers
        services.AddControllers();
    }
}