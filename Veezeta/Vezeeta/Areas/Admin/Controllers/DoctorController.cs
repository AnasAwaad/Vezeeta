using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Claims;
using Vezeeta.Entities.Interfaces;
using Vezeeta.Presentation.ViewModel;

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
                properties: "TimeSlots,Clinic,User",
                track: false,
                pageNumber: pageNumber,
                pageSize: pageSize);

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



            if (viewModel.ProfileImage is not null)
            {
                var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "Doctor");
                var fileName = Guid.NewGuid().ToString() + Path.GetExtension(viewModel.ProfileImage.FileName);
                var filePath = Path.Combine(uploadsFolder, fileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await viewModel.ProfileImage.CopyToAsync(fileStream);
                }

                doctor.ImagePath = Path.Combine("images", "Doctor", fileName);


            }
            else
            {
                doctor.ImagePath = Path.Combine("images", "Doctor", "doctor.svg");
            }


            var user = new ApplicationUser
            {
                UserName = viewModel.UserName,
                Email = viewModel.Email,
                PhoneNumber = viewModel.PhoneNumber,
                DoctorProfile = doctor
            };

            var res = await _userManager.CreateAsync(user, viewModel.Password!);

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
            var doctor = _unitOfWork.Doctors.Get(d => d.Id == id, properties: "User");

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
        public async Task<IActionResult> Update(DoctorFormViewModel viewModel)
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
            // Update Doctor Info

            var existingDoctor = _unitOfWork.Doctors.Get(d => d.Id == viewModel.Id, "User");


            if (viewModel.ProfileImage != null)
            {
                // Delete existing image if it exists
                if (!string.IsNullOrEmpty(existingDoctor.ImagePath))
                {
                    var oldImagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", existingDoctor.ImagePath);
                    if (System.IO.File.Exists(oldImagePath))
                        System.IO.File.Delete(oldImagePath);
                }

                // Save new image
                string fileName = Guid.NewGuid().ToString() + Path.GetExtension(viewModel.ProfileImage.FileName);
                string uploadPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/Doctor");

                if (!Directory.Exists(uploadPath))
                    Directory.CreateDirectory(uploadPath);

                var filePath = Path.Combine(uploadPath, fileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await viewModel.ProfileImage.CopyToAsync(stream);
                }

                // Save image path to database
                viewModel.ImagePath = Path.Combine("images", "Doctor", fileName);
            }
            else
            {
                viewModel.ImagePath = existingDoctor.ImagePath;
            }

            _mapper.Map(viewModel, existingDoctor);
            existingDoctor.LastUpdatedOn = DateTime.Now;


            _unitOfWork.Doctors.Update(existingDoctor);
            _unitOfWork.Save();


            // Update User Info
            var user = existingDoctor.User;
            if (user != null)
            {
                user.PhoneNumber = viewModel.PhoneNumber;
                user.UserName = viewModel.UserName;
                user.Email = viewModel.Email;

                var updateUserResult = await _userManager.UpdateAsync(user);
                if (!updateUserResult.Succeeded)
                {
                    foreach (var error in updateUserResult.Errors)
                        ModelState.AddModelError("", error.Description);

                    viewModel.ClinicList = _unitOfWork.Clinics.GetAll().Select(c => new SelectListItem
                    {
                        Text = c.Name,
                        Value = c.Id.ToString()
                    });

                    return View("Form", viewModel);
                }

                // Change Password if provided
                if (!string.IsNullOrWhiteSpace(viewModel.Password))
                {
                    var token = await _userManager.GeneratePasswordResetTokenAsync(user);
                    var passwordResult = await _userManager.ResetPasswordAsync(user, token, viewModel.Password);

                    if (!passwordResult.Succeeded)
                    {
                        foreach (var error in passwordResult.Errors)
                            ModelState.AddModelError("", error.Description);

                        viewModel.ClinicList = _unitOfWork.Clinics.GetAll().Select(c => new SelectListItem
                        {
                            Text = c.Name,
                            Value = c.Id.ToString()
                        });

                        return View("Form", viewModel);
                    }
                }
            }

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
