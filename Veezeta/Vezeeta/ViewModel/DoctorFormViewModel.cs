using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using UoN.ExpressiveAnnotations.NetCore.Attributes;

namespace Vezeeta.Presentation.ViewModel;
public class DoctorFormViewModel
{
	public int Id { get; set; }
	public string FullName { get; set; } = null!;
	public string Address { get; set; } = null!;
	public string PhoneNumber { get; set; } = null!;
	public string Description { get; set; } = null!;
	public string Specailized { get; set; } = null!;
	public double Price { get; set; }
	public string? ImagePath { get; set; }
	public IEnumerable<SelectListItem> ClinicList { get; set; } = new List<SelectListItem>();

	public int ClinicID { get; set; }


	public string UserName { get; set; } = null!;
	public string Email { get; set; } = null!;

	[RequiredIf("Id==0", ErrorMessage = "Password is required.")]
	public string? Password { get; set; }

	[Display(Name = "Confirm password")]
	[RequiredIf("Id==0", ErrorMessage = "Confirm Password is required.")]
	[Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
	public string? ConfirmPassword { get; set; }

}
