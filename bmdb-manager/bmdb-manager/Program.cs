using System;

namespace bmdb_manager
{
    internal class Program
    {

        // Creating a list with my movies in it
        static List<string> movies = new List<string>
        {
            "The Dark Knight",
            "Joker",
            "The Notebook",
            "GoodWill Hunting",
            "Unbroken"
        };

        static List<string> actors = new List<string>
        {
            "Christian",
            "Heath",
            "Joaquin",
            "Robert",
            "Ryan",
            "Rachel",
            "Matt",
            "Ben",
            "Robin",
            "Jack"
        };


        private static void MovieDetail()
        {
            
            
        }

        static void Main(string[] args)
        {
            //List<Movie> movies = new List<Movie>();

            //Movie m1 = new Movie(1, "The Dark Knight", 2008, "PG-13", "Christopher Nolan");
            //Movie m2 = new Movie(2, "Joker", 2019, "R", "Todd Phillips");
            //Movie m3 = new Movie(3, "The Notebook", 2004, "PG-13", "Nick Cassavetes");
            //Movie m4 = new Movie(4, "GoodWill Hunting", 1997, "R", "Gus Van Sant");
            //Movie m5 = new Movie(5, "Unbroken", 2014, "PG-13", "Angelina Jolie");
            
            //movies.Add(m1);
            //movies.Add(m2);
            //movies.Add(m3);
            //movies.Add(m4);
            //movies.Add(m5);



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

        private static int DelMovie()
        {
            int movieNum;
            Console.WriteLine("\nDelete a movie");
            movieNum = GetInt("Enter a movie id to delete: ", 1, movies.Count());
            string delMovie = movies[movieNum - 1];
            movies.Remove(delMovie);
            Console.WriteLine($"Movie '{delMovie}' has been deleted.");
            return movieNum;
        }

        private static void AddMovie()
        {
            Console.WriteLine("\nAdd a movie");
            string addMovie = GetString("Enter a movie title: ");
            movies.Add(addMovie);
            Console.WriteLine($"{addMovie} has been added to the list.");
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