using System.Diagnostics.Metrics;

namespace JustPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            string choice = "y";
            while (choice == "y")
            {
                Console.Write("How many arrows?: ");
                int arrows = Int32.Parse(Console.ReadLine());

                if (arrows % 2 == 0)
                {
                    for (int i = 1; i <= arrows/2; i++)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    for (int i = (arrows / 2); i >= 0; i--)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    for (int i = 1; i <= arrows / 2; i++)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    for (int i = (arrows / 2) + 1; i >= 0; i--)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                }


                Console.Write("continue? (y/n): ");
                choice = Console.ReadLine();
            }



        }
    }
}
