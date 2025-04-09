using Microsoft.AspNetCore.Mvc;

namespace Vezeeta.Presentation.Areas.Admin.Controllers;

[Area(AppRoles.Admin)]
[Authorize(Roles = AppRoles.Admin)]

public class HomeController : Controller
{
	public IActionResult Index()
	{
		return View();
	}
}
