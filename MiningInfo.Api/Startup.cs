using Microsoft.EntityFrameworkCore;
using MiningInfo.Api.DependencyModules.Database;
using MiningInfo.Api.DependencyModules.MediatR;
using MiningInfo.Infrastructure.DataAccess;

namespace MiningInfo.Api;

/// <summary>
/// Application startup with configurations.
/// </summary>
public class Startup
{
    private readonly IConfiguration configuration;
        
    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="configuration">Configuration.</param>
    public Startup(IConfiguration configuration)
    {
        this.configuration = configuration;
    }

    /// <summary>
    /// Configure services.
    /// </summary>
    /// <param name="services">Services collection.</param>
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();
        
        services.AddDbContext<AppDbContext>(opt =>
            opt.UseNpgsql(configuration.GetConnectionString("PostgreSQLConnection")));

        // Register dependencies.
        DatabaseModule.Register(services);
        MediatRModule.Register(services);

        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
    }
    
    /// <summary>
    /// Application configure.
    /// </summary>
    /// <param name="app">Application.</param>
    /// <param name="env">Host environment.</param>
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseRouting();
        app.UseHttpsRedirection();

        app.UseAuthentication();
        app.UseAuthorization();

        app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
    }
}
