using AutoMapper;
using Oceanica.API.Dtos;
using Oceanica.API.Models;

namespace Oceanica.API.Profiles;

public class DepartamentProfile : Profile
{
    public DepartamentProfile()
    {
        CreateMap<CreateDepartamentDto, Departament>().ReverseMap();
        CreateMap<UpdateDepartamentDto, Departament>().ReverseMap();
        CreateMap<ReadDepartamentDto, Departament>().ReverseMap()
            .ForMember(dto => dto.Crew,
            opt => opt.MapFrom(departament => departament.Crew));
    }
}
