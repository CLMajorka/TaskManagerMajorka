using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Interfaces;

namespace Application.Services
{
    public class UserAccountService : IUserAccountService
    {
        public IUserRepository UserRepository { get; }
        public UserAccountService(IUserRepository userRepository)
        {
            UserRepository = userRepository;
        }

        public User? Create(string userName, string email, UserRole role, string passwordHash)
        {
            UserAccount userAccount = UserAccount.Create(userName, email, role, passwordHash);

            int id;
            try
            {
                id = UserRepository.Create(userAccount);
            }
            catch (InvalidOperationException ex)
            {
                return null;
            }
            return UserRepository.Get(id);
        }
    }
}
