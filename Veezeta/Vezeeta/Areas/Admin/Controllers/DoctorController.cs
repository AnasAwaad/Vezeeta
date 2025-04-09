using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Claims;
using Vezeeta.Entities.Interfaces;
using Vezeeta.Entities.ViewModel;

namespace Vezeeta.Areas.Admin.Controllers
{
    [Area(AppRoles.Admin)]
    [Authorize(Roles = AppRoles.Admin)]

    public class DoctorController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IMapper _mapper;

        public DoctorController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment, IMapper mapper, UserManager<ApplicationUser> userManager)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
            _mapper = mapper;
            _userManager = userManager;
        }
        public IActionResult Index(int pageNumber = 1, int pageSize = 10)
        {

            var doctors = _unitOfWork.Doctors.GetAll(
                filter: d => !d.IsDeleted,
                properties: "TimeSlots,Clinic,User",
                track: false,
                pageNumber = pageNumber,
                pageSize = pageSize);

            var totalCount = _unitOfWork.Doctors.CountAll();
            var mappedDoctors = _mapper.Map<IEnumerable<DoctorViewModel>>(doctors).ToList();


            ViewBag.CurrentPage = pageNumber;
            ViewBag.TotalPages = (int)Math.Ceiling((double)totalCount / pageSize);

            return View(mappedDoctors);
        }


        public IActionResult Create()
        {
            var clinics = _unitOfWork.Clinics.GetAll(track: false).Select(c => new SelectListItem
            {
                Text = c.Name,
                Value = c.Id.ToString()
            });

            var doctorViewModel = new DoctorFormViewModel
            {
                ClinicList = clinics
            };

            return View("Form", doctorViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(DoctorFormViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                var clinics = _unitOfWork.Clinics.GetAll().Select(c => new SelectListItem
                {
                    Text = c.Name,
                    Value = c.Id.ToString()
                });

                viewModel.ClinicList = clinics;

                return View("Form", viewModel);
            }
            var doctor = _mapper.Map<Doctor>(viewModel);
            doctor.CeatedById = User.FindFirst(ClaimTypes.NameIdentifier)!.Value;


            var user = new ApplicationUser
            {
                FullName = viewModel.FullName,
                UserName = viewModel.UserName,
                Email = viewModel.Email,
                DoctorProfile = doctor
            };

            var res = await _userManager.CreateAsync(user, viewModel.Password);

            if (!res.Succeeded)
            {
                foreach (var error in res.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                return View("Form", viewModel);
            }

            await _userManager.AddToRoleAsync(user, AppRoles.Doctor);

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


            return View("Form", doctorViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
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

                return View("Form", viewModel);
            }

            var doctor = _mapper.Map<Doctor>(viewModel);
            doctor.LastUpdatedOn = DateTime.Now;

            _unitOfWork.Doctors.Update(doctor);
            _unitOfWork.Save();

            return RedirectToAction(nameof(Index));
        }


        public IActionResult Details(int id)
        {
            var doctor = _unitOfWork.Doctors.GetById(id);
            if (doctor == null)
                return NotFound();

            return View(_mapper.Map<DoctorViewModel>(doctor));
        }


        [HttpPost]
        public IActionResult Delete(int id)
        {
            var doctor = _unitOfWork.Doctors.GetById(id);
            if (doctor is null)
                return NotFound();

            doctor.IsDeleted = true;


            _unitOfWork.Save();

            return Ok();
        }


    }
}
