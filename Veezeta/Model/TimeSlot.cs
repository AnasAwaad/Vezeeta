using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Model
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
