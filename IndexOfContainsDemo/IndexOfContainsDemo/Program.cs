namespace IndexOfContainsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // word guess game example - does a letter occur in the word?

            string theWord = "superstar";

            while (true)
            {
                Console.Write("Guess a letter: ");
                string letter = Console.ReadLine();

                if (letter == "exit")
                {
                    break;
                }
                // does the letter exist in the word?
                // indexOf...
                Console.WriteLine($"theWord.IndexOf(letter): {theWord.IndexOf(letter)}");

                // contains
                Console.WriteLine($"theWord.Contains(letter): {theWord.Contains(letter)}");


            }
        }
    }
}
