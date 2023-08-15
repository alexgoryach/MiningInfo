using MiningInfo.Usecases.Dtos.DrillBlock;

namespace MiningInfo.Usecases.Dtos.DrillBlockPoint;

/// <summary>
/// Drill block point DTO. 
/// </summary>
public record DrillBlockPointDto
{
    /// <summary>
    /// Point identifier.
    /// </summary>
    public Guid Id { get; init; }

    /// <summary>
    /// Drill block.
    /// </summary>
    public DrillBlockLightDto DrillBlock { get; init; }

    /// <summary>
    /// Point sequence.
    /// </summary>
    public int Sequence { get; init; }
    
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
