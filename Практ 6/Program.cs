using Domain.Interfaces;
using BusinessLogic.Services;
using Domain.Wrapper;
using Microsoft.EntityFrameworkCore;
using Domain.Models;
using DataAccess.Wrapper;
using DataAccess;

namespace WebAPI1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<WebShopContext>(options => options.UseSqlServer(connectionString: "Server=lab116-p;Database=Artem-WebShop;User Id=sa;Password=12345"));

            builder.Services.AddScoped<Domain.Wrapper.IRepositoryWrapper, RepositoryWrapper>();
            builder.Services.AddScoped<IUserService, UserService>();


            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

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