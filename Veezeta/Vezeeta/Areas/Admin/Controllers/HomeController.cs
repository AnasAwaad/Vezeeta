using Microsoft.AspNetCore.Mvc;

namespace Vezeeta.Presentation.Areas.Admin.Controllers;

[Area("Admin")]
public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
