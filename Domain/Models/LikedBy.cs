using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class LikedBy
    {
        public int CommentId { get; set; }
        public int UserId { get; set; }
    }
}
