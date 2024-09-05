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

            Movie m1 = new Movie(1, "The Dark Knight", 2008, "PG-13", "Christopher Nolan");
            Movie m2 = new Movie(2, "Joker", 2019, "R", "Todd Phillips");
            Movie m3 = new Movie(3, "The Notebook", 2004, "PG-13", "Nick Cassavetes");
            Movie m4 = new Movie(4, "GoodWill Hunting", 1997, "R", "Gus Van Sant");
            Movie m5 = new Movie(5, "Unbroken", 2014, "PG-13", "Angelina Jolie");

        }

        public override string ToString()
        {
            return $"Movie: Id - '{this.Id}', Title - '{this.Title}', Year - '{this.Year}', Rating - '{this.Rating}', Director - '{Director}'";
        }



    }
}
