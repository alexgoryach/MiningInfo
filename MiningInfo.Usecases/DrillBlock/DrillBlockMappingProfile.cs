using AutoMapper;
using MiningInfo.Usecases.DrillBlock.AddDrillBlock;
using MiningInfo.Usecases.Dtos.DrillBlock;

namespace MiningInfo.Usecases.DrillBlock;

/// <summary>
/// Drill block mapping profile.
/// </summary>
public class DrillBlockMappingProfile : Profile
{
    /// <summary>
    /// Constructor.
    /// </summary>
    public DrillBlockMappingProfile()
    {
        CreateMap<AddDrillBlockCommand, Domain.Entities.Drill.DrillBlock>();
        CreateMap<Domain.Entities.Drill.DrillBlock, DrillBlockDto>();
    }
}
