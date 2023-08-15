using MiningInfo.Usecases.Dtos.DrillBlock;

namespace MiningInfo.Usecases.Dtos.Hole;

/// <summary>
/// Hole DTO.
/// </summary>
public record HoleDto
{
    /// <summary>
    /// Hole identifier.
    /// </summary>
    public Guid Id { get; init; }
    
    /// <summary>
    /// Hole name.
    /// </summary>
    public string Name { get; init; }

    /// <summary>
    /// Drill block.
    /// </summary>
    public DrillBlockLightDto DrillBlock { get; init; }
    
    /// <summary>
    /// Hole depth values.
    /// </summary>
    public double Depth { get; init; }
}
