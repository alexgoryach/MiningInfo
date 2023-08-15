using MediatR;

namespace MiningInfo.Usecases.Hole.DeleteHoleById;

/// <summary>
/// Delete hole command.
/// </summary>
/// <param name="HoleId"></param>
public record DeleteHoleByIdCommand(Guid HoleId) : IRequest;
