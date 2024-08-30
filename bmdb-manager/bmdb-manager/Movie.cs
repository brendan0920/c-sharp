namespace bmdb_manager
{
    internal class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }        
        public string Rating { get; set; }
        public string Director { get; set; }

        public Movie (int id, string title, int year, string rating, string director)
        {
            this.Id = id;
            this.Title = title;
            this.Year = year;
            this.Rating = rating;
            this.Director = director;
        } 




    }
}
