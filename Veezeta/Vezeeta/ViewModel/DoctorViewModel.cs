namespace Vezeeta.Presentation.ViewModel;
public class DoctorViewModel
{
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string About { get; set; } = null!;
    public string Specialized { get; set; } = null!;
    public string ImagePath { get; set; }
    public string ClinicName { get; set; } = null!;
    public string Address { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;

}
