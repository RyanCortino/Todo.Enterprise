using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using WinformsUI.Common.Options;

namespace WinformsUI.Views;

public partial class SplashView : Form
{
    public SplashView(ILogger<SplashView> logger, IOptions<ApplicationOptions> appOptions)
    {
        _logger = logger;
        _logger.LogInformation("Initializing Splash Form Components.");

        _appOptions = appOptions.Value;

        InitializeComponent();
    }

    private readonly ILogger _logger;

    private readonly ApplicationOptions _appOptions;

    private async void SplashView_Load(object sender, EventArgs e)
    {
        // Load Resources and close when  the default delay is expired and loading has completed.
        await Task.Run(() =>
        {
            _logger.LogInformation("Loading Resources...");

            var loadingTasks = new[]
            {
                Task.Run(() => DefaultSplashScreenDelay()),
                Task.Run(() => LoadResources())
            };

            Task.WaitAll(loadingTasks);
        });

        Close();
    }

    private async Task DefaultSplashScreenDelay()
    {
        await Task.Delay((int)(_appOptions.DefaultSplashScreenDelay * 1000));
    }

    private async Task LoadResources()
    {
        await Task.Delay(5000);
    }
}
