using AlbumsWebApp.Domain.Models;
using AlbumsWebApp.Domain.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlbumsWebAppMVC.Presenters
{
    public class AlbumPresenter : IAlbumPresenter
    {
        private List<SelectListItem> items;
        public void SetAlbumResponse(List<Album> albums)
        {
            items = new List<SelectListItem>();
            for (int i = 0; i < albums.Count; i++)
            {
                var item = new SelectListItem() { 
                    Text = $"{albums[i].Name} by {albums[i].Author}", 
                    Value = albums[i].Id.ToString() };
                items.Add(item);
            }
        }

        internal List<SelectListItem> GetItems() 
        {
            return items;
        }
    }
}