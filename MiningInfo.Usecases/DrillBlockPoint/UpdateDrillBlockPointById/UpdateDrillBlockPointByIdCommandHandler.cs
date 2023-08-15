using MediatR;
using Microsoft.EntityFrameworkCore;
using MiningInfo.Infrastructure.Abstraction.Interfaces;

namespace MiningInfo.Usecases.DrillBlockPoint.UpdateDrillBlockPointById;

/// <summary>
/// Update drill block point by id command handler.
/// </summary>
public class UpdateDrillBlockPointByIdCommandHandler : IRequestHandler<UpdateDrillBlockPointByIdCommand>
{
    private readonly IAppDbContext dbContext;

    /// <summary>
    /// Constructor.
    /// </summary>
    public UpdateDrillBlockPointByIdCommandHandler(IAppDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    /// <inheritdoc />
    public async Task<Unit> Handle(UpdateDrillBlockPointByIdCommand request, CancellationToken cancellationToken)
    {
        var drillBlockPoint = 
            await dbContext.DrillBlockPoints.FirstOrDefaultAsync(point => point.Id == request.Id, cancellationToken);
        if (request.Sequence != null)
        {
            drillBlockPoint.Sequence = request.Sequence.Value;
        }
        if (request.X != null)
        {
            drillBlockPoint.X = request.X.Value;
        }
        if (request.Y != null)
        {
            drillBlockPoint.Y = request.Y.Value;
        }
        if (request.Z != null)
        {
            drillBlockPoint.Z = request.Z.Value;
        }
        await dbContext.SaveChangesAsync(cancellationToken);
        return Unit.Value;
    }
}
