using AlbumsWebApp.Data;
using AlbumsWebApp.Domain.DomainInterfaces;
using AlbumsWebApp.Domain.Implementations;
using AlbumsWebApp.Domain.Presenters;
using AlbumsWebApp.Domain.RepositoryInterfaces;
using AlbumsWebAppMVC.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlbumsWebAppMVC.Controllers
{
    public class AlbumsController : Controller
    {
        private readonly AlbumPresenter presenter;
        private readonly IAlbumInteractor interactor;
        private readonly IAlbumRepository repository;

        public AlbumsController()
        {
            presenter = new AlbumPresenter();
            repository = new AlbumRepository();
            interactor = new AlbumInteractor(repository);
        }
        // GET: Albums
        public ActionResult Albums()
        {
            interactor.GetAlbums(presenter);
            var albums = presenter.GetItems();
            return View(albums);
        }
    }
}
