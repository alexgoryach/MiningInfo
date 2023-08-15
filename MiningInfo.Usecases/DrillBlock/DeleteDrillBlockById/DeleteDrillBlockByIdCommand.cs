using MediatR;

namespace MiningInfo.Usecases.DrillBlock.DeleteDrillBlockById;

/// <summary>
/// Delete drill block by id command.
/// </summary>
/// <param name="DrillBlockId"></param>
public record DeleteDrillBlockByIdCommand(Guid DrillBlockId) : IRequest;
