using MediatR;
using Microsoft.EntityFrameworkCore;
using MiningInfo.Infrastructure.Abstraction.Interfaces;

namespace MiningInfo.Usecases.DrillBlockPoint.DeleteDrillBlockPointById;

/// <summary>
/// Delete drill block point by id command handler.
/// </summary>
internal class DeleteDrillBlockPointByIdCommandHandler : IRequestHandler<DeleteDrillBlockPointByIdCommand>
{
    private readonly IAppDbContext dbContext;

    /// <summary>
    /// Constructor.
    /// </summary>
    public DeleteDrillBlockPointByIdCommandHandler(IAppDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    /// <inheritdoc />
    public async Task<Unit> Handle(DeleteDrillBlockPointByIdCommand request, CancellationToken cancellationToken)
    {
        var drillBlockPoint = 
            await dbContext.DrillBlockPoints.FirstOrDefaultAsync(point => point.Id == request.DrillBlockPointId, cancellationToken);
        dbContext.DrillBlockPoints.Remove(drillBlockPoint);
        await dbContext.SaveChangesAsync(cancellationToken);
        return Unit.Value;
    }
}
