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
        if (drillBlock != null)
        {
            return mapper.Map<DrillBlockDto>(drillBlock);
        }
        throw new Exception("Not found drill block by this id.");
    }
}
