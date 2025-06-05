
using CovadisLeenAuto.Application.Interfaces;
using CovadisLeenAuto.Application.Repositories;
using CovadisLeenAuto.Application.Services;
using CovadisLeenAuto.Domain;

namespace CovadisLeenAuto.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            ServicesConfiguration.RegisterServices(builder.Services, builder.Configuration.GetConnectionString("DefaultConnection"));

            builder.Services.AddScoped<ILeenAutoService, LeenAutoService>();

            builder.Services.AddScoped<ILeenAutoRepository, LeenAutoRepository>();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("StaAlleAanvragenToe",
                    builder => builder
                        .AllowAnyOrigin()
                        .AllowAnyHeader()
                        .AllowAnyMethod());
            });

            //AddScoped< Hier moet nog repository >

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseCors("StaAlleAanvragenToe");

            app.MapControllers();

            app.Run();
        }
    }
}
