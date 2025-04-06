using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vezeeta.Entities.Models
{
    public class Doctor : BaseEntity
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; } = null!;

        [MaxLength(500)]
        public string Description { get; set; } = null!;
        [MaxLength(500)]
        public string Specailized { get; set; } = null!;
        [MaxLength(15)]
        public string PhoneNumber { get; set; } = null!;
        public string Address { get; set; } = null!;
        public double Price { get; set; }
        public string? ImagePath { get; set; }
        public ICollection<TimeSlot>? TimeSlots { get; set; }

        [ForeignKey("ClinicID")]
        public Clinic Clinic { get; set; } = null!;
        public int ClinicID { get; set; }

    }
}
