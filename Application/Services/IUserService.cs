using Domain.Models;

namespace Application.Services;

public interface IUserService
{
    Task<User?> Authenticate(string username, string password);
}