using Microsoft.AspNetCore.Mvc;
using Vezeeta.Entities.Interfaces;
using Vezeeta.Entities.Models;

namespace Vezeeta.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class ClinicController : Controller
    {

        private readonly IUnitOfWork _unitOfWork;
        public ClinicController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            var clinics = _unitOfWork.Clinics.GetAll().ToList();

            return View(clinics);
        }
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(Clinic obj)
        {


            if (ModelState.IsValid)
            {
                _unitOfWork.Clinics.Add(obj);
                _unitOfWork.Save();
                TempData["success"] = "Clinic is created";
                return RedirectToAction("Index", "Clinic");
            }
            return View();
        }
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Clinic? ClinicFromDb = _unitOfWork.Clinics.Get(u => u.Id == id);

            if (ClinicFromDb == null)
            {
                return NotFound();
            }

            return View(ClinicFromDb);
        }
        [HttpPost]
        public IActionResult Edit(Clinic obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Clinics.Update(obj);
                _unitOfWork.Save();
                TempData["success"] = "Clinic is Updated";

                return RedirectToAction("Index", "Clinic");
            }
            return View();
        }
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Clinic? ClinicFromDb = _unitOfWork.Clinics.Get(u => u.Id == id);

            if (ClinicFromDb == null)
            {
                return NotFound();
            }

            return View(ClinicFromDb);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {
            Clinic obj = _unitOfWork.Clinics.Get(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }

            _unitOfWork.Clinics.Remove(obj);
            _unitOfWork.Save();
            TempData["success"] = "Clinic is Deleted";

            return RedirectToAction("Index", "Clinic");


        }
    }
}
