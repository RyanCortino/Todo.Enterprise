namespace Application.Common.Interfaces;

public interface ILoginView
{
    string EmailAddress { get; set; }

    string Password { get; set; }

    event EventHandler<EventArgs> OnControlUpdated;

    Task InitializeViewAsync();
}
