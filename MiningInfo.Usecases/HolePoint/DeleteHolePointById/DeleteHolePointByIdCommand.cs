using MediatR;

namespace MiningInfo.Usecases.HolePoint.DeleteHolePointById;

/// <summary>
/// Delete hole point command.
/// </summary>
/// <param name="HolePointId">Hole point identifier.</param>
public record DeleteHolePointByIdCommand(Guid HolePointId) : IRequest;
