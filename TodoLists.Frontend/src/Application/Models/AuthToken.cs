namespace Application.Models;

internal record AuthToken(
    string TokenType,
    string AccessToken,
    long ExpiresIn,
    string RefreshToken
) { }
