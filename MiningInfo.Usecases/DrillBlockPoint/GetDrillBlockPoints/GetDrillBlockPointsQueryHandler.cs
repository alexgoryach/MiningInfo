using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using MiningInfo.Infrastructure.Abstraction.Interfaces;
using MiningInfo.Usecases.Dtos.DrillBlockPoint;

namespace MiningInfo.Usecases.DrillBlockPoint.GetDrillBlockPoints;

/// <summary>
/// Get drill block points query handler.
/// </summary>
internal class GetDrillBlockPointsQueryHandler : IRequestHandler<GetDrillBlockPointsQuery, List<DrillBlockPointDto>>
{
    private readonly IAppDbContext dbContext;
    private readonly IMapper mapper;

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="dbContext">Application database context.</param>
    /// <param name="mapper">Automapper.</param>
    public GetDrillBlockPointsQueryHandler(IAppDbContext dbContext, IMapper mapper)
    {
        this.dbContext = dbContext;
        this.mapper = mapper;
    }
    
    /// <inheritdoc />
    public async Task<List<DrillBlockPointDto>> Handle(GetDrillBlockPointsQuery request, CancellationToken cancellationToken)
    {
        var drillBlockPointsQuery = dbContext.DrillBlockPoints.ProjectTo<DrillBlockPointDto>(mapper.ConfigurationProvider);
        if (request.DrillBlockId != null)
        {
            drillBlockPointsQuery = drillBlockPointsQuery.Where(dto => dto.DrillBlock.Id == request.DrillBlockId);
        }
        var drillBlockPoints = await drillBlockPointsQuery.ToListAsync(cancellationToken);
        return drillBlockPoints;
    }
}
