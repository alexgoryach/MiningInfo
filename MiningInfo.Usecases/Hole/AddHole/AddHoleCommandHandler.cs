using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using MiningInfo.Infrastructure.Abstraction.Interfaces;

namespace MiningInfo.Usecases.Hole.AddHole;

/// <summary>
/// Add hole command handler.
/// </summary>
internal class AddHoleCommandHandler : IRequestHandler<AddHoleCommand, Guid>
{
    private readonly IAppDbContext dbContext;
    private readonly IMapper mapper;

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="dbContext">Application database context.</param>
    /// <param name="mapper">Automapper.</param>
    public AddHoleCommandHandler(IAppDbContext dbContext, IMapper mapper)
    {
        this.dbContext = dbContext;
        this.mapper = mapper;
    }
    
    /// <inheritdoc />
    public async Task<Guid> Handle(AddHoleCommand request, CancellationToken cancellationToken)
    {
        var drillBlock = 
            await dbContext.DrillBlocks.FirstOrDefaultAsync(block => block.Id == request.DrillBlockId, cancellationToken);
        var hole = mapper.Map<Domain.Entities.Hole.Hole>(request);
        hole.DrillBlock = drillBlock;
        dbContext.Holes.Add(hole);
        await dbContext.SaveChangesAsync(cancellationToken);
        return hole.Id;
    }
}
