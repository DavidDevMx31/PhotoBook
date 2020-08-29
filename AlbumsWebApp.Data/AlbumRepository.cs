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
            var albums = new List<Album>();
            
            for (int i = 0; i < 10; i++)
            {
                var album = new Album()
                {
                    Id = i,
                    Name = $"Album {i}",
                    Author = "The Rolling",
                    ReleaseDate = new DateTime(2000,01,01)
                };
                albums.Add(album);
            }
            return albums;
        }
    }
}
