using CSProj.Helpers;
using CSProj.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace CSProj
{
    public partial class Form1 : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            RefreshGrid();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dvMovies.DataSource = bindingSource1;
        }
        private void addMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form addMovie = new AddMovie();
            addMovie.Show();
        }

        private void refreshListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }
        public void RefreshGrid()
        {
            DataTable movies = DataHelper.GetMovies();
            if (movies.Rows.Count > 0)
            {
                List<Movie> results = new List<Movie>();
                int rowCount = movies.Rows.Count;
                for(var x = 0; x < rowCount; x++ )
                {
                    var row = movies.Rows[x];
                    Movie movie = new Movie()
                    {
                        Id = Convert.ToInt32(row.ItemArray[0].ToString()),
                        Title = row.ItemArray[1].ToString(),
                        Year = Convert.ToInt32(row.ItemArray[2].ToString()),
                        Director = row.ItemArray[3].ToString(),
                        GenreName = ConversionHelper.ConvertGenreToName(Convert.ToInt32(row.ItemArray[4].ToString())),
                        RottenTomatoesScore = Convert.ToInt32(row.ItemArray[5].ToString()),
                        TotalEarned = Convert.ToDecimal(row.ItemArray[6].ToString())
                    };
                    results.Add(movie);            
                }
                bindingSource1.DataSource = results;
            }
        }
        private void updateMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form updateMovie = new UpdateMovie();
            updateMovie.Show();
        }
        private void deleteMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form deleteMovie = new DeleteMovie();
            deleteMovie.Show();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form about = new About();
            about.Show();
        }

    }
}
