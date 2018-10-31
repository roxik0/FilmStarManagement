using System.Collections.Generic;
using FilmStarManagement.DataObjects;

namespace FilmStarManagement
{
    public class TempMovieStarRepository : IMovieStarRepository
    {
	    private List<MovieStar> superStars = new List<MovieStar>()
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
			    Rating = 5.1
		    }
	    };
		public IEnumerable<MovieStar> GetAllStars()
		{
			return superStars;

		}

	    public void AddMovieStar(MovieStar movieStar)
	    {
		    superStars.Add(movieStar);
	    }

    }
	public class TempStaffProvider: IStaffProvider
	{
		private readonly IMovieStarRepository _movieStarRepository;

		public TempStaffProvider(IMovieStarRepository movieStarRepository)
		{
			_movieStarRepository = movieStarRepository;
		}
		public IEnumerable<MovieStar> GetSuitableMovieStarsStaffMembers()
		{
			return _movieStarRepository.GetAllStars();
		}
	}
}