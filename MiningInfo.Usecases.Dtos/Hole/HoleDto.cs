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
    public Guid Id { get; set; }
    
    /// <summary>
    /// Hole name.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Drill block.
    /// </summary>
    public DrillBlockLightDto DrillBlock { get; set; }
    
    /// <summary>
    /// Hole depth values.
    /// </summary>
    public double Depth { get; set; }
}
