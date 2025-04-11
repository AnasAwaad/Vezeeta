using System.ComponentModel.DataAnnotations;

namespace Vezeeta.Entities.Models
{
	public class Doctor : BaseEntity
	{
		public int Id { get; set; }


		[StringLength(100)]
		public string FirstName { get; set; } = null!;

		[StringLength(100)]
		public string LastName { get; set; } = null!;

		[MaxLength(500)]
		public string About { get; set; } = null!;

		[MaxLength(500)]
		public string Address { get; set; } = null!;

		public int ExperienceYears { get; set; }
		public string? ImagePath { get; set; }
		[MaxLength(500)]
		public string Specialized { get; set; } = null!;

		public ICollection<TimeSlot>? TimeSlots { get; set; } = new List<TimeSlot>();

		public Clinic Clinic { get; set; } = null!;
		public int ClinicId { get; set; }

		public string UserId { get; set; } = null!;
		public ApplicationUser? User { get; set; }
	}
}
