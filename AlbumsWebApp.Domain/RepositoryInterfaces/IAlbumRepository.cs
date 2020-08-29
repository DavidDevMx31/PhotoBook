using AlbumsWebApp.Domain.Models;
using System.Collections.Generic;

namespace AlbumsWebApp.Domain.RepositoryInterfaces
{
    public interface IAlbumRepository
    {
        List<Album> GetAlbums();
    }
}
