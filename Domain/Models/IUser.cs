    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    /// <summary>
    /// Interfejs segregujący model użytkownika wykorzystywany w różnych kontekstach:
    /// - jako konto w systemie,
    /// - jako osoba związana z projektem/zadaniem/komentarzem.
    /// </summary>
    public interface IUser
    {
        public int UserId { get; }
        public string UserName { get; }
        public string Email { get; }
        public UserRole Role { get; }
    }
}
