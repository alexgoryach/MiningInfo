using MediatR;
using Microsoft.EntityFrameworkCore;
using MiningInfo.Infrastructure.Abstraction.Interfaces;

namespace MiningInfo.Usecases.HolePoint.UpdateHolePointById;

/// <summary>
/// Update hole point by id command handler.
/// </summary>
internal class UpdateHolePointByIdCommandHandler : IRequestHandler<UpdateHolePointByIdCommand>
{
    private readonly IAppDbContext dbContext;

    /// <summary>
    /// Constructor.
    /// </summary>
    public UpdateHolePointByIdCommandHandler(IAppDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    /// <inheritdoc />
    public async Task<Unit> Handle(UpdateHolePointByIdCommand request, CancellationToken cancellationToken)
    {
        var holePoint = 
            await dbContext.HolePoints.FirstOrDefaultAsync(point => point.Id == request.Id, cancellationToken);
        if (request.X != null)
        {
            holePoint.X = request.X;
        }
        if (request.Y != null)
        {
            holePoint.Y = request.Y;
        }
        if (request.Z != null)
        {
            holePoint.Z = request.Z;
        }
        await dbContext.SaveChangesAsync(cancellationToken);
        return Unit.Value;
    }
}
