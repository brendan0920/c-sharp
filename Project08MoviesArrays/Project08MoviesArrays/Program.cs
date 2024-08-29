using System.IO;

namespace Project08MoviesArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myMovie = new (int Id, string Title, int Year, double Rating, string Director)[]
            {
                (1, "Inception", 2010, 8.8, "Christopher Nolan"),
                (2, "The Matrix", 1999, 8.7, "Lana Wachowski, Lilly Wachowski"),
                (3, "The Shawshank Redemption", 1994, 9.3, "Frank Darabont"),
                (4, "The Godfather", 1972, 9.2, "Francis Ford Coppola"),
                (5, "Pulp Fiction", 1994, 8.9, "Quentin Tarantino")
            };

            foreach (var movie in myMovie)
            {
                Console.WriteLine($"Id = {movie.Id}");
                Console.WriteLine($"Title = {movie.Title}");
                Console.WriteLine($"Year = {movie.Year}");
                Console.WriteLine($"Rating = {movie.Rating}");
                Console.WriteLine($"Director = {movie.Director}");
            }




        }
    }
}
