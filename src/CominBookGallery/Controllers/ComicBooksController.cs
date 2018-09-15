using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CominBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            return View();
            //if(DateTime.Today.DayOfWeek == DayOfWeek.Saturday)
            //{
            //    //return new RedirectResult("/");
            //    Redirect("/");
            //}

            ////return new ContentResult()
            ////{
            ////    Content= "Hello from comic book controller"
            ////};
            //return Content("Hello from comic book controller");
            
        }
    }
}