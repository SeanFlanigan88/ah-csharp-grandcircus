using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MovieCRUDAPI.Data;
using MovieCRUDAPI.Models;

namespace MovieCRUDAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class MoviesController : Controller
    {
        private readonly MovieCRUDAPIContext _context;

        public MoviesController(MovieCRUDAPIContext context)
        {
            _context = context;
        }

        // GET: Movies
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetMovies()
        {
            var listOfMovies = await _context.Movie.ToListAsync();

            var result = new OkObjectResult(listOfMovies);
            return result;
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateMovie(Movie movie)
        {
            await _context.AddAsync(movie);
            await _context.SaveChangesAsync();
            return new OkResult();
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetMovieById(int? id)
        {
            if (id == null)
            {
                return new BadRequestResult();
            }

            var movie = _context.Movie.FirstOrDefault(m => m.Id == (int)id);

            if (movie == null)
            {
                return new NotFoundResult();
            }
            else
            {
                return new OkObjectResult(movie);
            }
        }

        [HttpPut]
        [Route("update")]
        public async Task<IActionResult> UpdateMovie(Movie movie)
        {
            var movieFromDb = _context.Movie.FirstOrDefault(m => m.Id == movie.Id);
            if (movieFromDb == null)
            {
                return RedirectToAction("CreateMovie", movie);
            }

            _context.Movie.Remove(movieFromDb);

            movie.Id = 0;

            await _context.AddAsync(movie);
            await _context.SaveChangesAsync();

            return new OkResult();
        }


        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteMovie(int? id)
        {
            var movieFromDb = _context.Movie.FirstOrDefault(m => m.Id == id);
            if (movieFromDb == null)
            {
                return new OkResult();
            }

            _context.Movie.Remove(movieFromDb);
            await _context.SaveChangesAsync();

            return new OkResult();
        }


    }
}
