namespace MiningInfo.Usecases.Dtos.Hole;

/// <summary>
/// Hole DTO with minimum information.
/// </summary>
public class HoleLightDto
{
    /// <summary>
    /// Hole identifier.
    /// </summary>
    public Guid Id { get; init; }
    
    /// <summary>
    /// Hole name.
    /// </summary>
    public string Name { get; init; }
}
