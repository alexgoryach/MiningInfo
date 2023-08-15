using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using MiningInfo.Infrastructure.Abstraction.Interfaces;
using MiningInfo.Usecases.Dtos.HolePoint;

namespace MiningInfo.Usecases.HolePoint.GetHolePoints;

/// <summary>
/// Get hole points query handler.
/// </summary>
internal class GetHolePointsQueryHandler : IRequestHandler<GetHolePointsQuery, List<HolePointDto>>
{
    private readonly IAppDbContext dbContext;
    private readonly IMapper mapper;

    /// <summary>
    /// Constructor.
    /// </summary>
    public GetHolePointsQueryHandler(IAppDbContext dbContext, IMapper mapper)
    {
        this.dbContext = dbContext;
        this.mapper = mapper;
    }

    /// <inheritdoc />
    public async Task<List<HolePointDto>> Handle(GetHolePointsQuery request, CancellationToken cancellationToken)
    {
        var holePointsQuery = dbContext.HolePoints.ProjectTo<HolePointDto>(mapper.ConfigurationProvider);
        if (request.HoleId != null)
        {
            holePointsQuery = holePointsQuery.Where(dto => dto.Hole.Id == request.HoleId);
        }
        var holePoints = await holePointsQuery.ToListAsync(cancellationToken);
        return holePoints;
    }
}
