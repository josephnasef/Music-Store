using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Music2.Models;

namespace Music2.Controllers
{
    public class StoreController : Controller
    {
        MusicStoreEntities storeDB = new MusicStoreEntities();
        //
        // GET: /Store/
        public ActionResult Index()
        {
            var genres = storeDB.Genres.ToList(); 
            return View(genres);
        }
        //
        // GET: /Store/Browse
        //public ActionResult Browse(string genre)
        //{
        //    var genreModel = new Genre { Name = genre };
        //    return View(genreModel);
        //}
        public ActionResult Browse(string genre)
        {
            // Retrieve Genre and its Associated Albums from data base 
            var genreModel = storeDB.Genres.Include("Albums")
                .Single(g => g.Name == genre);
            return View(genreModel);
        }

        //
        // GET: /Store/Details/5


        public ActionResult Details(int id)
        {
            var album = storeDB.Albums.Find(id);
            return View(album);
        }

        //
        // GET: /Store/GenreMenu
        [ChildActionOnly]
        public ActionResult GenreMenu()
        {
            var genres = storeDB.Genres.ToList();
            return PartialView(genres);
        }
    }
}