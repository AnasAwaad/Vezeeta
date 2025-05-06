using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Vezeeta.Entities.Interfaces;
using Vezeeta.Presentation.ViewModel;

namespace Vezeeta.Areas.Customer.Controllers
{

	[Area("Customer")]
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly IUnitOfWork _unitOfWork;


		public HomeController(IUnitOfWork unitOfWork, ILogger<HomeController> logger)
		{
			_logger = logger;
			_unitOfWork = unitOfWork;

		}

		public IActionResult Index(string? search)
		{
			IEnumerable<Doctor> doctors;

			if (!string.IsNullOrEmpty(search))
			{
                doctors = _unitOfWork.Doctors.GetAll(d => d.Specialized.Contains(search) || d.FirstName.Contains(search) || d.LastName.Contains(search), properties: "User");
            }
			else
			{
				doctors = _unitOfWork.Doctors.GetAll(properties: "User");
			}

			return View(doctors);
		}

		public IActionResult Details(int id)
		{
			var times = _unitOfWork.Doctors.GetById(id);
			return View(times);

		}



		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
