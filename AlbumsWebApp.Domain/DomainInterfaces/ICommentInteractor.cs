using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumsWebApp.Domain.DomainInterfaces
{
    public interface ICommentInteractor
    {
        void GetCommentsForPhoto(int photoId);
    }
}
