using BlazorMovies.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovies.Client.Helpers
{
    public class RepositoryInMemory : IRepository
    {
        public List<Movie> GetMovies()
        {
            //return context request here
            return new List<Movie>()
{

            new Movie {Title = "Spider-Man",
            ReleaseDate = new DateTime(2019, 7, 2), Poster = "https://image-cdn.essentiallysports.com/wp-content/uploads/20201001173349/Marvels-Spider-Man-Desktop-Wallpaper-3-3-1600x900.jpg" },
        new Movie { Title = "Spider-Man2",
            ReleaseDate = new DateTime(2019, 7, 2), Poster = "https://image-cdn.essentiallysports.com/wp-content/uploads/20201001173349/Marvels-Spider-Man-Desktop-Wallpaper-3-3-1600x900.jpg"  },
        new Movie { Title = "Spider-Man3",
            ReleaseDate = new DateTime(2019, 7, 2), Poster = "https://image-cdn.essentiallysports.com/wp-content/uploads/20201001173349/Marvels-Spider-Man-Desktop-Wallpaper-3-3-1600x900.jpg"  },
        new Movie { Title = "Spider-Man4",
            ReleaseDate = new DateTime(2019, 7, 2), Poster = "https://image-cdn.essentiallysports.com/wp-content/uploads/20201001173349/Marvels-Spider-Man-Desktop-Wallpaper-3-3-1600x900.jpg"  }
        };
        }
    }
}
