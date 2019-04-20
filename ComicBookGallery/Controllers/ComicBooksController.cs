using ComicBookGallery.Data;
using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {

        private ComicBookRepository _comicbookrepository = null;

        public ComicBooksController()
        {
            _comicbookrepository = new ComicBookRepository();
        }
        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
                       
            var comicBook = _comicbookrepository.GetComicBook((int)id);
            return View(comicBook);
            

            
        }
    }
}