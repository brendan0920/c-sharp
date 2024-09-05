using System.Security.Cryptography.X509Certificates;
using System.Xml.XPath;

namespace Ch05_Demo
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
            Console.WriteLine("Welcome to the Interest Calculator");

            string choice = "y";
            while (choice.ToLower() == "y")
            {
                Console.Write("\nEnter loan amount: ");
                decimal loan = Decimal.Parse(Console.ReadLine());
                

                //Console.Write("\nEnter interest rae: ");
                //double rate = Double.Parse(Console.ReadLine());

                Cosole.WriteLine($"Loan amount: {loan.ToString("c")("f2")}");




                Console.Write("\nContinue? (y/n): ");
                choice = Console.ReadLine();
            }







        }    
    }
}
