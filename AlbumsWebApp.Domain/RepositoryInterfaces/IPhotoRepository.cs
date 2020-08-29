using System.Collections.Generic;
using AlbumsWebApp.Domain.Models;

namespace AlbumsWebApp.Domain.RepositoryInterfaces
{
    public interface IPhotoRepository
    {
        List<Photo> GetAlbumPhotos(int albumId);
    }
}
