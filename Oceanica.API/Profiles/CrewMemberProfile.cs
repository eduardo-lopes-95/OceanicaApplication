using AutoMapper;
using Oceanica.API.Dtos;
using Oceanica.API.Models;

namespace Oceanica.API.Profiles;

public class CrewMemberProfile : Profile
{
    public CrewMemberProfile()
    {
        CreateMap<CreateCrewMemberDto, CrewMember>().ReverseMap();
        CreateMap<UpdateCrewMemberDto, CrewMember>().ReverseMap();
        CreateMap<ReadCrewMemberDto, CrewMember>().ReverseMap();
    }
}
