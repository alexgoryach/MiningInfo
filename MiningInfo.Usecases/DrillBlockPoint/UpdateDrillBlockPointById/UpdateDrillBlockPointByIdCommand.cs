using System.Text.Json.Serialization;
using MediatR;

namespace MiningInfo.Usecases.DrillBlockPoint.UpdateDrillBlockPointById;

/// <summary>
/// Update drill block point by id command.
/// </summary>
public record UpdateDrillBlockPointByIdCommand : IRequest
{
    /// <summary>
    /// Drill block point identifier.
    /// </summary>
    [JsonIgnore]
    public Guid Id { get; init; }
    
    /// <summary>
    /// Point sequence.
    /// </summary>
    public int? Sequence { get; init; }
    
    /// <summary>
    /// Point X coordinate.
    /// </summary>
    public double? X { get; init; }
    
    /// <summary>
    /// Point Y coordinate.
    /// </summary>
    public double? Y { get; init; }
    
    /// <summary>
    /// Point Z coordinate.
    /// </summary>
    public double? Z { get; init; }
}
