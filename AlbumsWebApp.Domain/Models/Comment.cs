using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumsWebApp.Domain.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string User { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}
