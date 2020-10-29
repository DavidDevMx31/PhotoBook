using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlbumsWebAppMVC.Models
{
    public class AlbumViewModel
    {
        public int Number { get; private set; }
        public string Name { get; private set; }
        public string Author { get; private set; }
        public string CreationDate { get; private set; }

        public AlbumViewModel(int albumId, string albumName, string albumAuthor, DateTime creationDate)
        {
            this.Number = albumId;
            this.Name = albumName;
            this.Author = albumAuthor;
            this.CreationDate = creationDate.ToShortDateString();
        }
    }
}