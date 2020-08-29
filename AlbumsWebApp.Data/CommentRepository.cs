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
            throw new NotImplementedException();
        }
    }
}
