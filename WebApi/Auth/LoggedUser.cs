using Domain.Models;

namespace WebApi.Auth
{
    public class LoggedUser : IUser
    {
        public int UserId { get; }
        public string UserName { get; }
        public string Email { get; }
        public UserRole Role { get; }

        public LoggedUser(int userId, string userName, string email, UserRole role)
        {
            UserId = userId;
            UserName = userName;
            Email = email;
            Role = role;
        }
    }
}
