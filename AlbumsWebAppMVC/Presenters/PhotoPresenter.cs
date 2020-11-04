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

        public void SetPhotosForAlbumResponse(Album album, List<Photo> albumPhotos)
        {
            photoAlbum = new PhotoAlbumViewModel(album.Name, album.Author, album.CreationDate);
            FillViewModelPhotos(albumPhotos);
        }

        public void SetPhotosResponse(List<Photo> photos)
        {
            photoAlbum = new PhotoAlbumViewModel("", "Varios", null);
            FillViewModelPhotos(photos);
        }

        private void FillViewModelPhotos(List<Photo> photos)
        {
            for (int i = 0; i < photos.Count; i++)
            {
                photoAlbum.Photos.Add(photos[i].Id, photos[i].FileName);
            }
        }

        internal PhotoAlbumViewModel GetAlbumInfo()
        {
            return photoAlbum;
        }
    }
}