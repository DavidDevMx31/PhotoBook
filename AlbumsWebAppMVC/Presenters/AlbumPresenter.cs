using AlbumsWebApp.Domain.Models;
using AlbumsWebApp.Domain.Presenters;
using AlbumsWebAppMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlbumsWebAppMVC.Presenters
{
    public class AlbumPresenter : IAlbumPresenter
    {
        private List<AlbumViewModel> albums = new List<AlbumViewModel>();
        public void SetAlbumResponse(List<Album> albumList)
        {
            foreach (var album in albumList)
            {
                albums.Add(new AlbumViewModel(album.Id, album.Name, album.Author, album.CreationDate));
            }
        }

        internal List<AlbumViewModel> GetItems() 
        {
            return albums;
        }
    }
}