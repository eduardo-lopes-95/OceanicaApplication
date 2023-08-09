using AutoMapper;
using Oceanica.API.Dtos;
using Oceanica.API.Models;

namespace Oceanica.API.Profiles;

public class VesselProfile : Profile
{
    public VesselProfile()
    {
        CreateMap<CreateVesselDto, Vessel>().ReverseMap();
        CreateMap<UpdateVesselDto, Vessel>().ReverseMap();
        CreateMap<ReadVesselDto, Vessel>().ReverseMap()
            .ForMember(dto => dto.Departaments,
            opt => opt.MapFrom(vessel => vessel.Departaments));
    }
}
