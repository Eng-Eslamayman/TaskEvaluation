using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Text.RegularExpressions;
using TaskEvaluation.Infrastructure.Data;
using TaskEvaluation.Core.Entities.Business;
using TaskEvaluation.Core.Validators;
using TaskEvaluation.Core.Interfaces.IRepositories;
using TaskEvaluation.Infrastructure.Repositoies;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using TaskEvaluation.Infrastructure.Seeds;

namespace TaskEvaluation.Web
{
	public class Program
	{
		public static async Task Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			builder.Services.AddControllersWithViews();

			builder.Services.AddDbContext<ApplicationDbContext>(option =>
			option.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionString")));

			builder.Services.AddFluentValidationServices();
			builder.Services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));

			// identity configuration 
			builder.Services.AddIdentity<IdentityUser, IdentityRole>()
				.AddEntityFrameworkStores<ApplicationDbContext>()
				.AddDefaultTokenProviders()
				.AddSignInManager<SignInManager<IdentityUser>>();
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
			app.UseAuthentication();

			app.UseAuthorization();

			var scopeFactory = app.Services.GetRequiredService<IServiceScopeFactory>();

			using var scope = scopeFactory.CreateScope();

			var roleManger = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
			var userManger = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();

			await DefaultRoles.SeedAsync(roleManger);

			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Account}/{action=Login}/{id?}");

			app.Run();
		}
	}
}