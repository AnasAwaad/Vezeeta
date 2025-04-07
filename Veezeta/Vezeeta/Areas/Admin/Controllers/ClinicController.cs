using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Vezeeta.Entities.Interfaces;
using Vezeeta.Entities.Models;
using Vezeeta.Entities.ViewModel.Clinic;

namespace Vezeeta.Presentation.Areas.Admin.Controllers;
[Area("Admin")]
public class ClinicController : Controller
{
	private readonly IUnitOfWork _unitOfWork;
	private readonly IMapper _mapper;

	public ClinicController(IUnitOfWork unitOfWork, IMapper mapper)
	{
		_unitOfWork = unitOfWork;
		_mapper = mapper;
	}

	public IActionResult Index()
	{
		var clinics = _unitOfWork.Clinics.GetAll();

		var viewModel = _mapper.Map<IEnumerable<ClinicViewModel>>(clinics);

		return View(viewModel);
	}


	public IActionResult Create()
	{
		return PartialView("_Form");
	}

	[HttpPost]
	//[ValidateAntiForgeryToken]
	public IActionResult Create([FromForm] ClinicFormViewModel viewModel)
	{
		if (!ModelState.IsValid)
		{
			return View("_Form", viewModel);
		}
		_unitOfWork.Clinics.Add(_mapper.Map<Clinic>(viewModel));

		_unitOfWork.Save();

		var clincVM = new ClinicViewModel
		{
			Location = viewModel.Location,
			Name = viewModel.Name
		};

		return Ok();
	}
}
