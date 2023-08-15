using MediatR;
using Microsoft.AspNetCore.Mvc;
using MiningInfo.Usecases.Dtos.Hole;
using MiningInfo.Usecases.Hole.AddHole;
using MiningInfo.Usecases.Hole.DeleteHoleById;
using MiningInfo.Usecases.Hole.GetHoles;
using MiningInfo.Usecases.Hole.UpdateHoleById;

namespace MiningInfo.Api.Controllers;

/// <summary>
/// Hole controller.
/// </summary>
[ApiController]
[Route("api/hole")]
public class HoleController : ControllerBase
{
    private readonly IMediator mediator;

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="mediator">MediatR.</param>
    public HoleController(IMediator mediator)
    {
        this.mediator = mediator;
    }

    /// <summary>
    /// Get all tools request.
    /// </summary>
    /// <returns>List of tools.</returns>
    [HttpGet]
    public async Task<List<HoleDto>> GetHoles([FromQuery] GetHolesQuery query, CancellationToken cancellationToken)
        => await mediator.Send(query, cancellationToken);

    /// <summary>
    /// Add hole.
    /// </summary>
    /// <param name="command">Add hole command.</param>
    /// <param name="cancellationToken"></param>
    [HttpPost]
    public async Task<Guid> AddHole (AddHoleCommand command, CancellationToken cancellationToken)
        => await mediator.Send(command, cancellationToken);

    /// <summary>
    /// Update hole by id.
    /// </summary>
    /// <param name="holeId">Hole identifier.</param>
    /// <param name="command">Command.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    [HttpPut("{holeId}")]
    public async Task UpdateHoleById(Guid holeId, UpdateHoleByIdCommand command, CancellationToken cancellationToken)
        => await mediator.Send(command with { Id = holeId }, cancellationToken);
    
    /// <summary>
    /// Delete hole by id.
    /// </summary>
    /// <param name="holeId">Hole id.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    [HttpDelete("{holeId}")]
    public async Task DeleteHoleById(Guid holeId, CancellationToken cancellationToken)
        => await mediator.Send(new DeleteHoleByIdCommand(holeId), cancellationToken);
}
