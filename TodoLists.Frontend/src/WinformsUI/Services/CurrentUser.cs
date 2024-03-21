namespace WinformsUI.Services;

internal class CurrentUser : IUser
{
    public string? AuthToken { get; set; }

    public string? UserName { get; set; }
}
