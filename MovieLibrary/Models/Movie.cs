using System;
using System.ComponentModel.DataAnnotations;

namespace MovieLibrary.Models
{
    public class Movie
    {
        public int id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Director { get; set; }
        public DateTime DateReleased { get; set; }
        public string Genre { get; set; }
        public string ImageUrl { get; set;}
    }
}