using MediatR;
using MiningInfo.Usecases.Dtos.DrillBlockPoint;

namespace MiningInfo.Usecases.DrillBlockPoint.GetDrillBlockPoints;

/// <summary>
/// Get drill block points.
/// </summary>
/// <param name="DrillBlockId">Drill block identifier (if needs).</param>
public record GetDrillBlockPointsQuery(Guid? DrillBlockId) : IRequest<List<DrillBlockPointDto>>;
