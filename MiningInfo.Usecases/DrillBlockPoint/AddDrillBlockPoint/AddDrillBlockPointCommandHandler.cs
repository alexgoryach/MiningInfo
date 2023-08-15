using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using MiningInfo.Infrastructure.Abstraction.Interfaces;

namespace MiningInfo.Usecases.DrillBlockPoint.AddDrillBlockPoint;

/// <summary>
/// Add drill block point by id command handler.
/// </summary>
internal class AddDrillBlockPointCommandHandler : IRequestHandler<AddDrillBlockPointCommand, Guid>
{
    private readonly IAppDbContext dbContext;
    private readonly IMapper mapper;

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="dbContext">Application database context.</param>
    /// <param name="mapper">Automapper.</param>
    public AddDrillBlockPointCommandHandler(IAppDbContext dbContext, IMapper mapper)
    {
        this.dbContext = dbContext;
        this.mapper = mapper;
    }

    /// <inheritdoc />
    public async Task<Guid> Handle(AddDrillBlockPointCommand request, CancellationToken cancellationToken)
    {
        var drillBlock = 
            await dbContext.DrillBlocks.FirstOrDefaultAsync(block => block.Id == request.DrillBlockId, cancellationToken);
        var drillBlockPoint = mapper.Map<Domain.Entities.Drill.DrillBlockPoint>(request);
        drillBlockPoint.DrillBlock = drillBlock;
        dbContext.DrillBlockPoints.Add(drillBlockPoint);
        await dbContext.SaveChangesAsync(cancellationToken);
        return drillBlockPoint.Id;
    }
}
