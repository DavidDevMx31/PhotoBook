using AlbumsWebApp.Domain.DomainInterfaces;
using AlbumsWebApp.Domain.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumsWebApp.Domain.Implementations
{
    public class CommentInteractor : ICommentInteractor
    {
        private readonly ICommentRepository commentRepository;
        public CommentInteractor(ICommentRepository repository)
        {
            commentRepository = repository ?? throw new ArgumentNullException("commentRepository");
        }
        public void GetCommentsForPhoto(int photoId)
        {
            if (photoId <= 0)
            {
                //Error 
                return;
            }
            var comments = commentRepository.GetPhotoComments(photoId);
        }
    }
}
