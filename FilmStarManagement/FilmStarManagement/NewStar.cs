using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FilmStarManagement.DataObjects;

namespace FilmStarManagement
{
	public partial class NewStar : Form
	{
	    private readonly ISkillsRepository _skillsRepository;
		private readonly IMovieStarRepository _movieStarRepository;

		public NewStar(IMovieStarRepository movieStarRepository, ISkillsRepository skillsRepository)
		{
			_movieStarRepository = movieStarRepository;
		    _skillsRepository = skillsRepository;

		    InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var movieStar = new MovieStar
			{
				Name = tbName.Text,
				NickName = tbNickName.Text
			};

			_movieStarRepository.AddMovieStar(movieStar);
            this.Close();
		}

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewStar_Load(object sender, EventArgs e)
        {
            checkedListBox1.Items.AddRange(_skillsRepository.GetAllSkills().ToArray());
        }
    }
}
