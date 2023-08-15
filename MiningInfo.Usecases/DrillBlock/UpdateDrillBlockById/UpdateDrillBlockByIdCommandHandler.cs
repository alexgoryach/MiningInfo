using MediatR;
using Microsoft.EntityFrameworkCore;
using MiningInfo.Infrastructure.Abstraction.Interfaces;

namespace MiningInfo.Usecases.DrillBlock.UpdateDrillBlockById;

/// <summary>
/// Update drill block by id command handler.
/// </summary>
internal class UpdateDrillBlockByIdCommandHandler : IRequestHandler<UpdateDrillBlockByIdCommand>
{
    private readonly IAppDbContext dbContext;

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="dbContext">Application database context.</param>
    /// <param name="mapper">Automapper.</param>
    public UpdateDrillBlockByIdCommandHandler(IAppDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
    
    /// <inheritdoc />
    public async Task<Unit> Handle(UpdateDrillBlockByIdCommand request, CancellationToken cancellationToken)
    {
        var drillBlock =
            await dbContext.DrillBlocks.FirstOrDefaultAsync(block => block.Id == request.Id, cancellationToken);
        if (drillBlock != null)
        {
            drillBlock.Name = request.Name;
            drillBlock.UpdateDate = DateTime.UtcNow;
            await dbContext.SaveChangesAsync(cancellationToken);
        }
        return Unit.Value;
    }
}
