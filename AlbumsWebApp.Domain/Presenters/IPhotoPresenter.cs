using AlbumsWebApp.Domain.Models;
using System.Collections.Generic;

namespace AlbumsWebApp.Domain.Presenters
{
    public interface IPhotoPresenter
    {
        void SetPhotosResponse(List<Photo> photos);
        void SetPhotosForAlbumResponse(Album album, List<Photo> albumPhotos);
    }
}
