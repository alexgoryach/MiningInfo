using MediatR;

namespace MiningInfo.Usecases.HolePoint.AddHolePoint;

/// <summary>
/// Add hole point command.
/// </summary>
public record AddHolePointCommand : IRequest<Guid>
{
    /// <summary>
    /// Hole id.
    /// </summary>
    public Guid HoleId { get; init; }
    
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
