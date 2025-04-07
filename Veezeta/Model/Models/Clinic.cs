using System.ComponentModel.DataAnnotations;

namespace Vezeeta.Entities.Models
{
	public class Clinic : BaseEntity
	{
		public int Id { get; set; }
		[StringLength(100)]
		public string Name { get; set; } = null!;

		[StringLength(400)]
		public string Location { get; set; } = null!;

		public ICollection<Doctor>? Doctors { get; set; }
	}
}
