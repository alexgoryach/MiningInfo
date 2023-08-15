using MediatR;
using MiningInfo.Usecases.DrillBlock.AddDrillBlock;

namespace MiningInfo.Api.DependencyModules.MediatR;

/// <summary>
/// MediatR dependency module.
/// </summary>
internal class MediatRModule
{
    /// <summary>
    /// Register MediatR.
    /// </summary>
    /// <param name="services">Service collection.</param>
    public static void Register(IServiceCollection services)
    {
        services.AddMediatR(typeof(AddDrillBlockCommand).Assembly);
    }
}
