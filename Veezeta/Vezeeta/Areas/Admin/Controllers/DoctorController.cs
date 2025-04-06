using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Vezeeta.Entities.Interfaces;
using Vezeeta.Entities.Models;
using Vezeeta.Entities.ViewModel;

namespace Vezeeta.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class DoctorController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IMapper _mapper;

        public DoctorController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
            _mapper = mapper;
        }
        public IActionResult Index()
        {

            var doctors = _unitOfWork.Doctors.GetAll(properties: "TimeSlots,Clinic");

            var mappedDoctors = _mapper.Map<IEnumerable<DoctorViewModel>>(doctors).ToList();

            return View(mappedDoctors);
        }


        public IActionResult Create()
        {
            var clinics = _unitOfWork.Clinics.GetAll().Select(c => new SelectListItem
            {
                Text = c.Name,
                Value = c.Id.ToString()
            });

            var doctorViewModel = new DoctorFormViewModel
            {
                ClinicList = clinics
            };

            return View(doctorViewModel);
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Create(DoctorFormViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                var clinics = _unitOfWork.Clinics.GetAll().Select(c => new SelectListItem
                {
                    Text = c.Name,
                    Value = c.Id.ToString()
                });

                viewModel.ClinicList = clinics;

                return View(viewModel);
            }

            _unitOfWork.Doctors.Add(_mapper.Map<Doctor>(viewModel));

            _unitOfWork.Save();

            return RedirectToAction(nameof(Index));
        }


        public IActionResult Update(int id)
        {
            var doctor = _unitOfWork.Doctors.GetById(id);

            if (doctor is null)
                return NotFound();

            var clinics = _unitOfWork.Clinics.GetAll().Select(c => new SelectListItem
            {
                Text = c.Name,
                Value = c.Id.ToString()
            });

            var doctorViewModel = _mapper.Map<DoctorFormViewModel>(doctor);
            doctorViewModel.ClinicList = clinics;

            return View("Create", doctorViewModel);
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Update(DoctorFormViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                var clinics = _unitOfWork.Clinics.GetAll().Select(c => new SelectListItem
                {
                    Text = c.Name,
                    Value = c.Id.ToString()
                });

                viewModel.ClinicList = clinics;

                return View(viewModel);
            }

            _unitOfWork.Doctors.Update(_mapper.Map<Doctor>(viewModel));

            _unitOfWork.Save();

            return RedirectToAction(nameof(Index));
        }



    }
}
