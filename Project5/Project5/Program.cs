namespace Project5
{
    internal class Program
    {
        
        private static int Random (int minVal, int MaxVal)
        {
            return new Random().Next (minVal, MaxVal);
        }
                
        
        static void Main(string[] args)
        {
            //5-1
            Console.WriteLine("Dice Roller");            

            Boolean valid = false;
            while (!valid)
            {
                //user input - ask if the user wants to play? if not, exit!
                string choice1 = "y";
                Console.Write("\nRoll the dice? (y/n): ");
                choice1 = Console.ReadLine();

                // yes to play
                if (choice1 == "y")
                {   
                    string choice2 = "y";
                    
                    while (choice2.ToLower() == "y")
                    {
                        int die1 = Random(1, 7);
                        int die2 = Random(1, 7);

                        Console.WriteLine($"\nDie 1: {die1}");
                        Console.WriteLine($"Die 2: {die2}");
                        Console.WriteLine($"Total: {die1 + die2}");

                        // print Snake eye!
                        if (die1 == 1 & die2 == 1) {
                            Console.WriteLine("Snake eyes!");
                        }
                        else if (die1 == 6 & die2 == 6) {                                                   
                            Console.WriteLine("Boxcars!");
                        }

                        // end while loop
                        Console.Write("\nRoll again? (y/n): ");
                        choice2 = Console.ReadLine();
                    }
                }
                // no to break!
                else
                {
                    Console.WriteLine("Come back to play! Bye! ");
                    break;
                }
                Console.WriteLine("See you soon, bye!");
                valid = true;                
            }
        }
    }
}
