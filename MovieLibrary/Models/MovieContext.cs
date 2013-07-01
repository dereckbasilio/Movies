using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MovieLibrary.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext()
            : base("MoviesDBEntities")
        {
        }
        public DbSet<Movie> Movies { get; set; }
    }

    public class Movie
    {
        public int id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public DateTime DateReleased { get; set; }
    }
}