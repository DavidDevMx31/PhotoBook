using System.Collections.Generic;
using AlbumsWebApp.Domain.Models;

namespace AlbumsWebApp.Domain.RepositoryInterfaces
{
    public interface ICommentRepository
    {
        List<Comment> GetPhotoComments(int photoId);
    }
}
