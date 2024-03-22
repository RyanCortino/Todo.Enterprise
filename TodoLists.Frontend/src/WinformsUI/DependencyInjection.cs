using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Winforms;

public static class DependencyInjection
{
    public static IServiceCollection AddDesktopServices(
        this IServiceCollection services,
        IConfiguration configuration
    )
    {
        // Config
        services.Configure<ApplicationOptions>(
            configuration.GetSection(ApplicationOptions.SectionName)
        );

        // Views
        services.AddTransient<ISplashView, SplashForm>();
        services.AddTransient<IMainView, MainForm>();

        // Presenters
        services.AddTransient<SplashPresenter>();

        // Helpers
        services.AddTransient<IFileSystemProvider, WindowsFileSystem>();

        return services;
    }
}
