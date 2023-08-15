using MiningInfo.Usecases.DrillBlock;

namespace MiningInfo.Api.DependencyModules.AutoMapper;

/// <summary>
/// Automapper dependency module.
/// </summary>
internal class AutoMapperModule
{
    /// <summary>
    /// Register AutoMapper.
    /// </summary>
    /// <param name="services">Service collection.</param>
    public static void Register(IServiceCollection services)
    {
        services.AddAutoMapper(typeof(DrillBlockMappingProfile));
    }
}
