using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Interfaces;

namespace Application.Services
{
    public interface IUserAccountService
    {
        IUserRepository UserRepository { get; }
        User? Create(string userName, string email, UserRole role, string passwordHash);

    }
}
