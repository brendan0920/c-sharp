namespace Project5_3_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Guess the Number Game!");
            Console.WriteLine("=====================================\n");

            string choice = "y";
            const int MAX_NUM = 100;
            while (choice == "y") {
                // get the random number - theNumber
                int theNumber = GetRandomNumber(MAX_NUM);
                Console.WriteLine($"Cheat: the number is {theNumber}");
                // initialize the count to 0
                int count = 0;
                // print the garme start msg
                Console.WriteLine($"I'm thinking of a muber from 1 to {MAX_NUM}.\n Try to guess it/\n");

                int guess = 0;
                while (guess != theNumber)
                {
                    // prompt user for guess
                    guess = getInt("Enter number; ", 100, MAX_NUM);
                    count++;

                    // check guess against theNumber
                    // if theNumber is 27;
                    // - guess is 10, diff -17 wtl
                    // - guess is 20, diff -7 tl
                    // - guess is 30, diff 3 th
                    // - guess is 50, diff -23 wth
                    int diff = guess - theNumber;
                    string message = "";
                    if (diff < -10)
                    {
                        message = "Way too low! Guess again.";
                    }
                    else if (diff < 0)
                    {
                        message = "Too low! Guess again.";
                    }
                    else if (diff > 0)
                    {
                        message = "Too high! Guess again.";
                    }
                    else if (diff > 10)
                    {
                        message = "Way too hight! Guess again.";
                    }
                    else
                    {
                        //winner msg
                        message = $"You got it in {count} tries.\n";
                        if (count <= 3)
                        {
                            message = "Great work! You are a mathematical wizard.";
                        }
                        else if (count <= 7)
                        {
                            message = "Not too bad! You've got some potential.";
                        }
                        else
                        {
                            message = "What took you so long? Maybe you should take some lessons.";
                        }
                    }
                    // - display watl, tl, th, wth, you win!
                    // - - on you win - display appropriate winner msg (check count)
                    Console.WriteLine(message);

                }
                choice = GetString("Continue (y/n)? ", "y", "n");
            }


        }


        private static string GetString(string prompt, string s1, string s2)
        {
            string strValue = "";
            Boolean isValid = false;
            while (!isValid)
            {
                Console.Write(prompt);
                strValue = Console.ReadLine().ToLower();
                if (strValue == "")
                {
                    Console.WriteLine("Error: entry is required.");
                    continue;
                }
                else if (strValue != s1 && strValue != s2)
                {
                    Console.WriteLine($"Error: entry must be either '{s1}' or '{s2}'.");
                    continue;
                }
                else
                {
                    break;
                }
            }
            return strValue;
        }

        private static int GetRandomNumber(int maxVal)
        {
            return new Random().Next(1, maxVal);
        }

        private static int getInt(string prompt, int min, int max)
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
