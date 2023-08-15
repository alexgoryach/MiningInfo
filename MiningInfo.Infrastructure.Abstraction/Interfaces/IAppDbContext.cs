using Microsoft.EntityFrameworkCore;
using MiningInfo.Domain.Entities.Drill;
using MiningInfo.Domain.Entities.Hole;

namespace MiningInfo.Infrastructure.Abstraction.Interfaces;

/// <summary>
/// Application database context abstraction.
/// </summary>
public interface IAppDbContext
{
    #region Drill

    /// <summary>
    /// Drill blocks data.
    /// </summary>
    DbSet<DrillBlock> DrillBlocks { get; }
    
    /// <summary>
    /// Drill block points data.
    /// </summary>
    DbSet<DrillBlockPoint> DrillBlockPoints { get; }

    #endregion
    
    #region Hole

    /// <summary>
    /// Holes data.
    /// </summary>
    DbSet<Hole> Holes { get; }
    
    /// <summary>
    /// Hole points data.
    /// </summary>
    DbSet<HolePoint> HolePoints { get; }

    #endregion

    /// <summary>
    /// Save changes.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token.</param>
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
