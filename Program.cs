
using Fifth_API_Project.DatabaseConnection;
using Fifth_API_Project.Repository.Implemetation;
using Fifth_API_Project.Repository.Service;
using Microsoft.EntityFrameworkCore;

namespace Fifth_API_Project
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
            builder.Services.AddDbContext<EmployeeRecords>(option =>
            {
                option.UseSqlServer(builder.Configuration.GetConnectionString("DbConnection"));
            });
            builder.Services.AddScoped<IEmployee,EmployeeService>();

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
