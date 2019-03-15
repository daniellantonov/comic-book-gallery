using System;
using Microsoft.AspNetCore.Mvc;

namespace comic_book_gallery.Controllers
{
    public class ComicBookController : Controller
    {
        public ActionResult Detail()
        {
            return View(); 
        }
    }
}
