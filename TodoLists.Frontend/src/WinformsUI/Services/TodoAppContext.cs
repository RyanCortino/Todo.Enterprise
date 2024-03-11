using Microsoft.Extensions.Logging;
using WinformsUI.Common;

namespace WinformsUI.Services;

internal class TodoAppContext(
    ILogger<TodoAppContext> logger,
    SplashView splashView
//BaseMdiForm mdiForm
) : ApplicationContext(splashView)
{
    private readonly ILogger _logger = logger;

    //private readonly BaseMdiForm _mdiForm = mdiForm;

    protected override void OnMainFormClosed(object? sender, EventArgs e)
    {
        if (sender is SplashView)
        {
            //MainForm = _mdiForm;

            MainForm?.Show();

            return;
        }

        _logger.LogInformation("Exiting Application.");

        base.OnMainFormClosed(sender, e);
    }
}
