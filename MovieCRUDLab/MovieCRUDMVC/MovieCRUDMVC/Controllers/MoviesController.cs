using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieCRUDMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace MovieCRUDMVC.Controllers
{
    public class MoviesController : Controller
    {
        public string BaseURL = "https://localhost:44353/movies";

        // GET: MoviesController
        public async Task<ActionResult> Index(string errMessage = "")
        {
            List<Movie> myMovies = new List<Movie>();
            using(HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(BaseURL);
                myMovies = JsonConvert.DeserializeObject<List<Movie>>(await response.Content.ReadAsStringAsync());
            }

            ViewData["errorMsg"] = errMessage;
            return View(myMovies);
        }

        // GET: MoviesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MoviesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind("Title","Genre","Runtime")]Movie movie)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var content = JsonContent.Create(movie);
                    var response = await client.PostAsync($"{BaseURL}/create", content);
                    if (response.StatusCode != System.Net.HttpStatusCode.OK)
                    {
                        return View(nameof(Index), new { errMessage = "error creating movie in DB" });
                    }
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Index), new { errMessage = "error calling movie/create" });
            }
        }

        // GET: MoviesController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            Movie movie = null;
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync($"{BaseURL}/{id}");

                if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    return View(nameof(Index), new { errMessage = "error getting movie from api" });
                }

                var jsonStringContent = await response.Content.ReadAsStringAsync();
                movie = JsonConvert.DeserializeObject<Movie>(jsonStringContent);
            }

            return View(movie);
        }

        // POST: MoviesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, [Bind("Title", "Genre", "Runtime")] Movie movie)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    movie.Id = id;
                    var content = JsonContent.Create(movie);
                    var response = await client.PutAsync($"{BaseURL}/update", content);
                    if (response.StatusCode != System.Net.HttpStatusCode.OK)
                    {
                        return RedirectToAction(nameof(Index), new { errMessage = "error updateing movie in DB" });
                    }
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Index), new { errMessage = "error calling movie/update" });
            }
        }

        [HttpGet]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var response = await client.DeleteAsync($"{BaseURL}/{id}");
                    if (response.StatusCode != System.Net.HttpStatusCode.OK)
                    {
                        return RedirectToAction(nameof(Index), new { errMessage = "error updateing movie in DB" });
                    }
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Index), new { errMessage = "error calling movie/update" });
            }
        }
    }
}
