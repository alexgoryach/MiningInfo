namespace MiningInfo.Domain.Entities.Hole;

/// <summary>
/// Hole point entity.
/// </summary>
public class HolePoint
{
    /// <summary>
    /// Hole point identifier.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Hole id.
    /// </summary>
    public Guid HoleId { get; set; }

    /// <summary>
    /// Hole.
    /// </summary>
    public Hole Hole { get; set; }
    
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
