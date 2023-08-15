using MediatR;

namespace MiningInfo.Usecases.DrillBlockPoint.AddDrillBlockPoint;

/// <summary>
/// Add drill block point command.
/// </summary>
public record AddDrillBlockPointCommand : IRequest<Guid>
{
    /// <summary>
    /// Drill block id.
    /// </summary>
    public Guid DrillBlockId { get; set; }

    /// <summary>
    /// Point sequence.
    /// </summary>
    public int Sequence { get; set; }
    
    /// <summary>
    /// Point X coordinate.
    /// </summary>
    public double X { get; set; }
    
    /// <summary>
    /// Point Y coordinate.
    /// </summary>
    public double Y { get; set; }
    
    /// <summary>
    /// Point Z coordinate.
    /// </summary>
    public double Z { get; set; }
}
