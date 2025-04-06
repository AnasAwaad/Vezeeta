using System.ComponentModel.DataAnnotations.Schema;

namespace Vezeeta.Entities.Models
{
    public class TimeSlot : BaseEntity
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public int DoctorId { get; set; }

        [ForeignKey("DoctorId")]
        public Doctor Doctor { get; set; } = null!;
    }
}
