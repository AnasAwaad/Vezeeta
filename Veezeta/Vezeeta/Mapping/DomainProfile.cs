using AutoMapper;
using Vezeeta.Presentation.ViewModel;
using Vezeeta.Presentation.ViewModel.Clinic;

namespace Vezeeta.Presentation.Mapping;

public class DomainProfile : Profile
{
	public DomainProfile()
	{
		CreateMap<Doctor, DoctorFormViewModel>()
			//.ForMember(src => src.FullName, opt => opt.MapFrom(dest => dest.User.FullName))
			.ForMember(src => src.UserName, opt => opt.MapFrom(dest => dest.User.UserName))
			.ForMember(src => src.Email, opt => opt.MapFrom(dest => dest.User.Email));

		CreateMap<DoctorFormViewModel, Doctor>();

		CreateMap<TimeSlot, TimeSlotViewModel>();
		CreateMap<Doctor, DoctorViewModel>()
			.ForMember(src => src.Clinic, opt => opt.MapFrom(dest => dest.Clinic.Name));
		//.ForMember(src => src.FullName, opt => opt.MapFrom(dest => dest.User.FullName));


		CreateMap<Clinic, ClinicFormViewModel>().ReverseMap();

	}
}
