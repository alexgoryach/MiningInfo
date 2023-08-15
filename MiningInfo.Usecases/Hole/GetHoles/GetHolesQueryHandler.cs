using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using MiningInfo.Infrastructure.Abstraction.Interfaces;
using MiningInfo.Usecases.Dtos.Hole;

namespace MiningInfo.Usecases.Hole.GetHoles;

/// <summary>
/// Get holes query handler.
/// </summary>
internal class GetHolesQueryHandler : IRequestHandler<GetHolesQuery, List<HoleDto>>
{
    private readonly IAppDbContext dbContext;
    private readonly IMapper mapper;

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="dbContext">Application database context.</param>
    /// <param name="mapper">Automapper.</param>
    public GetHolesQueryHandler(IAppDbContext dbContext, IMapper mapper)
    {
        this.dbContext = dbContext;
        this.mapper = mapper;
    }

    /// <inheritdoc />
    public async Task<List<HoleDto>> Handle(GetHolesQuery request, CancellationToken cancellationToken)
    {
        var holesQuery = dbContext.Holes.ProjectTo<HoleDto>(mapper.ConfigurationProvider);
        if (request.DrillBlockId != null)
        {
            holesQuery = holesQuery.Where(dto => dto.DrillBlock.Id == request.DrillBlockId);
        }
        var holes = await holesQuery.ToListAsync(cancellationToken);
        return holes;
    }
}
