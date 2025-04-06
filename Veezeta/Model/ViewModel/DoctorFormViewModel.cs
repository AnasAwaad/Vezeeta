using Microsoft.AspNetCore.Mvc.Rendering;

namespace Vezeeta.Entities.ViewModel;
public class DoctorFormViewModel
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Address { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string Specailized { get; set; } = null!;
    public double Price { get; set; }
    public string? ImagePath { get; set; }
    public IEnumerable<SelectListItem> ClinicList { get; set; } = new List<SelectListItem>();

    public int ClinicID { get; set; }
}
