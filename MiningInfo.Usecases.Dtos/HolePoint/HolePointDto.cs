using MiningInfo.Usecases.Dtos.Hole;

namespace MiningInfo.Usecases.Dtos.HolePoint;

/// <summary>
/// Hole point DTO.
/// </summary>
public class HolePointDto
{
    /// <summary>
    /// Hole point identifier.
    /// </summary>
    public Guid Id { get; init; }

    /// <summary>
    /// Hole.
    /// </summary>
    public HoleLightDto Hole { get; init; }
    
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
