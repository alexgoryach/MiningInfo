using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MiningInfo.Api.Controllers;

/// <summary>
/// Drill block point controller.
/// </summary>
[ApiController]
[Route("api/drillblockpoint")]
[ApiExplorerSettings(GroupName = "Drill")]
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
    /// Get all tools request.
    /// </summary>
    /// <returns>List of tools.</returns>
    [HttpGet]
    public async void Get()
    {
    }
    
    /// <summary>
    /// Add tool to database.
    /// </summary>
    /// <returns>Id of created tool.</returns>
    [HttpPost]
    public async void Post()
    {
    }
}
