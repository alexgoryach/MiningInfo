using MediatR;
using MiningInfo.Usecases.Dtos.DrillBlock;

namespace MiningInfo.Usecases.DrillBlock.GetDrillBlockById;

public record GetDrillBlockByIdQuery(Guid DrillBlockId) : IRequest<DrillBlockDto>;
