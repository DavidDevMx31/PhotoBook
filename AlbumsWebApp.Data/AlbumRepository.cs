using AlbumsWebApp.Domain.Models;
using AlbumsWebApp.Domain.RepositoryInterfaces;
using System;
using System.Collections.Generic;

namespace AlbumsWebApp.Data
{
    public class AlbumRepository : IAlbumRepository
    {
        public List<Album> GetAlbums()
        {
            throw new NotImplementedException();
        }
    }
}
