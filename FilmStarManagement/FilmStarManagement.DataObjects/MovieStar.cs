﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmStarManagement.DataObjects
{
	public class MovieStar
	{
		
		public string Name { get; set; }
		public string NickName { get; set; }
		public double Rating { get; set; }
		public Guid Id { get; set; }

		public override string ToString()
		{
			return Name;
		}
	}

	public class Movie
	{
		public string Title { get; set; }
		public IEnumerable<MovieStar> Staff { get; set; } = new List<MovieStar>();
        public string StaffString => String.Join(" | ", Staff);
		public double Rating { get; set; }
		public Guid Id { get; set; }
	}
}
