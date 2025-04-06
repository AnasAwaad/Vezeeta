using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Vezeeta.Entities.Models
{
    public class Doctor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Specailized { get; set; }
        [Required]
        public double Price { get; set; }
        [ValidateNever]
        public string ImageUrl { get; set; }
        public string SelectedTimeSlots { get; set; }

        [ValidateNever]
        [ForeignKey("ClinicID")]
        public Clinic Clinic { get; set; }
        public int ClinicID { get; set; }

    }
}
