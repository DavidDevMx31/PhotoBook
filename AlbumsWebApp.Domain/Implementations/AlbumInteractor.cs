using AlbumsWebApp.Domain.DomainInterfaces;
using AlbumsWebApp.Domain.RepositoryInterfaces;
using System;

namespace AlbumsWebApp.Domain.Implementations
{
    public class AlbumInteractor : IAlbumInteractor
    {
        private readonly IAlbumRepository albumRepository;
        public AlbumInteractor(IAlbumRepository repository)
        {
            albumRepository = repository ?? throw new ArgumentNullException("albumRepository");
        }
        public void GetAlbums()
        {
            var albums = albumRepository.GetAlbums();
        }
    }
}
