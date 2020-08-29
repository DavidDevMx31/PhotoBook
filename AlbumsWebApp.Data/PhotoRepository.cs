using AlbumsWebApp.Domain.Models;
using AlbumsWebApp.Domain.RepositoryInterfaces;
using System.Collections.Generic;

namespace AlbumsWebApp.Data
{
    public class PhotoRepository : IPhotoRepository
    {
        public List<Photo> GetAlbumPhotos(int albumId)
        {
            throw new System.NotImplementedException();
        }
    }
}
