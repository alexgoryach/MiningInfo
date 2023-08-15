using MediatR;

namespace MiningInfo.Usecases.Hole.AddHole;

/// <summary>
/// Add hole command.
/// </summary>
public record AddHoleCommand : IRequest<Guid>
{
    /// <summary>
    /// Hole name.
    /// </summary>
    public string Name { get; init; }
    
    /// <summary>
    /// Drill block id.
    /// </summary>
    public Guid DrillBlockId { get; init; }
    
    /// <summary>
    /// Hole depth values.
    /// </summary>
    public double Depth { get; init; }
}
