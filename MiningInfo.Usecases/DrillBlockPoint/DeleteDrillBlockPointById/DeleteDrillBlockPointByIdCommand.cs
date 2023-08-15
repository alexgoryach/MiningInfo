using MediatR;

namespace MiningInfo.Usecases.DrillBlockPoint.DeleteDrillBlockPointById;

/// <summary>
/// Delete drill block point by id command.
/// </summary>
/// <param name="DrillBlockPointId">Drill block point id.</param>
public record DeleteDrillBlockPointByIdCommand(Guid DrillBlockPointId) : IRequest;
