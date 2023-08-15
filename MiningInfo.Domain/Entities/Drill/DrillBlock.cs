namespace MiningInfo.Domain.Entities.Drill;

/// <summary>
/// Drill block entity.
/// </summary>
public class DrillBlock
{
    /// <summary>
    /// Drill block identifier.
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Drill block name.
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Date when drill block info was updated.
    /// </summary>
    public DateTime UpdateDate { get; set; }
}
