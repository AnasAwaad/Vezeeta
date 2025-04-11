using Microsoft.AspNetCore.Identity;
using Vezeeta.Entities.Constants;
using Vezeeta.Entities.Models;

namespace Vezeeta.DAL.Seeds;
public static class DefaultUsers
{
	public static async Task SeedUsers(UserManager<ApplicationUser> userManager)
	{
		if (!userManager.Users.Any())
		{
			var admin = new ApplicationUser
			{
				UserName = "Admin",
				Email = "Admin@gmail.com",
				EmailConfirmed = true,
			};




			var adminUser = await userManager.FindByEmailAsync(admin.Email);

			if (adminUser is null)
			{
				await userManager.CreateAsync(admin, "P@ssword123");
				await userManager.AddToRoleAsync(admin, AppRoles.Admin);
			}

		}
	}
}
