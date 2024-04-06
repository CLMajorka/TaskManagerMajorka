using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Domain.Models;

namespace Persistence.Repository
{
    public class CommentRepository : ICommentRepository
    {
        private readonly IDapperContext _context;

        public CommentRepository(IDapperContext dapperContext) => _context = dapperContext;


        public Comment Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Comment> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Create(Comment model)
        {
            var sql = "INSERT INTO Comments (TaskId, Text, CreatedBy, CreatedAt, ModifiedBy, ModifiedAt) VALUES (@TaskId, @Text, @CreatedBy, @CreatedAt, @ModifiedBy, @ModifiedAt); SELECT CAST(SCOPE_IDENTITY() AS int)";
            using (var connection = _context.CreateConnection())
            {
                var id = connection.QuerySingle<int>(sql, model);
                return id;
            }
        }

        public bool Update(Comment model)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
