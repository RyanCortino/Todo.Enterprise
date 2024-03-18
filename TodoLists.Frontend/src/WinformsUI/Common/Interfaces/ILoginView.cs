using WinformsUI.Models;

namespace WinformsUI.Common.Interfaces;

internal interface ILoginView
{
    string EmailAddress { get; set; }

    string Password { get; set; }

    event EventHandler<EventArgs> OnControlUpdated;

    void InitializeView();
}
