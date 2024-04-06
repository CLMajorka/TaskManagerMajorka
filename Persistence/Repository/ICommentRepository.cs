using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Persistence.Repository
{
    public interface ICommentRepository : IGenericRepository<Comment>
    {
        Comment Get(int id);
        IEnumerable<Comment> GetAll();
        int Create(Comment model);
        bool Update(Comment model);
        bool Delete(int id);
    }
}
