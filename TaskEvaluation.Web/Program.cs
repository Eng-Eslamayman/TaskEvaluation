using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Text.RegularExpressions;
using TaskEvaluation.Infrastructure.Data;
using TaskEvaluation.Core.Entities.Business;
using TaskEvaluation.Core.Validators;
using TaskEvaluation.Core.Interfaces.IRepositories;
using TaskEvaluation.Infrastructure.Repositoies;

namespace TaskEvaluation.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<ApplicationDbContext>(option =>
            option.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionString")));

            builder.Services.AddFluentValidationServices();
            builder.Services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
          

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}