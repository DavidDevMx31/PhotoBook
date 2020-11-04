using AlbumsWebApp.Domain.Models;
using AlbumsWebApp.Domain.RepositoryInterfaces;
using System.Collections.Generic;
using System.Linq;

namespace AlbumsWebApp.Data
{
    public class PhotoRepository : IPhotoRepository
    {
        private static List<Photo> allPhotos = new List<Photo>()
            {
                //Halloween
                new Photo() { Id = 1, Description = "Photo by <a href=\"https://unsplash.com/@paige_cody?utm_source=unsplash&amp;utm_medium=referral&amp;utm_content=creditCopyText\">Paige Cody</a>", FileName = "https://source.unsplash.com/hiuBsBPPquE", AlbumId = 1 },
                new Photo() { Id = 2, Description = "Photo by <a href=\"https://unsplash.com/@heftiba?utm_source=unsplash&amp;utm_medium=referral&amp;utm_content=creditCopyText\">Toa Heftiba</a>", FileName = "https://source.unsplash.com/ZWKNDOjwito", AlbumId = 1 },
                //Mexico
                new Photo() { Id = 3, Description = "Photo by <a href=\"https://unsplash.com/@filipovsky?utm_source=unsplash&amp;utm_medium=referral&amp;utm_content=creditCopyText\">Filip Gielda</a>", FileName = "https://source.unsplash.com/VPavA7BBxK0", AlbumId = 2 },
                new Photo() { Id = 4, Description = "Photo by <a href=\"https://unsplash.com/@david_carballar?utm_source=unsplash&amp;utm_medium=referral&amp;utm_content=creditCopyText\">David Carballar</a>", FileName = "https://source.unsplash.com/FZU-vIW-lk8", AlbumId = 2 },
                new Photo() { Id = 5, Description = "Photo by <a href=\"https://unsplash.com/@ig_vlz?utm_source=unsplash&amp;utm_medium=referral&amp;utm_content=creditCopyText\">Ignacio Velez</a>", FileName = "https://source.unsplash.com/YE455n356n8", AlbumId = 2 },
                //City
                new Photo() { Id = 6, Description = "Photo by <a href=\"https://unsplash.com/@devintavery?utm_source=unsplash&amp;utm_medium=referral&amp;utm_content=creditCopyText\">Devin Avery</a>", FileName = "https://source.unsplash.com/bx1G9db3FjA", AlbumId = 3 },
                //Landscapes
                new Photo() { Id = 7, Description = "Photo by <a href=\"https://unsplash.com/@lucabravo?utm_source=unsplash&amp;utm_medium=referral&amp;utm_content=creditCopyText\">Luca Bravo</a>", FileName = "https://source.unsplash.com/zAjdgNXsMeg", AlbumId = 4 },
                new Photo() { Id = 8, Description = "Photo by <a href=\"https://unsplash.com/@peter_mc_greats?utm_source=unsplash&amp;utm_medium=referral&amp;utm_content=creditCopyText\">Pietro De Grandi</a>", FileName = "https://source.unsplash.com/T7K4aEPoGGk", AlbumId = 4 },
                //Night shots
                new Photo() { Id = 9, Description = "Photo by <a href=\"https://unsplash.com/@actionjackson801?utm_source=unsplash&amp;utm_medium=referral&amp;utm_content=creditCopyText\">Jackson Hendry</a>", FileName = "https://source.unsplash.com/eodA_8CTOFo", AlbumId = 5 },
            };

        public List<Photo> GetAlbumPhotos(int albumId)
        {
            var albumPhotos = allPhotos.Where(p => p.AlbumId == albumId);
            return albumPhotos.ToList();
        }

        public List<Photo> GetAllPhotos()
        {
            return allPhotos;
        }
    }
}
