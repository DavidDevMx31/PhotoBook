using AlbumsWebApp.Domain.DomainInterfaces;
using AlbumsWebApp.Domain.RepositoryInterfaces;
using System;

namespace AlbumsWebApp.Domain.Implementations
{
    public class PhotoInteractor : IPhotoInteractor
    {
        private readonly IPhotoRepository photoRepository;
        public PhotoInteractor(IPhotoRepository repository)
        {
            photoRepository = repository ?? throw new ArgumentNullException("photoRepository");
        }
        public void GetPhotosForAlbum(int albumId)
        {
            if (albumId <= 0)
            { 
                //Error
                return;
            }
            var photos = photoRepository.GetAlbumPhotos(albumId);
        }
    }
}
