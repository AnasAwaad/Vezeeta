using AutoMapper;
using Vezeeta.Entities.Models;
using Vezeeta.Entities.ViewModel;
using Vezeeta.Entities.ViewModel.Clinic;

namespace Vezeeta.Presentation.Mapping;

public class DomainProfile : Profile
{
	public DomainProfile()
	{
		CreateMap<Doctor, DoctorFormViewModel>().ReverseMap();
		CreateMap<TimeSlot, TimeSlotViewModel>();
		CreateMap<Doctor, DoctorViewModel>()
			.ForMember(src => src.Clinic, opt => opt.MapFrom(dest => dest.Clinic.Name));


		CreateMap<Clinic, ClinicViewModel>();
		CreateMap<Clinic, ClinicFormViewModel>().ReverseMap();

	}
}
