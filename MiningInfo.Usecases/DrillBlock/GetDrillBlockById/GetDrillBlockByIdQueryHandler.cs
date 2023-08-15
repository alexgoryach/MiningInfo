using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using MiningInfo.Infrastructure.Abstraction.Interfaces;
using MiningInfo.Usecases.Dtos.DrillBlock;

namespace MiningInfo.Usecases.DrillBlock.GetDrillBlockById;

/// <summary>
/// Get drill block by id query handler.
/// </summary>
internal class GetDrillBlockByIdQueryHandler : IRequestHandler<GetDrillBlockByIdQuery, DrillBlockDto>
{
    private readonly IAppDbContext dbContext;
    private readonly IMapper mapper;

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="dbContext">Data base context.</param>
    /// <param name="mapper">Mapper.</param>
    public GetDrillBlockByIdQueryHandler(IAppDbContext dbContext, IMapper mapper)
    {
        this.dbContext = dbContext;
        this.mapper = mapper;
    }

    /// <inheritdoc />
    public async Task<DrillBlockDto> Handle(GetDrillBlockByIdQuery request, CancellationToken cancellationToken)
    {
        var drillBlock =
            await dbContext.DrillBlocks.FirstOrDefaultAsync(block => block.Id == request.DrillBlockId, cancellationToken);
        return mapper.Map<DrillBlockDto>(drillBlock);
    }
}
