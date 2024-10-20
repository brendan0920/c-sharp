namespace Project_Redo_4_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Greatest Common Divisor Finder");

            string choice = "y";
            // while
            while (choice.ToLower() == "y")
            {
                // user prompt
                Console.Write("\nEnter first number: ");
                int y = Int32.Parse(Console.ReadLine());
                Console.Write("Enter second number: ");
                int x = Int32.Parse(Console.ReadLine());
                // logic
                while (x > 0)
                {
                    while (y >= x)
                    {
                        y -= x;
                    }
                    int swap = y;
                    y = x;
                    x = swap;
                }
                Console.WriteLine($"Greatest common divisor: {y}");

                // end - while 
                Console.Write("\nContinue? (y/n): ");
                choice = Console.ReadLine();
            }
            Console.WriteLine("Bye!");
        }
    }
}
