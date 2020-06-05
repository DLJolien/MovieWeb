using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWeb.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Detail()
        {
            Models.MovieDetailViewModel movie = new Models.MovieDetailViewModel()
            {
                Title = "Lion King",
                Description = "Leeuwenkoning",
                Genre = "Animatie-film",
                ReleaseDate = new DateTime(1994,5,4)
            };

            return View(movie);
        }
    }
}
