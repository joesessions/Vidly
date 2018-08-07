using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.WebSockets;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() {Name = "Shrek!" , Year = 2001};
            var customers = new List<Customer>
            {
                new Customer {Name = "Bob Sagat"},
                new Customer {Name = "Ted Nugent"},
                new Customer {Name = "Julie Nosko"},
                new Customer {Name = "Ted Taggett"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }


        public ActionResult MoviesList()
        {
            var movies = new List<Movie>
            {
                new Movie {Id = 1, Name = "Shrek!", Year = 2001},
                new Movie {Id = 2, Name = "Wall-e", Year = 2008}
            };

            var viewModel = new MoviesListViewModel()
            {
                Movies = movies
            };

            return View(viewModel);
        }


    }
}    

