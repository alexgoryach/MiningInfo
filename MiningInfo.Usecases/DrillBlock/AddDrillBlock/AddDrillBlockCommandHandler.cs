using MediatR;
using MiningInfo.Infrastructure.Abstraction.Interfaces;

namespace MiningInfo.Usecases.DrillBlock.AddDrillBlock;

/// <summary>
/// Add drill block command handler.
/// </summary>
internal class AddDrillBlockCommandHandler : IRequestHandler<AddDrillBlockCommand, Guid>
{
    private readonly IAppDbContext dbContext;

    public AddDrillBlockCommandHandler(IAppDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    /// <inheritdoc />
    public async Task<Guid> Handle(AddDrillBlockCommand request, CancellationToken cancellationToken)
    {
        var drillBlock = new Domain.Entities.Drill.DrillBlock()
        {
            Name = request.Name,
            UpdateDate = DateTime.UtcNow
        };
        dbContext.DrillBlocks.Add(drillBlock);
        await dbContext.SaveChangesAsync(cancellationToken);
        return drillBlock.Id;
    }
}
