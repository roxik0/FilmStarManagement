using System.Collections.Generic;
using FilmStarManagement.DataObjects;

namespace FilmStarManagement
{
    public class TempMovieRepository : IMovieRepository
    {
        public IEnumerable<Movie> GetAllMovies()
        {
            return new List<Movie>()
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
        }
    }
}