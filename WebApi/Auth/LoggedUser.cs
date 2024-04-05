using Microsoft.Identity.Client;
using Domain.Models;

namespace WebApi.Auth
{
    public class LoggedUser : IUser
    {
        public int UserId { get; }
        public string UserName { get; }
        public string Email { get; }
        public UserRole Role { get; }
    }
}
