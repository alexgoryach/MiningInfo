using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using MiningInfo.Infrastructure.Abstraction.Interfaces;
using MiningInfo.Usecases.Dtos.DrillBlock;

namespace MiningInfo.Usecases.DrillBlock.GetDrillBlocks;

/// <summary>
/// Get drill blocks query handler.
/// </summary>
internal class GetDrillBlocksQueryHandler : IRequestHandler<GetDrillBlocksQuery, List<DrillBlockLightDto>>
{
    private readonly IAppDbContext dbContext;
    private readonly IMapper mapper;

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="dbContext">Application database context.</param>
    /// <param name="mapper">Automapper.</param>
    public GetDrillBlocksQueryHandler(IAppDbContext dbContext, IMapper mapper)
    {
        this.dbContext = dbContext;
        this.mapper = mapper;
    }
    
    /// <inheritdoc />
    public async Task<List<DrillBlockLightDto>> Handle(GetDrillBlocksQuery request, CancellationToken cancellationToken)
    {
        var drillBlocksQuery = dbContext.DrillBlocks.ProjectTo<DrillBlockLightDto>(mapper.ConfigurationProvider);
        var drillBlocks = await drillBlocksQuery.ToListAsync(cancellationToken);
        return drillBlocks;
    }
}
