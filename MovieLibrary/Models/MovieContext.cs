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

    public enum Genre
    {
        G,
        PG,
        PG13,
        R
    }
}