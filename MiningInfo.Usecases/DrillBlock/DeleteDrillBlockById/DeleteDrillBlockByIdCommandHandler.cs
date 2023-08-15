using MediatR;
using Microsoft.EntityFrameworkCore;
using MiningInfo.Infrastructure.Abstraction.Interfaces;

namespace MiningInfo.Usecases.DrillBlock.DeleteDrillBlockById;

/// <summary>
/// Delete drill block by id command handler.
/// </summary>
internal class DeleteDrillBlockByIdCommandHandler : IRequestHandler<DeleteDrillBlockByIdCommand>
{
    private readonly IAppDbContext dbContext;

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="dbContext">Application database context.</param>
    public DeleteDrillBlockByIdCommandHandler(IAppDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
    
    /// <inheritdoc />
    public async Task<Unit> Handle(DeleteDrillBlockByIdCommand request, CancellationToken cancellationToken)
    {
        var drillBlock =
            await dbContext.DrillBlocks.FirstOrDefaultAsync(block => block.Id == request.DrillBlockId, cancellationToken);
        dbContext.DrillBlocks.Remove(drillBlock);
        dbContext.SaveChangesAsync(cancellationToken);
        return Unit.Value;
    }
}
