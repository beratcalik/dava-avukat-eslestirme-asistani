using dotnet_store.Models;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
        builder.Services.AddOpenApi();

        builder.Services.AddDbContext<DataContext>(options =>
        {
            string? connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
            options.UseSqlServer(connectionString);




        });

var App = builder.Build();

        // Configure the HTTP request pipeline.
        if (App.Environment.IsDevelopment())
        {
            App.MapOpenApi();
        }

        App.UseHttpsRedirection();

        App.UseAuthorization();

        App.MapControllers();

        App.Run();
    }
}