using System.Text.Json.Serialization;
using MediatR;

namespace MiningInfo.Usecases.DrillBlock.UpdateDrillBlockById;

/// <summary>
/// Update drill block by id command.
/// </summary>
public record UpdateDrillBlockByIdCommand : IRequest
{
    /// <summary>
    /// Drill block identifier.
    /// </summary>
    [JsonIgnore]
    public Guid Id { get; init; }

    /// <summary>
    /// Drill block name.
    /// </summary>
    public string Name { get; init; }
}
