using Microsoft.AspNetCore.Mvc.Rendering; 

namespace Model.ViewModel
{
    public class DoctorVm
    {
        public Doctor Doctor { get; set; }
        public IEnumerable<SelectListItem> TimeList { get; set; } = new List<SelectListItem>();
        public List<int> SelectedTimeSlots { get; set; } = new List<int>();

        public IEnumerable<SelectListItem> ClinicList { get; set; } = new List<SelectListItem>();
    }
}
