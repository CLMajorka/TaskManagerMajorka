using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Application.DTO
{
    public class UserDto
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public UserRole Role { get; set; }
        public string PasswordHash { get; set; }
    }
}
