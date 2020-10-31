using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumsWebApp.Domain.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public string Description  { get; set; }
        public string FileName { get; set; }
        public int AlbumId { get; set; }
    }
}
