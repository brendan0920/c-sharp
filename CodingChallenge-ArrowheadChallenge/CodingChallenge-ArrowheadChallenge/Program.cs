namespace CodingChallenge_ArrowheadChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Arrowhead Challenge!");

            // user input: number
            
            Console.Write("\nWhat size of an arrowhead do you want? : ");
            int input = Int32.Parse(Console.ReadLine());

            if (input % 2 != 0) // Odd number
            {
                int arrow = 1;
                for (int i = 0; i <= input-1; i++) 
                {
                    Console.WriteLine(">");
                    for (int j = 1; j <= arrow -1; j++)
                    {
                        input++;
                        Console.WriteLine(input);
                        Console.WriteLine(">");
                    }
                    
                    Console.WriteLine();
                    arrow++;
                }
            }




            Console.WriteLine("Bye!");
        }

        
    }
}
