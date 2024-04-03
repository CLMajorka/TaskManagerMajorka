using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Users
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public int Role { get; set; }
        public DateTime CreatedAt { get; set; }
        public string PasswordHash { get; set; }
        public DateTime PasswordLastChangedAt { get; set; }
    }
}
