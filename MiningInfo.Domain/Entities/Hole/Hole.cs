using MiningInfo.Domain.Entities.Drill;

namespace MiningInfo.Domain.Entities.Hole;

/// <summary>
/// Hole entity.
/// </summary>
public class Hole
{
    /// <summary>
    /// Hole identifier.
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Hole name.
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Drill block id.
    /// </summary>
    public Guid DrillBlockId { get; set; }

    /// <summary>
    /// Drill block.
    /// </summary>
    public DrillBlock DrillBlock { get; set; }
    
    /// <summary>
    /// Hole depth values.
    /// </summary>
    public double Depth { get; set; }
}
