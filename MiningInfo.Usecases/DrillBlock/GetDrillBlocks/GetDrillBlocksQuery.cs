using MediatR;
using MiningInfo.Usecases.Dtos.DrillBlock;

namespace MiningInfo.Usecases.DrillBlock.GetDrillBlocks;

/// <summary>
/// Get drill blocks query.
/// </summary>
public record GetDrillBlocksQuery : IRequest<List<DrillBlockLightDto>>;
