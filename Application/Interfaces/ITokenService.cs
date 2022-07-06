using Domain;

namespace Application.Interfaces;

public interface ITokenService
{
    public string CreateToken(User user);
    public RefreshToken CreateRefreshToken();
    public Task SetRefreshToken(User user);
}