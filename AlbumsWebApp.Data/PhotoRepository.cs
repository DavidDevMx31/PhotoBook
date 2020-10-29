using AlbumsWebApp.Domain.Models;
using AlbumsWebApp.Domain.RepositoryInterfaces;
using System.Collections.Generic;

namespace AlbumsWebApp.Data
{
    public class PhotoRepository : IPhotoRepository
    {
        public List<Photo> GetAlbumPhotos(int albumId)
        {
            var photos = new List<Photo>();
            for (int i = 0; i < 8; i++)
            {
                var photo = new Photo() { Id = i, Description = $"Photo number {i}", FileName = string.Empty };
                photos.Add(photo);
            }
            return photos;
        }
    }
}
