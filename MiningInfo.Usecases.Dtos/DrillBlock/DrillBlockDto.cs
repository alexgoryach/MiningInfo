namespace MiningInfo.Usecases.Dtos.DrillBlock;

/// <summary>
/// Drill block dto with full information.
/// </summary>
public record DrillBlockDto
{
    /// <summary>
    /// Drill block identifier.
    /// </summary>
    public Guid Id { get; init; }
    
    /// <summary>
    /// Drill block name.
    /// </summary>
    public string Name { get; init; }
    
    /// <summary>
    /// Date when drill block info was updated.
    /// </summary>
    public DateTime UpdateDate { get; init; }
}
