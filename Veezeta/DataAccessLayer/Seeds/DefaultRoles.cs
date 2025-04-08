using Microsoft.AspNetCore.Identity;
using Vezeeta.Entities.Constants;

namespace Vezeeta.DAL.Seeds;
public static class DefaultRoles
{
	public static async Task SeedRoles(RoleManager<IdentityRole> roleManager)
	{
		if (!roleManager.Roles.Any())
		{
			await roleManager.CreateAsync(new IdentityRole(AppRoles.Admin));
			await roleManager.CreateAsync(new IdentityRole(AppRoles.Doctor));
			await roleManager.CreateAsync(new IdentityRole(AppRoles.Customer));
		}
	}
}
