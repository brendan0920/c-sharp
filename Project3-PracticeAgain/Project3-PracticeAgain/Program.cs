using System;

namespace Project3_PracticeAgain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3-1
            //Console.WriteLine("Welcome to the Temperature Converter");

            //string choice = "y";
            //while (choice.ToLower() == "y")
            //{
            //    Console.Write("\nEnter degree in Fahrenheit: ");
            //    double farh = Double.Parse(Console.ReadLine());

            //    double c = (farh - 32) * 5 / 9;
            //    string formattedC = c.ToString("f2");

            //    Console.WriteLine($"Degrees in Celsius: {formattedC}");

            //    Console.Write("\nContinue? (y/n): ");
            //    choice = Console.ReadLine();
            //}


            //3-2
            //Console.WriteLine("Welcome to the Travel Time Calculator");

            //string choice = "y";
            //while (choice.ToLower() == "y")
            //{
            //    Console.Write("\nEnter miles: ");
            //    double mile = Double.Parse(Console.ReadLine());

            //    Console.Write("Enter miles per hour: ");
            //    double mph = Double.Parse(Console.ReadLine());

            //    int hour = (int)(mile / mph);
            //    double min = ((mile / mph) - hour) * 60;
            //    int FormattedMin = (int)min;

            //    Console.WriteLine("Estimated Travel Time");
            //    Console.WriteLine("---------------------");
            //    Console.WriteLine($"Hours: {hour}");
            //    Console.WriteLine($"Minutes: {FormattedMin}");

            //    Console.Write("\nContinue? (y/n): ");
            //    choice = Console.ReadLine();
            //}


            //3-3
            //Console.WriteLine("Welcome to the Interest Calculator");

            //string choice = "y";
            //while (choice.ToLower() == "y")
            //{
            //    Console.Write("\nEnter loan amount: ");
            //    double loan = Double.Parse(Console.ReadLine());
            //    string formattedLoan = loan.ToString("c2");


            //    Console.Write("Enter interest rae: ");
            //    double rate = Double.Parse(Console.ReadLine());
            //    string formattedRate = rate.ToString("p3");

            //    Console.WriteLine($"\nLoan amount: {formattedLoan}");
            //    Console.WriteLine($"Interest rate: {formattedRate}");
                
            //    double total = (loan * rate);
            //    string formattedTotal = total.ToString("c2");
            //    Console.WriteLine($"Loan amount: {formattedTotal}");

            //    Console.Write("\nContinue? (y/n): ");
            //    choice = Console.ReadLine();
            //}


            //3-4
            Console.WriteLine("Welcome to the Change Calculator");

            string choice = "y";
            while (choice.ToLower() == "y")
            {

                Console.Write("\nEnter number of cents (0-99): ");
                int cents = Int32.Parse(Console.ReadLine());

                int quarters = cents / 25;
                int remainder = cents % 25;
                int dimes = remainder / 10;
                remainder = remainder % 10;
                int nickles = remainder / 5;
                remainder = remainder % 5;
                int pennies = remainder;

                Console.WriteLine($"Quaters: {quarters}");
                Console.WriteLine($"Dimes: {dimes,3}");
                Console.WriteLine($"Nickles: {nickles}");
                Console.WriteLine($"Pennies: {pennies}");

                Console.Write("\nContinue? (y/n): ");
                choice = Console.ReadLine();
            }

        }
    }
}
