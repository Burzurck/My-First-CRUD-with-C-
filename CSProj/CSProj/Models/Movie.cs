namespace CSProj.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }
        [System.ComponentModel.Browsable(false)]
        public int Genre { get; set; }
        public string GenreName { get; set; }
        public int RottenTomatoesScore { get; set; }
        public decimal TotalEarned { get; set; }

    }
}
