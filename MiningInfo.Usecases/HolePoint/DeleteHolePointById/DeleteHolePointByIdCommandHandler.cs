using MediatR;
using Microsoft.EntityFrameworkCore;
using MiningInfo.Infrastructure.Abstraction.Interfaces;

namespace MiningInfo.Usecases.HolePoint.DeleteHolePointById;

/// <summary>
/// Delete hole point by id command handler.
/// </summary>
internal class DeleteHolePointByIdCommandHandler : IRequestHandler<DeleteHolePointByIdCommand>
{
    private readonly IAppDbContext dbContext;

    /// <summary>
    /// Constructor.
    /// </summary>
    public DeleteHolePointByIdCommandHandler(IAppDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    /// <inheritdoc />
    public async Task<Unit> Handle(DeleteHolePointByIdCommand request, CancellationToken cancellationToken)
    {
        var holePoint = 
            await dbContext.HolePoints.FirstOrDefaultAsync(point => point.Id == request.HolePointId, cancellationToken);
        dbContext.HolePoints.Remove(holePoint);
        await dbContext.SaveChangesAsync(cancellationToken);
        return Unit.Value;
    }
}
