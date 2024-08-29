namespace Project5_1_Demo
{
    internal class Program
    {
        private static int Random()
        {
            return new Random().Next(1, 7);
        }

        private static string getString(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine().ToLower();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Dice Roller!");

            // start of while loop
            // user input - roll again? (y/n)
            string rollDice = getString("Roll the dice (y/n) ?");
            while (rollDice == "y")
            {
                // biz logic - roll the dice and calc the sum
                // generate two random ints between 1 and 6
                int die1 = Random();
                int die2 = Random();
                int sum = die1 + die2;

                //display output - die rolls , sum , special msg
                Console.WriteLine($"\nDie 1: {die1}");
                Console.WriteLine($"Die 2: {die2}");
                Console.WriteLine($"Total: {sum}");
                if (sum == 2)
                {
                    Console.WriteLine($"Snake Eyes!");
                }
                else if (sum == 12)
                {
                    Console.WriteLine($"Box cars!");
                }
                Console.WriteLine("");

                // end of while loop
                rollDice = getString("Roll again (y/n) ? ");
            }
            Console.WriteLine("bye!");

        }
    }
}
