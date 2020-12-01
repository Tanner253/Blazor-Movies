using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorMovies.Shared.Entities
{
    public class Genre
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="This field is required")]
        public string Name { get; set; }
        public List<MoviesGenres> MoviesGenres { get; set; } =
        new List<MoviesGenres>();
    }
}
