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
    public partial class AddNewMovie : Form
    {
        private readonly IMovieRepository _movieRepository;

        public AddNewMovie(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            var movie = new Movie();
            movie.Title = textBox1.Text;
            _movieRepository.AddMovie(movie);
        }
    }
}
