using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repositories;

namespace StoreApp.Infrastructure.Extensions
{
	public static class ApplicationExtension
	{
		public static void ConfigureAndCheckMigration(this IApplicationBuilder app)
		{
			RepositoryContext context = app
				.ApplicationServices
				.CreateScope()
				.ServiceProvider
				.GetRequiredService<RepositoryContext>();

			if(context.Database.GetPendingMigrations().Any())
			{
				//context.Database.Migrate();
			}
		}

		public static void ConfigureLocalization(this WebApplication app)
		{
			app.UseRequestLocalization(options =>
			{
				options.AddSupportedCultures("tr-TR")
				.AddSupportedCultures("tr-TR")
				.SetDefaultCulture("tr-TR");
			});
		}

		public static async void ConfigureDefaultAdminUser(this IApplicationBuilder app)
		{
			const string adminUser = "Admin";
			const string adminPassword = "Admin+123456";

			UserManager<IdentityUser> userManager = app
				.ApplicationServices
				.CreateScope()
				.ServiceProvider
				.GetRequiredService<UserManager<IdentityUser>>();

			RoleManager<IdentityRole> roleManager = app
				.ApplicationServices
				.CreateAsyncScope()
				.ServiceProvider
				.GetRequiredService<RoleManager<IdentityRole>>();

			IdentityUser user = await userManager.FindByNameAsync(adminUser);

			if (user is null)
			{
				user = new IdentityUser()
				{
					Email = "eren@gmail.com",
					PhoneNumber = "05123456789",
					UserName = adminUser
				};

				var result = await userManager.CreateAsync(user , adminPassword);

				if (!result.Succeeded)
					throw new Exception("Admin user couldn't created.");
				var roleResult = await userManager.AddToRoleAsync(user, Convert.ToString(roleManager.Roles.Select(r => r.Name).ToList()));

				if (!roleResult.Succeeded)
					throw new Exception("System have problems with role defination for admin.");
			}
		}
	}
}
