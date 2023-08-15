namespace MiningInfo.Domain.Entities.Drill;  

/// <summary>
/// Drill block geographical point entity.
/// </summary>
public class DrillBlockPoint
{
    /// <summary>
    /// Point identifier.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Drill block id.
    /// </summary>
    public Guid DrillBlockId { get; set; }

    /// <summary>
    /// Drill block.
    /// </summary>
    public DrillBlock DrillBlock { get; set; }

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
