using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using UoN.ExpressiveAnnotations.NetCore.Attributes;

namespace Vezeeta.Presentation.ViewModel;
public class DoctorFormViewModel
{
    public int Id { get; set; }

    [Display(Name = "First Name")]
    public string FirstName { get; set; } = null!;

    [Display(Name = "Last Name")]
    public string LastName { get; set; } = null!;
    public string About { get; set; } = null!;
    public string Address { get; set; } = null!;

    [Display(Name = "Experience (In Year)")]
    public int ExperienceYears { get; set; }
    public string Specialized { get; set; } = null!;
    public string? ImagePath { get; set; }

    [Display(Name = "Profile Image")]
    public IFormFile? ProfileImage { get; set; }

    public IEnumerable<SelectListItem> ClinicList { get; set; } = new List<SelectListItem>();
    public int ClinicId { get; set; }

    [Display(Name = "User name")]
    public string UserName { get; set; } = null!;

    [Display(Name = "Phone Number")]
    public string PhoneNumber { get; set; } = null!;
    public string Email { get; set; } = null!;

    [RequiredIf("Id==0", ErrorMessage = "Password is required.")]
    public string? Password { get; set; }

    [Display(Name = "Confirm password")]
    [RequiredIf("Id==0", ErrorMessage = "Confirm Password is required.")]
    [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
    public string? ConfirmPassword { get; set; }
    public bool IsDeleted { get; set; }
}
