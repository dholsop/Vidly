using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        [Route("movies/random")]
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };

            var customers = new List<Customer> { new Customer { Name = "Customer 1", Id = 1 }, new Customer { Name = "Customer 2", Id = 2 } };

            var viewModel = new RandomMovieViewModel { Movie = movie, Customers = customers };

            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {

            return Content("Got the id:" + id.ToString());
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (pageIndex.HasValue == false)
            {
                pageIndex = 1;
            }

            if (String.IsNullOrWhiteSpace(sortBy) == true)
            {
                sortBy = "Name";
            }

            List<Movie> l = new List<Movie> { new Models.Movie { Name = "One Flew Over", Id = 1 }, new Movie { Name = "Gone with the", Id = 2 } };

            var viewModel = new IndexMovieViewModel { Name="The List", Movies = l };

            return View(viewModel);
        }

        [Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseYear(int year, int month)
        {
            return Content("Year=" + year.ToString() + " Month=" + month.ToString());
        }

    }
}