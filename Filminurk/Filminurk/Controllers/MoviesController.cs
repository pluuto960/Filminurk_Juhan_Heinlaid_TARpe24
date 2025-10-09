using Filminurk.Data;
using Filminurk.Models.Movies;
using Microsoft.AspNetCore.Mvc;

namespace Filminurk.Controllers
{
    public class MoviesController : Controller
    {
        private readonly FilminurkTARpe24Context _context;
        public MoviesController (FilminurkTARpe24Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var result = _context.Movies.Select(x => new MoviesIndexViewModel
            {
                Id = x.Id,
                Title = x.Title,
                FirstPublished = x.FirstPublished,
                CurrentRating= x.CurrentRating,
                MovieGenre= x.MovieGenre,
                MovieInspiration= x.MovieInspiration,
                


            });
            return View();
        }
        [HttpGet]
        public IActionResult Get() 
        {
            MoviesCreateViewModel result = new();
            return View("Create", result);
        }
    }
}
