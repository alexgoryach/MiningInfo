using MiningInfo.Infrastructure.Abstraction.Interfaces;
using MiningInfo.Infrastructure.DataAccess;

namespace MiningInfo.Api.DependencyModules.Database;

/// <summary>
/// Database dependency module.
/// </summary>
internal class DatabaseModule
{
    /// <summary>
    /// Register database context.
    /// </summary>
    /// <param name="services">Service collection.</param>
    public static void Register(IServiceCollection services)
    {
        services.AddScoped<IAppDbContext, AppDbContext>();
    }
}
