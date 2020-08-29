using AlbumsWebApp.Domain.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumsWebApp.Domain.Presenters
{
    public interface IAlbumPresenter
    {
        void SetAlbumResponse(List<Album> albums);
    }
}
