using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FilmStarManagement.DataObjects;

namespace FilmStarManagement
{
    public class TempMovieRepository : IMovieRepository
    {
        private List<Movie> movies = new List<Movie>()
        {
            new Movie()
            {
                Title = "WildPussyFIVE",
                Rating = 2.3
            },
            new Movie()
            {
                Title = "WildPussySIX",
                Rating = 5.4
            }
        };
        public IEnumerable<Movie> GetAllMovies()
        {
            return movies;
        }

        public void AddMovie(Movie movie)
        {
            movies.Add(movie);
        }
    }
}