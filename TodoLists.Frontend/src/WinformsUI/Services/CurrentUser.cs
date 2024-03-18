using WinformsUI.Common.Interfaces;

namespace WinformsUI.Services;

internal class CurrentUser : IUser
{
    public string? JwtToken { get; set; }
}
