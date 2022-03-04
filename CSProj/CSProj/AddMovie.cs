using CSProj.Helpers;
using CSProj.Models;
using System;
using System.Windows.Forms;

namespace CSProj
{
    public partial class AddMovie : Form
    {
        public AddMovie()
        {
            InitializeComponent();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie()
            {
                Director = txtDirector.Text,
                Genre = ConversionHelper.ConvertGenreToNumber(comboGenre.SelectedIndex),
                RottenTomatoesScore = Convert.ToInt32(txtRottenTomatoesScore.Text),
                Title = txtMovieTitle.Text,
                TotalEarned = Convert.ToDecimal(txtBoxOfficeEarnings.Text),
                Year = Convert.ToInt32(txtYear.Text)
            };
            DataHelper.AddMovie(movie);
            this.Close();
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            txtMovieTitle.Text = string.Empty;
            txtDirector.Text = string.Empty;
            txtBoxOfficeEarnings.Text = string.Empty;
            txtRottenTomatoesScore.Text = string.Empty;
            txtYear.Text = string.Empty;
            comboGenre.Text = string.Empty;
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
