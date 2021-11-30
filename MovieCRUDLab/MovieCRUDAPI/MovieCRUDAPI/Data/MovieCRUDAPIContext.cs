using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieCRUDAPI.Models;

namespace MovieCRUDAPI.Data
{
    public class MovieCRUDAPIContext : DbContext
    {
        public MovieCRUDAPIContext (DbContextOptions<MovieCRUDAPIContext> options)
            : base(options)
        {
        }

        public DbSet<MovieCRUDAPI.Models.Movie> Movie { get; set; }
    }
}
