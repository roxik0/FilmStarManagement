using System;
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

	    private readonly IStaffProvider _staffProvider;

        public AddNewMovie(IMovieRepository movieRepository, IStaffProvider staffProvider)
        {
            _movieRepository = movieRepository;
	        _staffProvider = staffProvider;
            InitializeComponent();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            var movie = new Movie();
            movie.Title = textBox1.Text;
            movie.Staff = chklbStaff.CheckedItems.Cast<MovieStar>();
            _movieRepository.AddMovie(movie);
        }

		private void AddNewMovie_Load(object sender, EventArgs e)
		{
			chklbStaff.Items.AddRange(_staffProvider.GetSuitableMovieStarsStaffMembers().ToArray());
		}
	}
}
