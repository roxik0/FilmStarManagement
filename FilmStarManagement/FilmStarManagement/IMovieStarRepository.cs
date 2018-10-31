using System;
using System.Collections.Generic;
using FilmStarManagement.DataObjects;

namespace FilmStarManagement
{
    public interface IMovieStarRepository
    {
        IEnumerable<MovieStar> GetAllStars();
        void AddMovieStar(MovieStar movieStar);
    }

    public interface ISkillsRepository
    {
        IEnumerable<Skill> GetAllSkills();

    }

    public class Skill
    {
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
    public class TempSkillsRepository : ISkillsRepository
    {
        private  readonly List<Skill> skills = new List<Skill>()
            {
                new Skill()
                {
                    Name =  "Anal",
                },
                new Skill()
                {
                    Name = "Rimjob",
                },
                new Skill()
                {
                    Name = "ThroatFuck"
                }
                
            };
            
        public IEnumerable<Skill> GetAllSkills()
        {
            return skills;
        }
    }
}