using AutoMapper;
using MiningInfo.Usecases.Dtos.HolePoint;
using MiningInfo.Usecases.HolePoint.AddHolePoint;

namespace MiningInfo.Usecases.HolePoint;

/// <summary>
/// Hole point mapping profile.
/// </summary>
public class HolePointMappingProfile : Profile
{
    /// <summary>
    /// Constructor.
    /// </summary>
    public HolePointMappingProfile()
    {
        CreateMap<AddHolePointCommand, Domain.Entities.Hole.HolePoint>();
        CreateMap<Domain.Entities.Hole.HolePoint, HolePointDto>()
            .ForMember(dest => dest.Hole, opt => opt.MapFrom(src => src.Hole));
    }
}
