using System.Reflection;
using MediatR;

namespace MiningInfo.Api.DependencyModules.MediatR;

/// <summary>
/// MediatR dependency module.
/// </summary>
internal class MediatRModule
{
    /// <summary>
    /// Register database context.
    /// </summary>
    /// <param name="services">Service collection.</param>
    public static void Register(IServiceCollection services)
    {
        services.AddMediatR(Assembly.GetExecutingAssembly());
    }
}
