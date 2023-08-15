using MediatR;
using Microsoft.AspNetCore.Mvc;
using MiningInfo.Usecases.Dtos.HolePoint;
using MiningInfo.Usecases.HolePoint.AddHolePoint;
using MiningInfo.Usecases.HolePoint.DeleteHolePointById;
using MiningInfo.Usecases.HolePoint.GetHolePoints;
using MiningInfo.Usecases.HolePoint.UpdateHolePointById;

namespace MiningInfo.Api.Controllers;

/// <summary>
/// Hole point controller.
/// </summary>
[ApiController]
[Route("api/holepoint")]
public class HolePointController : ControllerBase
{
    private readonly IMediator mediator;

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="mediator">MediatR.</param>
    public HolePointController(IMediator mediator)
    {
        this.mediator = mediator;
    }

    /// <summary>
    /// Add hole point.
    /// </summary>
    /// <param name="command">Add hole point command.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>Identifier of hole point.</returns>
    [HttpPost]
    public async Task<Guid> AddHolePoint (AddHolePointCommand command, CancellationToken cancellationToken)
        => await mediator.Send(command, cancellationToken);
    
    /// <summary>
    /// Get hole points.
    /// </summary>
    /// <param name="query">Query.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>List of hole points.</returns>
    [HttpGet]
    public async Task<List<HolePointDto>> GetHolePoints([FromQuery] GetHolePointsQuery query, CancellationToken cancellationToken)
        => await mediator.Send(query, cancellationToken);
    
    /// <summary>
    /// Update hole point.
    /// </summary>
    /// <param name="holePointId">Hole point id.</param>
    /// <param name="command">Command.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    [HttpPut("{holePointId}")]
    public async Task UpdateHolePointById(Guid holePointId, UpdateHolePointByIdCommand command, CancellationToken cancellationToken)
        => await mediator.Send(command with { Id = holePointId }, cancellationToken);
    
    /// <summary>
    /// Delete hole point.
    /// </summary>
    /// <param name="holePointId">Hole point identifier.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    [HttpDelete("{holePointId}")]
    public async Task DeleteHolePointById(Guid holePointId, CancellationToken cancellationToken)
        => await mediator.Send(new DeleteHolePointByIdCommand(holePointId), cancellationToken);
}
