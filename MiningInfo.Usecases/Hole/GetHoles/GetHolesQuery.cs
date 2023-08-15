using MediatR;
using MiningInfo.Usecases.Dtos.Hole;

namespace MiningInfo.Usecases.Hole.GetHoles;

/// <summary>
/// Get holes query.
/// </summary>
/// <param name="DrillBlockId">Search by drill block(if needed).</param>
public record GetHolesQuery(Guid? DrillBlockId) : IRequest<List<HoleDto>>;
