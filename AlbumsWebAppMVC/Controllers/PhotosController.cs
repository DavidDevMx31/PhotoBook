using AlbumsWebApp.Data;
using AlbumsWebApp.Domain.DomainInterfaces;
using AlbumsWebApp.Domain.Implementations;
using AlbumsWebApp.Domain.RepositoryInterfaces;
using AlbumsWebAppMVC.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlbumsWebAppMVC.Controllers
{
    public class PhotosController : Controller
    {
        private readonly PhotoPresenter presenter;
        private readonly IPhotoInteractor interactor;
        private readonly IPhotoRepository repository;

        public PhotosController()
        {
            presenter = new PhotoPresenter();
            repository = new PhotoRepository();
            interactor = new PhotoInteractor(repository);
        }
        // GET: Photos
        public ActionResult Photos()
        {
            return View();
        }

        public ActionResult GetAlbumPhotos(int albumId)
        {
            interactor.GetPhotosForAlbum(albumId, presenter);
            var result = presenter.GetAlbumPhotos();
            return Json(result);
        }
    }
}