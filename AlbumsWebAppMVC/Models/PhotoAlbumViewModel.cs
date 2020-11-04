using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;

namespace AlbumsWebAppMVC.Models
{
    public class PhotoAlbumViewModel
    {
        public string Name  { get; private set; }
        public string Author { get; private set; }
        public string CreationDate { get; private set; }
        public Dictionary<int, string> Photos { get; private set; }

        public PhotoAlbumViewModel(string name, string author, DateTime? creationDate)
        {
            Name = name;
            Author = author;
            CreationDate = creationDate.HasValue ? 
                $"Creado el: {creationDate.Value.ToShortDateString()}" : 
                string.Empty;
            Photos = new Dictionary<int, string>();
        }

        public void AddPhotoToAlbum(int photoId, string photoUrl)
        {
            Photos.Add(photoId, photoUrl);
        }
    }
}