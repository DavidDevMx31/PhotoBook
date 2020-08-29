using AlbumsWebApp.Domain.Models;
using System.Collections.Generic;

namespace AlbumsWebApp.Domain.Presenters
{
    public interface IPhotoPresenter
    {
        void SetPhotosResponse(List<Photo> albumPhotos);
    }
}
