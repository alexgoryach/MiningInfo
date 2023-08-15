using MediatR;
using Microsoft.EntityFrameworkCore;
using MiningInfo.Infrastructure.Abstraction.Interfaces;

namespace MiningInfo.Usecases.Hole.DeleteHoleById;

/// <summary>
/// Delete hole command handler.
/// </summary>
internal class DeleteHoleByIdCommandHandler : IRequestHandler<DeleteHoleByIdCommand>
{
    private readonly IAppDbContext dbContext;

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="dbContext"></param>
    public DeleteHoleByIdCommandHandler(IAppDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    /// <inheritdoc />
    public async Task<Unit> Handle(DeleteHoleByIdCommand request, CancellationToken cancellationToken)
    {
        var hole =
            await dbContext.Holes.FirstOrDefaultAsync(hole => hole.Id == request.HoleId, cancellationToken);
        dbContext.Holes.Remove(hole);
        await dbContext.SaveChangesAsync(cancellationToken);
        return Unit.Value;
    }
}
