using AlbumsWebApp.Domain.Models;
using System.Collections.Generic;

namespace AlbumsWebApp.Domain.Presenters
{
    public interface IPhotoPresenter
    {
        void SetPhotosResponse(Album album, List<Photo> albumPhotos);
    }
}
