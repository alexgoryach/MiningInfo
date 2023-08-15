using MediatR;
using Microsoft.AspNetCore.Mvc;
using MiningInfo.Usecases.DrillBlock.AddDrillBlock;
using MiningInfo.Usecases.DrillBlock.GetDrillBlockById;
using MiningInfo.Usecases.Dtos.DrillBlock;

namespace MiningInfo.Api.Controllers;

/// <summary>
/// Drill block controller.
/// </summary>
[ApiController]
[Route("api/drillblock")]
public class DrillBlockController : ControllerBase
{
    private readonly IMediator mediator;

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="mediator">MediatR.</param>
    public DrillBlockController(IMediator mediator)
    {
        this.mediator = mediator;
    }

    /// <summary>
    /// Get drill block by id.
    /// </summary>
    /// <param name="drillBlockId">Drill block identifier.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>Drill block DTO.</returns>
    [HttpGet("{drillBlockId}")]
    public async Task<DrillBlockDto> GetDrillBlockById(Guid drillBlockId, CancellationToken cancellationToken)
        => await mediator.Send(new GetDrillBlockByIdQuery(drillBlockId), cancellationToken);

    /// <summary>
    /// Add drill block.
    /// </summary>
    /// <param name="command">Add drill block command.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>Identifier of new drill block.</returns>
    [HttpPost]
    public async Task<Guid> AddDrillBlock(AddDrillBlockCommand command, CancellationToken cancellationToken)
        => await mediator.Send(command, cancellationToken);
}
