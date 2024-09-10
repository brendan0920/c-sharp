using System;
using System.IO;

namespace bmdb_manager
{
    internal class Program
    {

        // Creating a list with my movies in it
        public static List<Movie> movies = new List<Movie> { };

        public static List<Actor> actors = new List<Actor> { };
        

        static void Main(string[] args)
        {
            MoviesList();
            ActorsList();

            Console.WriteLine("Welcome to My Movie World\n");
            // user's prompt line - "Options: "

            // Display Menu - create a method
            DisplayMenu();
            string options = "";
            //while loop
            while (options != "exit")
            {
                // do bizz
                options = GetString("\nOptions: ");
                //switch
                switch (options)
                {
                    // Menu - display menu
                    case "menu":
                        DisplayMenu();
                        break;
                    // * List - list all movies
                    case "list":
                        ShowMovieList();
                        break;
                    // *Get - Get a movie by id
                    case "get":
                        int movieNum;
                        GetMovie();
                        break;
                    // *Add - Add a movie
                    case "add":
                        AddMovie();
                        break;
                    // *Del - Delete a movie
                    case "del":
                        movieNum = DelMovie();
                        break;
                    // *Exit - Exit the app
                    case "exit":
                        Console.WriteLine("\nExiting the app");
                        Console.WriteLine("\nBye!");
                        break;
                }
            }
            Console.WriteLine("Bye for now!");
        }

        private static void MoviesList()
        {
            Movie m1 = new Movie();
            m1.Id = 1;
            m1.Title = "The Dark Knight";
            m1.Year = 2008;
            m1.Rating = "PG-13";
            m1.Director = "Christopher Nolan";

            Movie m2 = new Movie();
            m2.Id = 2;
            m2.Title = "Joker";
            m2.Year = 2019;
            m2.Rating = "R";
            m2.Director = "Todd Phillips";

            Movie m3 = new Movie();
            m3.Id = 3;
            m3.Title = "The Notebook";
            m3.Year = 2004;
            m3.Rating = "PG-13";
            m3.Director = "Nick Cassavetes";

            Movie m4 = new Movie();
            m4.Id = 4;
            m4.Title = "GoodWill Hunting";
            m4.Year = 1997;
            m4.Rating = "R";
            m4.Director = "Gus Van Sant";

            Movie m5 = new Movie();
            m5.Id = 5;
            m5.Title = "Unbroken";
            m5.Year = 2014;
            m5.Rating = "PG-13";
            m5.Director = "Angelina Jolie";

            movies.Add(m1);
            movies.Add(m2);
            movies.Add(m3);
            movies.Add(m4);
            movies.Add(m5);
        }

        private static void ActorsList()
        {
            Actor a1 = new Actor();
            a1.Id = 1;
            a1.FirstName = "Christian";
            a1.LastName = "Bale";
            a1.Gender = "M";
            a1.BirthDate = DateTime.Parse("1/30/1974");

            Actor a2 = new Actor();
            a2.Id = 2;
            a2.FirstName = "Heath";
            a2.LastName = "Ledger";
            a2.Gender = "M";
            a2.BirthDate = DateTime.Parse("1/22/1979");

            Actor a3 = new Actor();
            a3.Id = 3;
            a3.FirstName = "Joaquin";
            a3.LastName = "TePhoenixst";
            a3.Gender = "M";
            a3.BirthDate = DateTime.Parse("10/28/1974");

            Actor a4 = new Actor();
            a4.Id = 4;
            a4.FirstName = "Robert";
            a4.LastName = "De Niro";
            a4.Gender = "M";
            a4.BirthDate = DateTime.Parse("8/17/1943");

            Actor a5 = new Actor();
            a5.Id = 5;
            a5.FirstName = "TeRyanst";
            a5.LastName = "Gosling";
            a5.Gender = "M";
            a5.BirthDate = DateTime.Parse("11/12/1980");

            Actor a6 = new Actor();
            a6.Id = 6;
            a6.FirstName = "Rachel";
            a6.LastName = "McAdams";
            a6.Gender = "F";
            a6.BirthDate = DateTime.Parse("11/17/1978");

            Actor a7 = new Actor();
            a7.Id = 7;
            a7.FirstName = "Matt";
            a7.LastName = "Damon";
            a7.Gender = "M";
            a7.BirthDate = DateTime.Parse("10/8/1970");

            Actor a8 = new Actor();
            a8.Id = 8;
            a8.FirstName = "Ben";
            a8.LastName = "Affleck";
            a8.Gender = "M";
            a8.BirthDate = DateTime.Parse("8/15/1972");

            Actor a9 = new Actor();
            a9.Id = 9;
            a9.FirstName = "Robin";
            a9.LastName = "Williams";
            a9.Gender = "M";
            a9.BirthDate = DateTime.Parse("7/21/1957");

            Actor a10 = new Actor();
            a10.Id = 10;
            a10.FirstName = "Jack";
            a10.LastName = "O'Connell";
            a10.Gender = "M";
            a10.BirthDate = DateTime.Parse("8/1/1990");

        }

        private static int DelMovie()
        {
            int movieNum;
            Console.WriteLine("\nDelete a movie");
            movieNum = GetInt("Enter a movie id to delete: ", 1, movies.Count());
            Movie delMovie = movies[movieNum - 1];
            movies.Remove(delMovie);
            Console.WriteLine($"Movie '{delMovie.Title}' has been deleted.");
            return movieNum;
        }

        private static void AddMovie()
        {
            Console.WriteLine("\nAdd a movie");
            Movie addMovie = new Movie();
            addMovie.Title = GetString("Enter a movie title: ");
            addMovie.Year = GetInt("Enter movie year: ", 1, 2025);
            addMovie.Rating = GetString("Enter movie rating: ");
            addMovie.Director = GetString("Enter movie director: ");
                        
            movies.Add(addMovie);
            Console.WriteLine($"{addMovie.Title} has been added to the list.");
        }

        private static void GetMovie()
        {
            int movieNum = GetInt("Enter the movie id: ", 1, movies.Count());
            Console.WriteLine($"Movie number'{movieNum}' is '{movies[movieNum - 1]}'.");
        }

        private static void DisplayMenu()
        {
            Console.WriteLine("\n***Movie Database***");
            Console.WriteLine("menu - Display the menu");
            Console.WriteLine("list - Show all movies");
            Console.WriteLine("get - Get a movie by ID");
            Console.WriteLine("add - Add a movie");
            Console.WriteLine("del - Delete a movie");
            Console.WriteLine("exit - Exit the app\n");
        }


        private static void ShowMovieList()
        {
            Console.WriteLine("\nMovie List");
            for (int i = 0; i < movies.Count(); i++)
            {
                Console.WriteLine($"{i + 1}. {movies[i]}");
            }
        }


        //GetString
        private static string GetString(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine().ToLower();
        }


        //GetInt
        private static int GetInt(string prompt, int min, int max)
        {
            int number = 0;
            Boolean isValid = false;
            while (!isValid)
            {
                try
                {
                    Console.Write(prompt);
                    number = Int32.Parse(Console.ReadLine());
                    if (number < min)
                    {
                        Console.WriteLine($"Invalid entry: number less than min ({min})");
                        continue;
                    }
                    else if (number > max)
                    {
                        Console.WriteLine($"Invalid entry: number greater than max ({max})");
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid entry: please enter a valid integer.");
                    continue;
                }
            }
            return number;
        }
    }
}