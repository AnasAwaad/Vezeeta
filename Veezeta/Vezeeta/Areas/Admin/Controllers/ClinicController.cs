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
		_unitOfWork.Clinics.Add(_mapper.Map<Clinic>(viewModel));

		_unitOfWork.Save();

		var clincVM = new ClinicFormViewModel
		{
			Location = viewModel.Location,
			Name = viewModel.Name
		};

		return PartialView("_ClinicRow", clincVM);
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
}
