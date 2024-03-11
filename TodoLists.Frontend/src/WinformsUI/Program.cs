using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;

namespace WinformsUI;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // Setup application Host
        IHost host = CreateHostBuilder().Build();

        ServiceProvider = host.Services;

        // Initialize the AppConfig
        Log.Logger.Information("Application Starting.");

        ApplicationConfiguration.Initialize();

        // Run the registered application context
        var appContext = host.Services.GetRequiredService<ApplicationContext>();

        Application.Run(appContext);
    }

    public static IServiceProvider? ServiceProvider { get; private set; }

    static IHostBuilder CreateHostBuilder()
    {
        return Host.CreateDefaultBuilder()
            // Register the app context
            .ConfigureServices(
                (services) => services.AddTransient<ApplicationContext, TodoAppContext>()
            )
            // Registers all other services
            .ConfigureServices(
                (context, services) => services.AddDesktopServices(context.Configuration)
            )
            // Configures Logging
            .UseSerilog(
                (ctx, lc) =>
                    lc.ReadFrom
                        .Configuration(ctx.Configuration)
                        .Enrich.FromLogContext()
                        .WriteTo.Console()
                        .WriteTo.Debug()
            );
    }
}
