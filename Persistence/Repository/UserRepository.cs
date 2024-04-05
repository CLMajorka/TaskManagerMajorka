using Domain.Models;
using Persistence.Context;
using Persistence.Repository;
using WebApi.Interfaces;
using static Dapper.SqlMapper;

namespace WebApi.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IDapperContext _dapperContext;

        public UserRepository(IDapperContext dapperContext) => _dapperContext = dapperContext;

        public User Get(int id)
        {
            throw new NotImplementedException();
        }

        IUser IGenericRepository<IUser>.Get(int id)
        {
            return Get(id);
        }

        public IEnumerable<IUser> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Create(IUser model)
        {
            var sql = "INSERT INTO Users (UserId, UserName, Email, Role, CreatedAt, PasswordHash) VALUES ((SELECT ISNULL(MAX(UserId) + 1, 0) FROM Users), @UserName, @Email, @Role, @CreatedAt, @PasswordHash); SELECT CAST(SCOPE_IDENTITY() AS int)";
            using (var connection = _dapperContext.CreateConnection())
            {
                var id = connection.QuerySingle<int>(sql, model);
                return id;
            }
        }

        public bool Update(IUser model)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
