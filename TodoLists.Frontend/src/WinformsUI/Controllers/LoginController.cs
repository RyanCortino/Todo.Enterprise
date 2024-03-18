using WinformsUI.Common.Interfaces;
using WinformsUI.Models;

namespace WinformsUI.Controllers;

internal class LoginController
{
    private LoginRequest? _loginRequest;

    private readonly ILoginView _loginView;

    private readonly HttpClient _httpClient;

    public ILoginView GetView => _loginView;

    public LoginController(ILoginView loginView, HttpClient client)
    {
        _loginView = loginView;
        _loginView.OnControlUpdated += HandleControlUpdated;

        _httpClient = client;
    }

    private void HandleControlUpdated(object? sender, EventArgs e)
    {
        _loginRequest = new(Email: _loginView.EmailAddress, Password: _loginView.Password);

        RefreshData();
    }

    public void RefreshData()
    {
        _loginView.EmailAddress = _loginRequest?.Email ?? string.Empty;
        _loginView.Password = _loginRequest?.Password ?? string.Empty;
    }
}
