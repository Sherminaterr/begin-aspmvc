﻿using System;
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
            //View bag is dynamic type
            //To follow convention, use Captial case.
            ViewBag.SeriesTitle = "The Amaziing Spider-Man";
            ViewBag.IssueNumber = "700";
            ViewBag.Description = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>";
            ViewBag.Artists = new string[]
            {
                "Script: Dan Slott",
                "Pencils: Humberto Ramos",
                "Inks: Victor Olazaba",
                "Colors: Edgar Delgado",
                "Letters: Chris Eliopoulos"
            };
        
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