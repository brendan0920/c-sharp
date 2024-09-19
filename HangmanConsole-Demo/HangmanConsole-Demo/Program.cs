using HangmanConsole_Demo.Model;
using System.Security.Cryptography;

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
                    //Console.WriteLine($"Hint: {word}");
                    Console.WriteLine($"Hidden word: {words.DisplayHiddenWord(hiddenWord)}");
                    Console.WriteLine($"letters guessed: {GetLettersGuessedString(lettersGuessed)}");
                    Console.WriteLine("================================================");
                    string letterGuess = PromptInput("Enter a letter: ");
                    
                    // if letterGuess is NOT in lettersGuessed:
                    if (lettersGuessed.IndexOf(letterGuess) < 0)
                    {
                        lettersGuessed.Add(letterGuess);
                        // -- is letterGuess in word?
                        if (word.IndexOf(letterGuess) >= 0)
                        {
                            //   -- update hiddenWord w/ letterGuess
                            hiddenWord = UpdateHiddenWord(word, hiddenWord, Char.Parse(letterGuess));
                            //   -- check hiddenWord = if no underscores remain:
                            if (hiddenWord.IndexOf('_') < 0)
                            {
                                // -- wordGuessd = true                    
                                wordGuessed = true;
                            }
                        } 
                        // -- else
                        else
                        {
                            //   -- increment incorrectGuesses by 1
                            incorrectGuesses++;
                        }
                    }
                    // else
                    else
                    {
                        // -- display a message (letter already guessed, try again)
                        Console.WriteLine("letters have been guessed already, try again");
                    }                    
                }

                // display win or loss messege
                if (wordGuessed)
                {
                    Console.WriteLine("You won!");
                    Console.WriteLine($"The word was '{words.DisplayHiddenWord(hiddenWord)}'");
                }
                else
                {
                    // display the hangman image?
                    Console.WriteLine(GetHangmanImage(incorrectGuesses));
                    Console.WriteLine("You lost, Sorry try again!");
                    // display the word?
                    Console.WriteLine($"The word was '{word}'.");
                }                

                choice = PromptInput("Play again? (y/n)");
            }
            Console.WriteLine("Bye!");
        }

        private static string UpdateHiddenWord(string word, string hiddenWord, char letterGuess)
        {
            // accepting hiddenWord (underscoredVersion of word)
            // we know te letterGuess exists in word
            // loop through word, find the index positions where the letterGuess occurs
            //   - then change hiddenWord, at those index positions, to replace that indexposition with letterGuess
            char[] wordCharArray = word.ToCharArray();
            char[] hiddenWordCharArray = hiddenWord.ToCharArray();
            for (int i = 0; i < wordCharArray.Length; i++)
            {
                if (wordCharArray[i] == letterGuess)
                {
                    hiddenWordCharArray[i] = letterGuess;
                }
            }
            return new string(hiddenWordCharArray);
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
