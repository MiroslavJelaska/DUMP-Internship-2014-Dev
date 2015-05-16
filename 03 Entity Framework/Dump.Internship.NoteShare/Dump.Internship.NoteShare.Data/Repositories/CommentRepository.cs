using System;
using System.Linq;

namespace Dump.Internship.NoteShare.Data.Repositories
{
    public class CommentRepository
    {
        public void Create(Comment comment)
        {
            using (var context = new NoteShareEntities())
            {
                comment.CreatedOn = DateTime.Now;
                comment.User = context.Users.First();

                context.Comments.Add(comment);
                context.SaveChanges();
            }
        }
    }
}
