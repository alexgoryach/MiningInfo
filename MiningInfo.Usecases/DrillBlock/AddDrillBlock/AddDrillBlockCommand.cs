using MediatR;

namespace MiningInfo.Usecases.DrillBlock.AddDrillBlock;

/// <summary>
/// Add drill block command.
/// </summary>
public record AddDrillBlockCommand : IRequest<Guid>
{
    /// <summary>
    /// Drill block name.
    /// </summary>
    public string Name { get; init; }
}
