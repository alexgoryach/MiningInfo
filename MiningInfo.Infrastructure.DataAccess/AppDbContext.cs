using Microsoft.EntityFrameworkCore;
using MiningInfo.Domain.Entities.Drill;
using MiningInfo.Domain.Entities.Hole;
using MiningInfo.Infrastructure.Abstraction.Interfaces;

namespace MiningInfo.Infrastructure.DataAccess;

/// <summary>
/// Application database context.
/// </summary>
public class AppDbContext : DbContext, IAppDbContext
{
    #region Drill

    /// <summary>
    /// Drill blocks data.
    /// </summary>
    public DbSet<DrillBlock> DrillBlocks { get; set; }
    
    /// <summary>
    /// Drill block points data.
    /// </summary>
    public DbSet<DrillBlockPoint> DrillBlockPoints { get; set; }

    #endregion

    #region Hole

    /// <summary>
    /// Holes data.
    /// </summary>
    public DbSet<Hole> Holes { get; set; }
    
    /// <summary>
    /// Hole points data.
    /// </summary>
    public DbSet<HolePoint> HolePoints { get; set; }

    #endregion

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
        Database.EnsureCreated();
    }
}
