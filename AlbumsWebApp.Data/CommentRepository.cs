using AlbumsWebApp.Domain.Models;
using AlbumsWebApp.Domain.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumsWebApp.Data
{
    public class CommentRepository : ICommentRepository
    {
        public List<Comment> GetPhotoComments(int photoId)
        {
            var comments = new List<Comment>();
            for (int i = 0; i < 5; i++)
            {
                var comment = new Comment()
                {
                    Id = 1,
                    Date = new DateTime(2020, 01, i),
                    Description = "Amazing!",
                    User = $"User {i}"
                };
                comments.Add(comment);
            }
            return comments;
        }
    }
}
