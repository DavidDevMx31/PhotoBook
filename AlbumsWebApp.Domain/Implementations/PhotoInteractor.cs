using AlbumsWebApp.Domain.DomainInterfaces;
using AlbumsWebApp.Domain.Models;
using AlbumsWebApp.Domain.Presenters;
using AlbumsWebApp.Domain.RepositoryInterfaces;
using System;

namespace AlbumsWebApp.Domain.Implementations
{
    public class PhotoInteractor : IPhotoInteractor
    {
        private readonly IPhotoRepository photoRepository;
        private readonly IAlbumRepository albumRepository;
        public PhotoInteractor(IPhotoRepository repository, IAlbumRepository albumRepository)
        {
            photoRepository = repository ?? throw new ArgumentNullException("photoRepository");
            this.albumRepository = albumRepository ?? throw new ArgumentNullException("albumRepository");
        }

        public void GetAllPhotos(IPhotoPresenter presenter)
        {
            var photos = photoRepository.GetAllPhotos();
            presenter.SetPhotosResponse(photos);
        }

        public void GetPhotosForAlbum(int albumId, IPhotoPresenter presenter)
        {
            if (albumId <= 0)
            { 
                return;
            }
            var album = albumRepository.GetAlbum(albumId);
            var photos = photoRepository.GetAlbumPhotos(albumId);
            presenter.SetPhotosForAlbumResponse(album, photos);
        }
    }
}
