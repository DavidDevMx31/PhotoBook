using AlbumsWebApp.Domain.DomainInterfaces;
using AlbumsWebApp.Domain.Presenters;
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
        public void GetPhotosForAlbum(int albumId, IPhotoPresenter presenter)
        {
            if (albumId <= 0)
            { 
                return;
            }
            var photos = photoRepository.GetAlbumPhotos(albumId);
            presenter.SetPhotosResponse(photos);
        }
    }
}
