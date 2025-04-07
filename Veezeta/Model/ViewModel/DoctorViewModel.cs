namespace Vezeeta.Entities.ViewModel;
public class DoctorViewModel
{
	public int Id { get; set; }
	public string Name { get; set; } = null!;

	public string Description { get; set; } = null!;
	public string Specailized { get; set; } = null!;
	public double Price { get; set; }
	public string? ImagePath { get; set; }
	public string Clinic { get; set; }
	public string Address { get; set; }
	public string PhoneNumber { get; set; }

}
