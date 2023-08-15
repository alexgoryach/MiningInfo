using MediatR;
using MiningInfo.Usecases.Dtos.HolePoint;

namespace MiningInfo.Usecases.HolePoint.GetHolePoints;

/// <summary>
/// Get hole points query.
/// </summary>
/// <param name="HoleId">Hole id filter (if needed).</param>
public record GetHolePointsQuery(Guid? HoleId) : IRequest<List<HolePointDto>>;
