using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vezeeta.Entities.Models
{
    public class TimeSlot
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Date { get; set; }
        public int DoctorId { get; set; }
        [ValidateNever]
        [ForeignKey("DoctorId")]
        public Doctor Doctor { get; set; }
        [DefaultValue(true)]
        public bool Avaiable { get; set; }
    }
}
