using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using Vidly3.Models;
using Vidly3.ViewModels;

namespace Vidly3.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Details(int id)
        {
            var movie = GetMovies().SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }
        public ViewResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }

        private List<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Sherlock" },
                new Movie { Id = 2, Name = "The Three Stooges" }
            };
        }
        // GET: Movies
        /*     public ActionResult Random()
             {
                 var movie = new Movie { Name = "Sherlock Hommos" };
                 var customers = new List<Customer>
                 {
                     new Customer{Name="Muhammad "},
                     new Customer{Name="Customer 2"}

                 };
                 var viewModel = new RandomMovieViewModel
                 {
                     Movie = movie,
                     customers=customers
                 };
                 return View(viewModel);
                 return View(movie);
                 //return Content("Hello BItches ");
                 //return new EmptyResult();
             }



        /*     public ActionResult ht()
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
             [Route ("movies/released/{year}/{month:regex(\\{4}):range(1,12)}")]
             public ActionResult ByReleaseDate(int year, int month)
             {
                 return Content(year + "/" + month);
             }
         }*/
    }
}
