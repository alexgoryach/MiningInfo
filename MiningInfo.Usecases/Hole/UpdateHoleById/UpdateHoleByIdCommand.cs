using System.Text.Json.Serialization;
using MediatR;

namespace MiningInfo.Usecases.Hole.UpdateHoleById;

/// <summary>
/// Update hole command.
/// </summary>
public record UpdateHoleByIdCommand : IRequest
{
    /// <summary>
    /// Hole identifier.
    /// </summary>
    [JsonIgnore]
    public Guid Id { get; init; }
    
    /// <summary>
    /// Hole name.
    /// </summary>
    public string Name { get; init; }
    
    /// <summary>
    /// Hole depth values.
    /// </summary>
    public double Depth { get; init; }
}
