using Microsoft.EntityFrameworkCore;
using RESTful_Web_API.Data;
using RESTful_Web_API.Models;
using RESTful_Web_API.Services;

namespace RESTful_Web_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<Context>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("Connection"));
            });

            builder.Services.AddScoped<IPersonRepository<Person>, PersonRepository>();
            builder.Services.AddScoped<IHobby<Hobby>, HobbyRepository>();
            builder.Services.AddScoped<IWebApi<PersonHobby>, PersonHobbyRepository>();

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
    }
}