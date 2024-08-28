using System.Transactions;

namespace project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // Project 3-1; Temperature Converter

            //Console.WriteLine("Welcome to the Temperature Converter");

            //// satrt continue loop
            //string choice = "y";
            //while (choice.ToLower() == "y")
            //{
            //    // get user input
            //    Console.Write("\nEndter degrees in Fahrenheit: ");
            //    decimal degreeFah = decimal.Parse(Console.ReadLine());
            //    decimal convertToCel = (degreeFah - 32) * 5 / 9;
            //    decimal celRounded = Math.Round(convertToCel, 2);
            //    Console.WriteLine("Degrees in Celsius: " + celRounded);

            //    // end continue loop
            //    Console.Write("\nContinue? (y/n)? ");
            //    choice = Console.ReadLine();
            //}

            // Project 3-2; Travel Time Calculator
            /*
            Console.WriteLine("Welcome to the Travel Time Calculator");

            // satrt continue loop
            string choice1 = "y";
            while (choice1.ToLower() == "y")
            {
                // get user input
                Console.Write("\nEnter miles: ");
                double miles = Double.Parse(Console.ReadLine());
                Console.Write("\nEnter miles per hour: ");
                double mph = Double.Parse(Console.ReadLine());

                //double miles2decimal = Math.Round(miles, 2);
                //double mph2decimal = Math.Round(mph, 2);

                double hours = miles / mph;
                int hoursInt = (int)hours;

                double minutes = (hours - hoursInt) * 60;
                //double minConvert = minutes * 60;
                int minInt = (int)(Math.Round(minutes));

                Console.WriteLine("\nEstimated travel time");
                Console.WriteLine("\n---------------------");
                Console.WriteLine($"\nHours: {hoursInt}");
                Console.WriteLine($"\nMinutes: {minInt} ");

                // end continue loop
                Console.Write("\nContinue? (y/n)? ");
                choice1 = Console.ReadLine();
            }
            */
            /* 3-2 answer..
                
            // Get user input - miles, mph
            Console.Write("Enter miles traveled: ");
            double miles = Double.Parse(Console.ReadLine());
            Console.Write("Enter mph: ");
            double miles = Double.Parse(Console.ReadLine());

            // Do the logic
            double hours = miles / mph;
            Console.WriteLine($"Hours: {hours}");
            int hoursInt = (int)hours;
            Console.WriteLine($"Hours: {hoursInt}");

            double minutes = (int)((miles / mph) - hoursInt) * 60;
            Console.WirteLine($"Minutes: {minutes}");

            */

            // projetct 3 -3
            Console.WriteLine("Welcome to the Interest Calculator");

            string choice2 = "y";
            while (choice2.ToLower() == "y")
            {
                //user input
                Console.Write("\nEnter loan amount: ");
                double loan = Double.Parse(Console.ReadLine());
                Console.Write("\nEnter interst rate: ");
                double interest = Double.Parse(Console.ReadLine());

                double interestCalcu = loan * interest;

                //loan amount up to 2 decimal then formatting                    
                string loanFormatted = loan.ToString("c2");

                //interest rate up to 3 decimal then formatting                    
                string interestRateFormatted = interest.ToString("p3");

                // formatting interest                
                string interestFormatted = interestCalcu.ToString("c2");

                //display output
                Console.WriteLine($"\nLoan amount: {loanFormatted}");
                Console.WriteLine($"interest rate: {interestRateFormatted}");
                Console.WriteLine($"interest: {interestFormatted}");

                // end continue loop
                Console.Write("\nContinue? (y/n)? ");
                choice2 = Console.ReadLine();
            }



                //project 3-4


                //get user input -
                //Console.WriteLine("Enter number of cents: ");
                //int cents = Int32.Parse(Console.ReadLine());



                ////biz logic
                ////quarters, dimes, nickles, pennies from cents
                ////use integer math                
                //int quarters = cents / 25;
                //int remainder = cents % 25;
                //int dimes = remainder / 10;
                //remainder = remainder % 10;
                //int nickles = remainder / 5;
                //remainder = remainder % 5;
                //int pennies = remainder;

                ////display output - display # of each coin type
                //Console.WriteLine($"quarters: {quarters}");
                //Console.WriteLine($"dimes: {dimes}");
                //Console.WriteLine($"nickles: {nickles}");
                //Console.WriteLine($"pennies: {pennies}");    

        }
    }
}
