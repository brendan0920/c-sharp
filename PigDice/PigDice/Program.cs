namespace PigDice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Pig Dice");

            string rollDice = GetString("\nRoll the dice (y/n) ?");
            while (rollDice == "y")
            {
                //DateTime start = DateTime.Now;

                Random random = new Random();
                                
                int maxVal = 0;
                int totalScore = 0;
                int numberOfPlay = 0;
                bool isValid = false;
                while (!isValid)
                {                    
                    int dice = random.Next(1, 7);
                    if (dice == 1)
                    {   
                        break;
                    }
                    totalScore += dice;
                    numberOfPlay++;
                }
                Console.WriteLine($"\nYou have played {numberOfPlay} games\nYour Total Score is {totalScore}");
                                
                //DateTime finish = DateTime.Now;
                //Console.WriteLine($"\nTotal runtime: {start - finish}");
                rollDice = GetString("\nPlay again? (y/n): ");

            }
        }
            private static string GetString(string prompt)
            {
                Console.Write(prompt);
                return Console.ReadLine().ToLower();
            }
    }
}
