using System.Collections.Generic;
using FilmStarManagement.DataObjects;

namespace FilmStarManagement
{
	public interface IStaffProvider
	{
		IEnumerable<MovieStar> GetSuitableMovieStarsStaffMembers();
	}
}