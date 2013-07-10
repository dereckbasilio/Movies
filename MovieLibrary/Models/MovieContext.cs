using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        //[Required]
        public string Title { get; set; }
        public string Director { get; set; }
        public DateTime DateReleased { get; set; }
        public string Genre { get; set; }
    }

    public enum Genre
    {
        G,
        PG,
        PG13,
        R
    }
}