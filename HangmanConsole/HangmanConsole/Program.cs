namespace HangmanConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hangman!");

            string completedHangman = @"            
            -----
            |   |
            |   O
            |  /|\
            |  / \
            |
            -------
            Bye
            ";

            Console.WriteLine(completedHangman);

        }


    }
}
