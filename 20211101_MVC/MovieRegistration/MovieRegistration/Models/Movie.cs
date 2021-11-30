using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRegistration.Models
{
    public class Movie
    {
        public Movie() { }
        public Movie(MovieViewModel model)
        {
            this.ID = model.ID;
            this.Title = model.Title;
            this.Genre = model.Genre;
            this.Year = model.Year;
            this.Actors = model.Actors.Split(",").ToList();
            this.Directors = model.Directors.Split(",").ToList();
        }

        public int ID { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public List<string> Actors { get; set; } = new List<string>();
        public List<string> Directors { get; set; } = new List<string>();
    }

    public class MovieViewModel
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public string Actors { get; set; }
        public string Directors { get; set; }
    }
}
