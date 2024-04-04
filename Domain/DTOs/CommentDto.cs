using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class CommentDto
    {
       public int TaskId { get; }
        public string Text { get; private set; }
        public User LoggedUser { get; }

        public CommentDto(int taskId, string text, User loggedUser)
        {
            TaskId = taskId;
            Text = text;
            LoggedUser = loggedUser;
        }
    }
}
