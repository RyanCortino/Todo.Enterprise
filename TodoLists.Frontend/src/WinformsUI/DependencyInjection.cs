using Microsoft.Extensions.Configuration;
using WinformsUI.Common;
using WinformsUI.Common.Options;

namespace Microsoft.Extensions.DependencyInjection;

internal static class DependencyInjection
{
    public static IServiceCollection AddDesktopServices(
        this IServiceCollection services,
        IConfiguration configuration
    )
    {
        services.Configure<ApplicationOptions>(
            configuration.GetSection(ApplicationOptions.SectionName)
        );

        services.AddTransient<SplashView>();

        //services.AddTransient<BaseMdiForm>();

        return services;
    }
}
