using MediatR;
using Microsoft.EntityFrameworkCore;
using MiningInfo.Infrastructure.Abstraction.Interfaces;

namespace MiningInfo.Usecases.Hole.UpdateHoleById;

/// <summary>
/// Update hole by id command handler.
/// </summary>
internal class UpdateHoleByIdCommandHandler : IRequestHandler<UpdateHoleByIdCommand>
{
    private readonly IAppDbContext dbContext;

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="dbContext">Application database context.</param>
    public UpdateHoleByIdCommandHandler(IAppDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    /// <inheritdoc />
    public async Task<Unit> Handle(UpdateHoleByIdCommand request, CancellationToken cancellationToken)
    {
        var hole =
            await dbContext.Holes.FirstOrDefaultAsync(hole => hole.Id == request.Id, cancellationToken);
        if (request.Name != null)
        {
            hole.Name = request.Name;
        }
        if (request.Depth != null)
        {
            hole.Depth = request.Depth;
        }
        await dbContext.SaveChangesAsync(cancellationToken);
        return Unit.Value;
    }
}
