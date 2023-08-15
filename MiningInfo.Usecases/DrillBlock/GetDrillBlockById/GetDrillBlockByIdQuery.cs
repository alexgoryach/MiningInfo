using MediatR;
using MiningInfo.Usecases.Dtos.DrillBlock;

namespace MiningInfo.Usecases.DrillBlock.GetDrillBlockById;

/// <summary>
/// Get drill block by id query.
/// </summary>
/// <param name="DrillBlockId">Drill block identifier.</param>
public record GetDrillBlockByIdQuery(Guid DrillBlockId) : IRequest<DrillBlockDto>;
