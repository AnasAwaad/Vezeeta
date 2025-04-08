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
				FullName = "Admin",
				UserName = "Admin",
				Email = "Admin@gmail.com",
				EmailConfirmed = true,
			};

			var doctor = new ApplicationUser
			{
				FullName = "Doctor",
				UserName = "Doctor",
				Email = "Doctor@gmail.com",
				EmailConfirmed = true,
			};



			var adminUser = await userManager.FindByEmailAsync(admin.Email);
			var doctorUser = await userManager.FindByEmailAsync(doctor.Email);

			if (adminUser is null)
			{
				await userManager.CreateAsync(admin, "P@ssword123");
				await userManager.AddToRoleAsync(admin, AppRoles.Admin);
			}

			if (doctorUser is null)
			{
				await userManager.CreateAsync(doctor, "P@ssword123");
				await userManager.AddToRoleAsync(doctor, AppRoles.Doctor);
			}


		}
	}
}
