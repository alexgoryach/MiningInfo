using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using MiningInfo.Infrastructure.Abstraction.Interfaces;

namespace MiningInfo.Usecases.HolePoint.AddHolePoint;

/// <summary>
/// Add hole point command handler.
/// </summary>
public class AddHolePointCommandHandler : IRequestHandler<AddHolePointCommand, Guid>
{
    private readonly IAppDbContext dbContext;
    private readonly IMapper mapper;

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="dbContext">Application database context.</param>
    /// <param name="mapper">Automapper.</param>
    public AddHolePointCommandHandler(IAppDbContext dbContext, IMapper mapper)
    {
        this.dbContext = dbContext;
        this.mapper = mapper;
    }

    /// <inheritdoc />
    public async Task<Guid> Handle(AddHolePointCommand request, CancellationToken cancellationToken)
    {
        var hole =
            await dbContext.Holes.FirstOrDefaultAsync(hole => hole.Id == request.HoleId, cancellationToken);
        var holePoint = mapper.Map<Domain.Entities.Hole.HolePoint>(request);
        holePoint.Hole = hole;
        dbContext.HolePoints.Add(holePoint);
        await dbContext.SaveChangesAsync(cancellationToken);
        return holePoint.Id;
    }
}
