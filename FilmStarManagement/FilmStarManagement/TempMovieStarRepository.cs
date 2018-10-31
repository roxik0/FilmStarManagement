using System.Collections.Generic;
using FilmStarManagement.DataObjects;

namespace FilmStarManagement
{
    public class TempMovieStarRepository : IMovieStarRepository
    {
        public IEnumerable<MovieStar> GetAllStars()
        {
            return new List<MovieStar>()
            {
                new MovieStar()
                {
                    Name = "Ivona",
                    NickName = "Helga",
                    Rating = 5.9
                },
                new MovieStar()
                {
                    Name = "Barbara",
                    NickName = "Bożenka",
                    Rating = 5.9
                },
            };
        }
    }
}