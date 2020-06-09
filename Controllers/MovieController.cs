using Microsoft.AspNetCore.Mvc;
using MovieWeb.Database;
using MovieWeb.Domain;
using MovieWeb.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [HttpGet]
        public IActionResult Create()
        {
            MovieCreateViewModel vm = new MovieCreateViewModel();
            vm.ReleaseDate = DateTime.Now;
            
            return View(vm);
        }
        [HttpPost]
        public IActionResult Create(MovieCreateViewModel movie)
        {
            if (ModelState.IsValid)
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
            return View(movie);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Movie movieToEdit = _movieDatabase.GetMovie(id);

            MovieEditViewModel vm = new MovieEditViewModel()
            {
                Id = id,
                Title = movieToEdit.Title,
                Description = movieToEdit.Description,
                Genre = movieToEdit.Genre,
                ReleaseDate = movieToEdit.ReleaseDate
            };
            return View(vm);
        }

        [HttpPost]
        public IActionResult Edit(MovieEditViewModel vm)
        {
            if (!TryValidateModel(vm))
            {
                return View(vm);
            }

            Movie domainMovie = new Movie
            {
                Id = vm.Id,
                Title = vm.Title,
                Description = vm.Description,
                Genre = vm.Genre,
                ReleaseDate = vm.ReleaseDate
            };

            _movieDatabase.Update(domainMovie.Id, domainMovie);

            return RedirectToAction("Detail", new { Id = domainMovie.Id});
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Movie movieToDelete = _movieDatabase.GetMovie(id);

            MovieDeleteViewModel vm = new MovieDeleteViewModel()
            {
                Id = movieToDelete.Id,
                Title = movieToDelete.Title,
            };
            return View(vm);
        }
        [HttpPost]
        public IActionResult ConfirmDelete(MovieDeleteViewModel vm)
        {
           
            _movieDatabase.Delete(vm.Id);
            return RedirectToAction("Index");
        }
    }
}
