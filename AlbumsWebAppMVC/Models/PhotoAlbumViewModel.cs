using System;
using System.Collections.Generic;
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
    }
}