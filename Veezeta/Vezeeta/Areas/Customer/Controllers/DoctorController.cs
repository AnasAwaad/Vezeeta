using DataAccessLayer.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Model;
using Model.ViewModel;

namespace Vezeeta.Areas.Customer.Controllers
{
    [Area("Customer")]

    public class DoctorController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public DoctorController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            var timeSlots = _unitOfWork.TimeSlot
                           .GetAll(properties: "Doctor")
                           .ToList();

            return View(timeSlots);
        }
        public IActionResult Upsert(int? id)
        {

            DoctorVm doctorVM = new()
            {
                TimeList = _unitOfWork.TimeSlot.GetAll()
                    .Select(u => new SelectListItem 
                    {
                        Text = u.Date,
                        Value = u.Id.ToString()
                    }).ToList()
,
                Doctor = new Doctor()
            };
            if (id == null || id == 0)
            {
                return View(doctorVM);
            }
            else
            {
                doctorVM.Doctor = _unitOfWork.Doctor.Get(u => u.Id == id);
                if (!string.IsNullOrEmpty(doctorVM.Doctor.SelectedTimeSlots))
                {
                    doctorVM.SelectedTimeSlots = doctorVM.Doctor.SelectedTimeSlots
                        .Split(',')
                        .Select(int.Parse)
                        .ToList();
                }
                return View(doctorVM);
            }
        }
        [HttpPost]
        public IActionResult Upsert(DoctorVm obj, IFormFile? file)
        {
            if (obj.Doctor == null)
            {
                ModelState.AddModelError("", "Invalid doctor data.");
                return View(obj);
            }

            if (!ModelState.IsValid)
            {
                foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
                {
                    Console.WriteLine($"Validation Error: {error.ErrorMessage}");
                }
                return View(obj);
            }

            string wwwRootPath = _webHostEnvironment.WebRootPath;

            if (file != null)
            {
                string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                string productPath = Path.Combine(wwwRootPath, "images", "Doctor");

                if (!string.IsNullOrEmpty(obj.Doctor.ImageUrl))
                {
                    var oldImagePath = Path.Combine(wwwRootPath, obj.Doctor.ImageUrl.TrimStart('\\', '/'));

                    try
                    {
                        if (System.IO.File.Exists(oldImagePath))
                        {
                            System.IO.File.Delete(oldImagePath);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error deleting old file: {ex.Message}");
                    }
                }

                if (!Directory.Exists(productPath))
                {
                    Directory.CreateDirectory(productPath);
                }

                string filePath = Path.Combine(productPath, fileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }

                obj.Doctor.ImageUrl = "/images/Doctor/" + fileName;
            }

            if (obj.SelectedTimeSlots != null && obj.SelectedTimeSlots.Any())
            {
                obj.Doctor.SelectedTimeSlots = string.Join(",", obj.SelectedTimeSlots);
            }
            else
            {
                obj.Doctor.SelectedTimeSlots = "";
            }

            Console.WriteLine($"Doctor ID: {obj.Doctor.Id}");
            Console.WriteLine($"Doctor Name: {obj.Doctor.Name}");
            Console.WriteLine($"Doctor ImageUrl: {obj.Doctor.ImageUrl}");
            Console.WriteLine($"Doctor SelectedTimeSlots: {obj.Doctor.SelectedTimeSlots}");

            if (obj.Doctor.Id == 0)
            {
                _unitOfWork.Doctor.Add(obj.Doctor);
                TempData["success"] = "Doctor is created";
            }
            else
            {
                var existingDoctor = _unitOfWork.Doctor.Get(d => d.Id == obj.Doctor.Id);
                if (existingDoctor == null)
                {
                    Console.WriteLine("Doctor not found in the database! Adding instead.");
                    _unitOfWork.Doctor.Add(obj.Doctor);
                }
                else
                {
                    _unitOfWork.Doctor.Update(obj.Doctor);
                }
                TempData["success"] = "Doctor is updated";
            }

            _unitOfWork.Save(); 
            return RedirectToAction("Index", "Doctor");
        }






    }
}
