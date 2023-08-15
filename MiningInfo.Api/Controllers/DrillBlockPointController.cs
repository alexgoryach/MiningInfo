using MediatR;
using Microsoft.AspNetCore.Mvc;
using MiningInfo.Usecases.DrillBlockPoint.AddDrillBlockPoint;
using MiningInfo.Usecases.DrillBlockPoint.DeleteDrillBlockPointById;
using MiningInfo.Usecases.DrillBlockPoint.GetDrillBlockPoints;
using MiningInfo.Usecases.DrillBlockPoint.UpdateDrillBlockPointById;
using MiningInfo.Usecases.Dtos.DrillBlockPoint;

namespace MiningInfo.Api.Controllers;

/// <summary>
/// Drill block point controller.
/// </summary>
[ApiController]
[Route("api/drillblockpoint")]
public class DrillBlockPointController : ControllerBase
{
    private readonly IMediator mediator;

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="mediator">MediatR.</param>
    public DrillBlockPointController(IMediator mediator)
    {
        this.mediator = mediator;
    }

    /// <summary>
    /// Add drill block point.
    /// </summary>
    /// <param name="command">Add drill block point command.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>Identifier of new drill block point.</returns>
    [HttpPost]
    public async Task<Guid> AddDrillBlockPoint(AddDrillBlockPointCommand command, CancellationToken cancellationToken)
        => await mediator.Send(command, cancellationToken);

    /// <summary>
    /// Get drill block points.
    /// </summary>
    /// <param name="query">Get drill block points query.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>Drill block points DTOs.</returns>
    [HttpGet]
    public async Task<List<DrillBlockPointDto>> GetDrillBlockPoints([FromQuery]GetDrillBlockPointsQuery query, CancellationToken cancellationToken)
        => await mediator.Send(query, cancellationToken);

    /// <summary>
    /// Update drill block point by id.
    /// </summary>
    /// <param name="drillBlockPointId">Drill block identifier.</param>
    /// <param name="command">Update drill block point command.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    [HttpPut("{drillBlockPointId}")]
    public async Task UpdateDrillBlockPointById(Guid drillBlockPointId, UpdateDrillBlockPointByIdCommand command, CancellationToken cancellationToken)
        => await mediator.Send(command with { Id = drillBlockPointId }, cancellationToken);

    /// <summary>
    /// Delete drill block point by id.
    /// </summary>
    /// <param name="drillBlockPointId">Drill block point identifier.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    [HttpDelete("{drillBlockPointId}")]
    public async Task DeleteDrillBlockPointById(Guid drillBlockPointId, CancellationToken cancellationToken)
        => await mediator.Send(new DeleteDrillBlockPointByIdCommand(drillBlockPointId), cancellationToken);
}
