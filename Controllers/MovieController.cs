using Microsoft.AspNetCore.Mvc;
using MovieWeb.Database;
using MovieWeb.Domain;
using MovieWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWeb.Controllers
{
    //[Route("Movie")]
    public class MovieController : Controller
    {
        private readonly IMovieDatabase _movieDatabase;
        public MovieController(IMovieDatabase movieDatabase)
        {
            _movieDatabase = movieDatabase;
        }
        private Models.MovieDetailViewModel _movie1 = new Models.MovieDetailViewModel()
        {
            Id = 1,
            Title = "Lion King",
            Description = "Leeuwenkoning",
            Genre = "Animatie-film",
            ReleaseDate = new DateTime(1994, 5, 4)
        };

        private Models.MovieDetailViewModel _movie2 = new Models.MovieDetailViewModel()
        {
            Id = 2,
            Title = "Lion King II",
            Description = "Leeuwenkoning 2",
            Genre = "Animatie-film",
            ReleaseDate = new DateTime(1996, 5, 4)
        };
        private Models.MovieDetailViewModel _movie3 = new Models.MovieDetailViewModel()
        {
            Id = 3,
            Title = "Titanic",
            Description = "Sad",
            Genre = "Drama",
            ReleaseDate = new DateTime(1997, 8, 4)
        };
        //[Route("Detail")]
        public IActionResult Detail(int id)
        {
            Movie movieFromDb = _movieDatabase.GetMovie(id);
            MovieDetailViewModel movie = new MovieDetailViewModel()
            {
                Title = movieFromDb.Title,
                Description = movieFromDb.Description,
                ReleaseDate = movieFromDb.ReleaseDate,
                Genre = movieFromDb.Genre
            };
            return View(movie);
        }
        //[Route("")]
        //[Route("Index")]
        public IActionResult Index()
        {
            IEnumerable<Movie> moviesFromDb = _movieDatabase.GetMovies();
            List<MovieListViewModel> movies = new List<MovieListViewModel>();

            foreach (Movie movie in moviesFromDb)
            {
                movies.Add(new MovieListViewModel() { Id = movie.Id, Title = movie.Title });
            }

            return View(movies);
  
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(MovieCreateViewModel movie)
        {
            _movieDatabase.Insert(new Movie
            {
                Title = movie.Title,
                Description = movie.Description,
                Genre = movie.Genre,
                ReleaseDate = movie.ReleaseDate
            });
            return RedirectToAction("Index");
        }
    }
}
