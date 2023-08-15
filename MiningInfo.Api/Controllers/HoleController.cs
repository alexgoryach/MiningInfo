using MediatR;
using Microsoft.AspNetCore.Mvc;

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
