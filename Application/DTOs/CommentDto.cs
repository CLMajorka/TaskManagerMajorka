using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class CommentDto
    {
        public string Text { get; private set; }
        public int? TaskId { get; set; }
        public int? UserId { get; set; }

        public CommentDto(string text)
        {
            Text = text;
        }
    }
}
