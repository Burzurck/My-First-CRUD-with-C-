using CSProj.Models;
using System.Data;
using System.Data.SqlClient;

namespace CSProj.Helpers
{
    public class DataHelper
    {
        private static string connectionstring = "removed connection string for security and privacy purposes";
        public static DataTable GetMovies()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from Movies order by Id desc", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }
        public static DataTable FindMovie(string name)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand($"Select * from Movies where Title = '{name}'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }
        public static int AddMovie(Movie movie)
        {
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                con.Open();
                string query = "Insert into Movies (Title, Year, Director, Genre, RottenTomatoesScore, TotalEarned) values(@Title, @Year, @Director, @Genre, @RottenTomatoesScore, @TotalEarned)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Title", movie.Title);
                cmd.Parameters.AddWithValue("@Year", movie.Year);
                cmd.Parameters.AddWithValue("@Director", movie.Director);
                cmd.Parameters.AddWithValue("@Genre", movie.Genre);
                cmd.Parameters.AddWithValue("@RottenTomatoesScore", movie.RottenTomatoesScore);
                cmd.Parameters.AddWithValue("@TotalEarned", movie.TotalEarned);
                return cmd.ExecuteNonQuery();
            }
        }
        public static int UpdateMovie(Movie movie)
        {
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                con.Open();
                string query = "Update Movies SET Title=@Title , Year=@Year , Director=@Director , Genre=@Genre , RottenTomatoesScore=@RottenTomatoesScore , TotalEarned=@TotalEarned where Id=@Id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", movie.Id);
                cmd.Parameters.AddWithValue("@Title", movie.Title);
                cmd.Parameters.AddWithValue("@Year", movie.Year);
                cmd.Parameters.AddWithValue("@Director", movie.Director);
                cmd.Parameters.AddWithValue("@Genre", movie.Genre);
                cmd.Parameters.AddWithValue("@RottenTomatoesScore", movie.RottenTomatoesScore);
                cmd.Parameters.AddWithValue("@TotalEarned", movie.TotalEarned);
                return cmd.ExecuteNonQuery();
            }
        }
        public static int DeleteMovie(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                con.Open();
                string query = "Delete from Movies where id=@Id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", id);
                return cmd.ExecuteNonQuery();
            }
        }
    }
}
