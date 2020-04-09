using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using Vidly3.Models;

namespace Vidly3.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie { Name = "Sherlock Hommos" };

              return View(movie);
            //return Content("Hello BItches ");
            //return new EmptyResult();
        }

        public ContentResult Edit(int id)
        {
            return Content("Id = "+ id);
        }

        public ActionResult ht()
        {
            return new HttpNotFoundResult();
        }
        public ActionResult Index(int? pageIndex,string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}