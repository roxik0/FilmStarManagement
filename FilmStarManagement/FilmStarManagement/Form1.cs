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
    public partial class Form1 : Form
    {
        private readonly IMovieStarRepository _movieStarRepository;
        private readonly IMovieRepository _movieRepository;

        public Form1(IMovieStarRepository movieStarRepository, 
            IMovieRepository movieRepository) : this()
        {
            _movieStarRepository = movieStarRepository;
            _movieRepository = movieRepository;
        }

        public Form1()
        {
            InitializeComponent();
           
        }



        private void button1_Click(object sender, EventArgs e)
        {
            new NewStar().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _movieRepository.GetAllMovies();
            dataGridView1.Columns["Id"].Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _movieStarRepository.GetAllStars();
            dataGridView1.Columns["Id"].Visible = false;
        }
    }

    public interface IMovieStarRepository
    {
        IEnumerable<MovieStar> GetAllStars();
    }

    public interface IMovieRepository
    {
        IEnumerable<Movie> GetAllMovies();
    }
}
