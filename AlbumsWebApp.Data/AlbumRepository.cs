using AlbumsWebApp.Domain.Models;
using AlbumsWebApp.Domain.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AlbumsWebApp.Data
{
    public class AlbumRepository : IAlbumRepository
    {
        public List<Album> GetAlbums()
        {
            return CreateAlbumList();
        }
        public Album GetAlbum(int albumId)
        {
            var albums = CreateAlbumList();
            var album = albums.SingleOrDefault(a => a.Id == albumId);
            return album;
        }
        private List<Album> CreateAlbumList()
        {
            var albums = new List<Album>()
            {
                new Album() { Id = 1, Author = "John Doe", Name = "Halloween 2018", CreationDate = new DateTime(2018, 11, 05) },
                new Album() { Id = 2, Author = "Alice Doe", Name = "Mexico", CreationDate = new DateTime(2019, 1, 15) },
                new Album() { Id = 3, Author = "John Doe", Name = "City", CreationDate = new DateTime(2019, 3, 25) },
                new Album() { Id = 4, Author = "John Doe", Name = "Landscapes", CreationDate = new DateTime(2019, 4, 05) },
                new Album() { Id = 5, Author = "Alice Doe", Name = "Night shots", CreationDate = new DateTime(2019, 5, 18) },
            };

            return albums;
        }
    }
}
