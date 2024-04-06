using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class CommentDto
    {
        public string Text { get; set; }
        public int TaskId { get; set; }
        public int LoggedUserId { get; set; }

        public CommentDto(string text, int taskId, int loggedUserId)
        {
            Text = text;
            TaskId = taskId;
            LoggedUserId = loggedUserId;
        }
    }
}
