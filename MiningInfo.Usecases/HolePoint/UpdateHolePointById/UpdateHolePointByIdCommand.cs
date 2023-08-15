using System.Text.Json.Serialization;
using MediatR;

namespace MiningInfo.Usecases.HolePoint.UpdateHolePointById;

/// <summary>
/// Update hole point by id command.
/// </summary>
public record UpdateHolePointByIdCommand : IRequest
{
    /// <summary>
    /// Hole point identifier.
    /// </summary>
    [JsonIgnore]
    public Guid Id { get; init; }

    /// <summary>
    /// Point X coordinate.
    /// </summary>
    public double X { get; init; }
    
    /// <summary>
    /// Point Y coordinate.
    /// </summary>
    public double Y { get; init; }
    
    /// <summary>
    /// Point Z coordinate.
    /// </summary>
    public double Z { get; init; }
}
