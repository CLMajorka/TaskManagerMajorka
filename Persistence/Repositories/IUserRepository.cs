using Domain.Models;
using Persistence.Repository;

namespace WebApi.Interfaces
{
    public interface IUserRepository : IGenericRepository<IUser>
    {
        User Get(int id);
        IEnumerable<IUser> GetAll();
        int Create(IUser model);
        bool Update(IUser model); 
        bool Delete(int id);

        Task<User?> Authenticate(string username, string password);
    }
}
