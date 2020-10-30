using AlbumsWebApp.Domain.Models;
using AlbumsWebApp.Domain.Presenters;
using AlbumsWebAppMVC.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlbumsWebAppMVC.Presenters
{
    public class PhotoPresenter : IPhotoPresenter
    {
        private PhotoAlbumViewModel photoAlbum;

        public void SetPhotosResponse(Album album, List<Photo> albumPhotos)
        {
            photoAlbum = new PhotoAlbumViewModel(album.Name, album.Author, album.CreationDate);
            
            for (int i = 0; i < albumPhotos.Count; i++)
            {
                photoAlbum.Photos.Add(albumPhotos[i].Id, albumPhotos[i].FileName);
            }
        }

        internal PhotoAlbumViewModel GetAlbumInfo()
        {
            return photoAlbum;
        }
    }
}