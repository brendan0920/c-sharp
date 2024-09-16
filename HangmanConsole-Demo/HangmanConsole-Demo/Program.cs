using HangmanConsole_Demo.Model;

namespace HangmanConsole_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Hangman Game!\n");
            Console.WriteLine("Rules of the gaem - filled in later\n");

            HangmanWords words = new HangmanWords();


            String hangman = """
                -----
                |   |
                |   O
                |  /|\
                |  / \
                |
                -------
                """;
            Console.WriteLine(hangman);

            string choice = "y";
            while (choice == "y")
            {
                // game initialization
                string word = words.GetRandomWord();
                string hiddenWord = words.GetHiddenWord(word);
                int incorrectGuesses = 0;
                Boolean wordGuessed = false;
                List<string> lettersGuessed = new List<string>();

                while (incorrectGuesses != 6 && !wordGuessed)
                {
                    Console.WriteLine(GetHangmanImage(incorrectGuesses));
                    Console.WriteLine($"Hint: {word}");
                    Console.WriteLine($"Hidden word: {words.DisplayHiddenWord(hiddenWord)}");
                    Console.WriteLine($"letters guessed: {GetLettersGuessedString(lettersGuessed)}");
                    Console.WriteLine("================================================");
                    string letterGuess = PromptInput("Enter a letter: ");
                    // if letterGuess is NOT in lettersGuessed:
                    if (letterGuess != lettersGuessed)
                    {

                    }
                    // -- is letterGuess in word?
                    //   -- update hiddenWord w/ letterGuess
                    //   -- check hiddenWord = if no underscores remain:
                    //     -- wordGuessd = true                    
                    // -- else if
                    //   -- increment incorrectGuesses by 1
                    // -- else
                    // -- display a message (letter already guessed, try again)




                }
                // display win or loss messege
                // display the hangman image?
                // display the word?

                choice = PromptInput("Play again? (y/n)");
            }
            Console.WriteLine("Bye!");
        }

        private static string PromptInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        private static string GetLettersGuessedString(List<string> lettersGuessed)
        {
            string str = "";
            if (lettersGuessed.Count != 0)
            {
                foreach (string s in lettersGuessed) 
                {
                    str += (s + " ");
                }
            }
            return str;
        }

        private static string GetHangmanImage(int incorrectGuesses)
        {
            string[] imanges = {
                """
                -----
                |   |
                |   
                |  
                |  
                |
                -------
                """,
                """
                -----
                |   |
                |   O
                |   
                |  
                |
                -------
                """,
                """
                -----
                |   |
                |   O
                |   |
                |  
                |
                -------
                """,
                """
                -----
                |   |
                |   O
                |  /|
                |  
                |
                -------
                """,
                """
                -----
                |   |
                |   O
                |  /|\
                |  
                |
                -------
                """,                
                """
                -----
                |   |
                |   O
                |  /|\
                |  / 
                |
                -------
                """,
                """
                -----
                |   |
                |   O
                |  /|\
                |  / \
                |
                -------
                """
            };
            return imanges[incorrectGuesses];
        }
    }
}
