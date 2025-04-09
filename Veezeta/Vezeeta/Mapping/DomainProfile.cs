using AutoMapper;
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
            .ForMember(src => src.Clinic, opt => opt.MapFrom(dest => dest.Clinic.Name))
            .ForMember(src => src.FullName, opt => opt.MapFrom(dest => dest.User.FullName));


        CreateMap<Clinic, ClinicFormViewModel>().ReverseMap();

    }
}
