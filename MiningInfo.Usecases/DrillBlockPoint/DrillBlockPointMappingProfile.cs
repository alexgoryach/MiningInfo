using AutoMapper;
using MiningInfo.Usecases.DrillBlockPoint.AddDrillBlockPoint;
using MiningInfo.Usecases.Dtos.DrillBlockPoint;

namespace MiningInfo.Usecases.DrillBlockPoint;

/// <summary>
/// Drill block point mapping profile.
/// </summary>
public class DrillBlockPointMappingProfile : Profile
{
    /// <summary>
    /// Constructor.
    /// </summary>
    public DrillBlockPointMappingProfile()
    {
        CreateMap<AddDrillBlockPointCommand, Domain.Entities.Drill.DrillBlockPoint>();
        CreateMap<Domain.Entities.Drill.DrillBlockPoint, DrillBlockPointDto>()
            .ForMember(dest => dest.DrillBlock, opt => opt.MapFrom(src => src.DrillBlock));
    }
}
