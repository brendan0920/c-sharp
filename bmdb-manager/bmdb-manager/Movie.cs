namespace bmdb_manager
{
    internal class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }        
        public string Rating { get; set; }
        public string Director { get; set; }

        //public Movie(string title, int year, string rating, string director)
        //{
        //    this.Title = title;
        //    this.Year = year;
        //    this.Rating = rating;
        //    this.Director = director;

        //}

        public override string ToString()
        {
            return $"{this.Id}.{this.Title, -17}:  Year - {this.Year}, Rating - {this.Rating, -5}, Director - '{Director}'";
        }



    }
}
