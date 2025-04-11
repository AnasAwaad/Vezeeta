using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Vezeeta.Entities.Interfaces;
using Vezeeta.Presentation.ViewModel.Clinic;

namespace Vezeeta.Presentation.Areas.Admin.Controllers;

[Area(AppRoles.Admin)]
[Authorize(Roles = AppRoles.Admin)]
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

		var viewModel = _mapper.Map<IEnumerable<ClinicFormViewModel>>(clinics);

		return View(viewModel);
	}


	public IActionResult Create()
	{
		return PartialView("_Form");
	}

	[HttpPost]
	//[ValidateAntiForgeryToken]
	public IActionResult Create(ClinicFormViewModel viewModel)
	{
		if (!ModelState.IsValid)
		{
			return BadRequest();
		}

		var clinic = _mapper.Map<Clinic>(viewModel);
		_unitOfWork.Clinics.Add(clinic);

		_unitOfWork.Save();

		return PartialView("_ClinicRow", _mapper.Map<ClinicFormViewModel>(clinic));
	}


	public IActionResult Update(int id)
	{
		var clinic = _unitOfWork.Clinics.GetById(id);
		return PartialView("_Form", _mapper.Map<ClinicFormViewModel>(clinic));
	}

	[HttpPost]
	//[ValidateAntiForgeryToken]
	public IActionResult Update(ClinicFormViewModel viewModel)
	{
		if (!ModelState.IsValid)
		{
			return BadRequest();
		}

		var clinic = _mapper.Map<Clinic>(viewModel);
		clinic.LastUpdatedOn = DateTime.Now;

		_unitOfWork.Clinics.Update(clinic);

		_unitOfWork.Save();


		return PartialView("_ClinicRow", _mapper.Map<ClinicFormViewModel>(clinic));
	}

	[HttpPost]
	public IActionResult ToggleStatus(int id)
	{
		var clinic = _unitOfWork.Clinics.GetById(id);
		if (clinic is null)
			return NotFound();
		clinic.IsDeleted = !clinic.IsDeleted;
		clinic.LastUpdatedOn = DateTime.Now;

		_unitOfWork.Save();

		return PartialView("_ClinicRow", _mapper.Map<ClinicFormViewModel>(clinic));
	}
}
