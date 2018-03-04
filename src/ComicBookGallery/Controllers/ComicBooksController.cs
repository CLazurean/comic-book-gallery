using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            ViewBag.SeriesTitle = "The spirderman";
            ViewBag.IssueNumber = "123";
            ViewBag.Description = "qwerty <strong>QWERTY</strong";
            ViewBag.Artists = new string[]
                {
                    "asdfgh",
                    "zxcvbn"
                };

            return View();
        }
    }
}