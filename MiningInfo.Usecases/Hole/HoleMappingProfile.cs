using AutoMapper;
using MiningInfo.Usecases.Dtos.Hole;
using MiningInfo.Usecases.Hole.AddHole;

namespace MiningInfo.Usecases.Hole;

/// <summary>
/// Hole mapping profile.
/// </summary>
public class HoleMappingProfile : Profile
{
    /// <summary>
    /// Constructor.
    /// </summary>
    public HoleMappingProfile()
    {
        CreateMap<AddHoleCommand, Domain.Entities.Hole.Hole>();
        CreateMap<Domain.Entities.Hole.Hole, HoleDto>()
            .ForMember(dest => dest.DrillBlock, opt => opt.MapFrom(src => src.DrillBlock));
    }
}
