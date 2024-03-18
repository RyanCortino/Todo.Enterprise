using WinformsUI.Common.Interfaces;

namespace WinformsUI.Views;

public partial class DeveloperConsole : Form, ILoginView
{
    public DeveloperConsole()
    {
        InitializeComponent();
    }

    public string EmailAddress
    {
        get => EmailActual.Text;
        set => EmailActual.Text = value;
    }

    public string Password
    {
        get => PasswordActual.Text;
        set => PasswordActual.Text = value;
    }

    public event EventHandler<EventArgs>? OnControlUpdated;

    public void InitializeView()
    {
        this.Show();
    }

    private void EmailActual_Leave(object sender, EventArgs e) =>
        OnControlUpdated?.Invoke(sender, e);

    private void PasswordActual_Leave(object sender, EventArgs e) =>
        OnControlUpdated?.Invoke(sender, e);
}
