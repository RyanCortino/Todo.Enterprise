using Application.Models;

namespace WinformsUI.Presenters;

public class LoginPresenter
{
    private LoginModel _model;

    private readonly HttpClient _httpClient;

    public ILoginView View { get; }

    public LoginPresenter(ILoginView loginView, HttpClient client)
    {
        View = loginView;
        View.OnControlUpdated += UserInputUpdated;

        _httpClient = client;

        _model = new(string.Empty, string.Empty);
    }

    public async Task LoadView()
    {
        await View.InitializeViewAsync();
    }

    private void UserInputUpdated(object? sender, EventArgs e)
    {
        _model = _model with { };

        RefreshData();
    }

    public void RefreshData()
    {
        View.EmailAddress = _model.Email;
        View.Password = _model.Password;
    }
}
