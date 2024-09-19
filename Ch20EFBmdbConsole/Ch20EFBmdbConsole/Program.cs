using Ch20EFBmdbConsole.Db;
using Ch20EFBmdbConsole.Models;
using System.IO;

namespace Ch20EFBmdbConsole
{
    internal class Program
    {
        static MovieDb movieDb = new();
        static ActorDb actorDb = new();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcme to Entity Framework, the BMDM Manager");

            string command = "";
            while(command != "exit")
            {
                DisplayMenu();
                command = PromptInput("\nCommand: ");

                switch(command)
                {
                    case "menu":
                        DisplayMenu();
                        break;
                    case "list movies":
                        ListMovies();
                        break;
                    case "list actors":
                        ListActors();
                        break;
                    case "get movie":
                        GetMovie();
                        break;
                    case "get actor":
                        GetActor();
                        break;
                    case "add movie":
                        AddMovie();
                        break;
                    case "add actor":
                        AddActor();
                        break;
                    case "del movie":
                        DeleteMovie();
                        break;
                    case "del actor":
                        DeleteActor();
                        break;
                    case "exit":                    
                        break;
                    default:
                        Console.WriteLine("Invalid command. Try again");
                        break;
                }
                
            }
            Console.WriteLine("Bye!");
        }


        private static void ListMovies()
        {
            Console.WriteLine("\nMovies List:");
            Console.WriteLine("==============================");
            // do bizz
            List<Movie> movies = movieDb.GetMovies();
            foreach (Movie movie in movies) 
            {
                Console.WriteLine(movie);
            }
        }

        private static void ListActors()
        {
            Console.WriteLine("\nActors List:");
            Console.WriteLine("==============================");
            // do bizz
            List<Actor> actors = actorDb.GetActors();
            foreach (Actor actor in actors)
            {
                Console.WriteLine(actor);
            }
        }

        private static void GetMovie()
        {
            Console.WriteLine("\nGet Movie By ID:");
            Console.WriteLine("==============================");
            // do bizz
            int id = Int32.Parse(PromptInput("Movie ID: "));
            Movie m = movieDb.FindMovies(id);
            if (m != null)
            {
                Console.WriteLine($"Movie Found: {m}");
            } else
            {
                Console.WriteLine($"No movie found for id: {id}");
            }

        }

        private static void GetActor()
        {
            Console.WriteLine("\nGet Actor By ID:");
            Console.WriteLine("==============================");
            // do bizz
            int id = Int32.Parse(PromptInput("Actor ID: "));
            Actor a = actorDb.FindActors(id);
            if (a != null)
            {
                Console.WriteLine($"Actor Found: {a}");
            }
            else
            {
                Console.WriteLine($"No actor found for id: {id}");
            }

        }

        private static void AddMovie()
        {
            Console.WriteLine("\nAdd a Movie:");
            Console.WriteLine("==============================");
            // do bizz
            string title = PromptInput("Movie Title: ");
            int year = Int32.Parse(PromptInput("Release Year: "));
            string rating = PromptInput("Age Rating: ");
            string director = PromptInput("Director: ");
            Movie m = new Movie(title, year, rating, director);
            movieDb.AddMovie(m);
            Console.WriteLine($"Movie added: {m}");
        }

        private static void AddActor()
        {
            Console.WriteLine("\nAdd an Actor:");
            Console.WriteLine("==============================");
            // do bizz
            string firstName = PromptInput("Actor's First name: ");
            string lastName = PromptInput("Actor's Last name: ");
            string gender = PromptInput("gender (F/M): ");
            DateOnly birthdate = DateOnly.Parse(PromptInput("Birthdate: "));
            Actor a = new Actor(firstName, lastName, gender, birthdate);            
            actorDb.AddActor(a);
            Console.WriteLine($"Actor added: {a}");
        }

        private static void DeleteMovie()
        {
            Console.WriteLine("\nDelete a Movie");
            Console.WriteLine("==============================");
            // do bizz
            int id = Int32.Parse(PromptInput("Movie ID: "));
            Movie m = movieDb.FindMovies(id);
            if (m != null)
            {
                movieDb.RemoveMovie(m);
                Console.WriteLine($"Movie '{m.Title}' has been Deleted");
            }
            else
            {
                Console.WriteLine($"No movie found for id: {id}");
            }
        }

        private static void DeleteActor()
        {
            Console.WriteLine("\nDelete an Actor");
            Console.WriteLine("==============================");
            // do bizz
            int id = Int32.Parse(PromptInput("Actor ID: "));
            Actor a = actorDb.FindActors(id);
            if (a != null)
            {
                actorDb.RemoveActor(a);
                Console.WriteLine($"Actor '{a.FirstName} {a.LastName}' has been Deleted");
            }
            else
            {
                Console.WriteLine($"No actor found for id: {id}");
            }
        }


        static string PromptInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        static void DisplayMenu()
        {
            Console.WriteLine("\nMENU: ");
            Console.WriteLine("================");
            Console.WriteLine("menu - display menu ");
            Console.WriteLine("list movies - list all movies");
            Console.WriteLine("list actors - list all actors");
            Console.WriteLine("get movie - get movie by id");
            Console.WriteLine("get actor - get actor by id");
            Console.WriteLine("add movie - add a movie");
            Console.WriteLine("add actor - add an actor");
            Console.WriteLine("del movie - delete a movie");
            Console.WriteLine("del actor - delete an actor");
            Console.WriteLine("exit - exit application");
        }
    }
}
