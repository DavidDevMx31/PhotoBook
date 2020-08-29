using AlbumsWebApp.Domain.Models;
using AlbumsWebApp.Domain.Presenters;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlbumsWebAppMVC.Presenters
{
    public class PhotoPresenter : IPhotoPresenter
    {
        private Dictionary<int, string> photos;

        public void SetPhotosResponse(List<Photo> albumPhotos)
        {
            photos = new Dictionary<int, string>();
            for (int i = 0; i < albumPhotos.Count; i++)
            {
                photos.Add(albumPhotos[i].Id, albumPhotos[i].Description);
            }
        }

        internal Dictionary<int, string> GetAlbumPhotos()
        {
            return photos;
        }
    }
}