namespace MiningInfo.Api;

/// <summary>
/// Application start class.
/// </summary>
public class Program
{
    /// <summary>
    /// Application entry point.
    /// </summary>
    /// <param name="args">Arguments.</param>
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    /// <summary>
    /// Host creation.
    /// </summary>
    /// <param name="args">Arguments.</param>
    /// <returns>Host.</returns>
    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
}
