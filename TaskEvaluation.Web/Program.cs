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

			// identity configuration 
			builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
				.AddCookie(CookieAuthenticationDefaults.AuthenticationScheme,
				options =>
				{
					options.LoginPath = new PathString("/Account/Login");
					options.AccessDeniedPath = new PathString("/Account/Login");
				});

			builder.Services.AddIdentityCore<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
				.AddEntityFrameworkStores<ApplicationDbContext>()
				.AddTokenProvider<DataProtectorTokenProvider<IdentityUser>>(TokenOptions.DefaultProvider);

			// Password configuration 
			builder.Services.AddIdentity<IdentityUser, IdentityRole>(options =>
			{
				// Default Password settings.
				options.Password.RequireDigit = true;
				options.Password.RequireLowercase = true;
				options.Password.RequireNonAlphanumeric = true;
				options.Password.RequireUppercase = true;
				options.Password.RequiredLength = 6;
				options.Password.RequiredUniqueChars = 0;

			}).AddEntityFrameworkStores<ApplicationDbContext>();

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

			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Account}/{action=Login}/{id?}");

			app.Run();
		}
	}
}