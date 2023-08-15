namespace MiningInfo.Usecases.Dtos.DrillBlock;

/// <summary>
/// Drill block DTO with minimum information.
/// </summary>
public record DrillBlockLightDto
{
    /// <summary>
    /// Drill block identifier.
    /// </summary>
    public Guid Id { get; init; }
    
    /// <summary>
    /// Drill block name.
    /// </summary>
    public string Name { get; init; }
}
