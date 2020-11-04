using AlbumsWebApp.Data;
using AlbumsWebApp.Domain.DomainInterfaces;
using AlbumsWebApp.Domain.Implementations;
using AlbumsWebApp.Domain.RepositoryInterfaces;
using AlbumsWebAppMVC.Models;
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
        private readonly IAlbumRepository albumRepository;

        public PhotosController()
        {
            presenter = new PhotoPresenter();
            repository = new PhotoRepository();
            albumRepository = new AlbumRepository();
            interactor = new PhotoInteractor(repository, albumRepository);
        }
        // GET: Photos
        public ActionResult Photos()
        {
            interactor.GetAllPhotos(presenter);
            var photoAlbum = presenter.GetAlbumInfo();
            return View(photoAlbum);
        }

        public ActionResult GetAlbumPhotos(int albumId)
        {
            interactor.GetPhotosForAlbum(albumId, presenter);
            var photoAlbum = presenter.GetAlbumInfo();
            return View("Photos", photoAlbum);
        }
    }
}