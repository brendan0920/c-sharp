namespace CodingChallenge_MakeChocolate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's make Chocolate!\n");

            // (4, 1, 9); -> 4
            // (4, 1, 10); -> -1
            // (4, 1, 7); -> 2

            // I'd like to add user's input....

            int result = MakeChocolate(4, 1, 7);
            if (result != -1)
            {
                Console.WriteLine($"You will USE {result}ea of small bars!");
            }
            else
            {
                Console.WriteLine("You have not enough of small bars!!");
            }
        }

        public static int MakeChocolate(int small, int big, int goal)
        {               
            // small 1kg
            // big 5kg
            int kgNeed = goal - (big * 5);
            if (kgNeed <= small)
            {
                return kgNeed;
            } else
            {
                return -1;                
            }
        }

        private static int GetString(int one, int five, int goal)
        {
            Console.Write( one, int five, int goal);
            return Int32.Parse(Console.ReadLine().ToLower());
        }
    }
}
