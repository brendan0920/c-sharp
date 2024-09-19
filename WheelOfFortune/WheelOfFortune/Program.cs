using WheelOfFortune.Model;

namespace WheelOfFortune
{
    internal class Program
    {
        // initialize global variables
        // Note: tech decision made: storing values as strings, but these could be ints
        static List<string> wheelValues = new List<string>
        {
            "BANKRUPT!!", "Lose a Turn!", "$100", "$150", "$200", "$250", "$300", "$350", "$400", "$450", "$500",
                                       "$550", "$600", "$650", "$700", "$750", "$850", "$900"
        };

        // do we need an overallBank? Could just add roundBanks?
        decimal overallBank = 0.0m;
        decimal[] roundBanks = {0.0m, 0.0m, 0.0m};


        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Wheel of Fortune!\n");
            Console.WriteLine("Instructions go here.\n");
            // initialize local variables
            // do variables go here, or at the class level?


            // words instance
            WofPhrases words = new WofPhrases();

            
            // do the logic
            // while loop
            string choice = "Y";
            while (choice == "Y")
            {
                // what's a 'game'? ==> one round of wof                
                // - initialize single game local variables

                for (int i = 0; i < 3; i++)
                {
                    // ** Beginning of a Round!
                    // Display "welcome to round {i}" message
                    // initialize the bank (set a variable to track the roundBank)
                    // get the 'roundPhrase' from WofPhrases class
                    // generate 'hiddenPhrase'
                    // display 'hiddenPhrase'(either inside or outside the while loop?)
                    // while loop for gameplay (loop until user guesses the phrase)
                        // prompt (spin, voewl, or guessPhrase)
                        // - if spin
                        //   - spin wheel
                        //    - bankrupt(zero roundBalance, continue) /
                        //    - lose a turn (continue) /
                        //    - get $ amount, guess letter
                        //       - check 'roundPhrase' for letter 
                        //         - if exists, resolve letter in 'hiddenPhrase'
                        //           - add $$ to roundBank
                        //         - if not exist, continue
                        //   - buyVowel
                        //     - if enough $$ prompt for vowel
                        //       - deduct from roundBank
                        //       - if vowel exists, resolve in word, deduct from roundBank
                        //       - if vowel not exists, continue
                        //   - guessPhrase
                        //      - prompt for guess
                        //      - if correct win
                        //      - else continue
                        //   - round ends when 'roundPhrase' is guessed, ends this iteration of for loop
                        // - when does a player win or lose?
                    

                }

                choice = PromptString("Play again? ", ["Y", "N"]);
            }
        }

        // Need a WofPhrases class, similar to HangmanWords
        // get a random phrase - remove the phrase once used

        // Validation Methods?

        // Wheel - how do we manage the weel values?

        // Bank - how do we manage our bank?
        //      - do round winnings go in a master bank or just add up over the rounds?




        private void SpinWheel()
        {
            
        }

        private int RandomInt()
        {
            Random random = new Random();
            return random.Next();
        }

        private static string Wheel()
        {
            // 19 segmetns
            // 1 - Bankrupt(bank to zero)  
            // 2 - Lose a turn
            // 3 - 19 (17) - $100 - $900 (every $50)  
            List<string> wheel = new List<string> { "BANKRUPT", "Lose a Turn", "$100", "$150", "$200", "$250", "$300", "$350", "$400", "$450", "$500",
                                       "$550", "$600", "$650", "$700", "$750", "$850", "$900"};
            

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


        private static string PromptString(string prompt, string[] validStrings)
        {
            string goodString = "";
            Boolean isValid = false;
            while (!isValid)
            {
                Console.Write(prompt);                
                goodString = Console.ReadLine().ToUpper();
                foreach (string s in validStrings)
                {
                    if (s == goodString)
                    {
                        isValid = true;
                        break;
                    }
                }
            }
            return goodString;

        }




        private static decimal Bank()
        {

        }

        private static string DisplayStatus()
        {

        }







    }
}
