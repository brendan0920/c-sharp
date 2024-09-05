namespace Project5_ProjectAgain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4-1
            //Console.WriteLine("Welcome to the Squares and Cubes table");            


            //// while loop
            //string choice = ("y");
            //while (choice.ToLower() == "y")
            //{
            //    Console.Write("\nEnter an integer: ");
            //    int enterInt = Int32.Parse(Console.ReadLine());
            //    // header
            //    Console.WriteLine("\nNumber\tSquared\tCubed");
            //    Console.WriteLine("======\t=======\t=====");
            //    // for loop of range 1 - 9
            //    for (int i = 1; i <= enterInt; i++) {
            //        int squared = i * i;
            //        int cubed = i * squared;

            //        Console.WriteLine($"{i}\t{squared}\t{cubed}");
            //    }
            //    // end while loop
            //    Console.Write("\nContinue? (y/n): ");
            //    choice = Console.ReadLine();
            //}


            //4-2
            //Console.WriteLine("Welcome to the Factorial Calculator");

            //string choice = ("y");
            //while (choice.ToLower() == "y")
            //{
            //    Console.Write("\nEnter an integer that's greater than 0 and less than 10: ");
            //    int enterInt = Int32.Parse(Console.ReadLine());

            //    if (enterInt > 0 && enterInt < 10)
            //    {
            //        long facto = 1;
            //        //calculate the factorial
            //        for (int i = 1; i <= enterInt; i++)
            //        {
            //            facto *= i;
            //        }
            //        Console.WriteLine($"The factorial of {enterInt} is {facto}.");                    
            //    } else
            //    {
            //        Console.WriteLine("Please enter valid integer. Try again!");
            //        continue;
            //    }

            //    Console.Write("\nContinue? (y/n): ");
            //    choice = Console.ReadLine();
            //}


            // 4-3
            //Console.WriteLine("Tip Calculator");

            //string choice = ("y");
            //while (choice.ToLower() == "y")
            //{
            //    Console.Write("\nCost of meal: ");
            //    decimal cost = Decimal.Parse(Console.ReadLine());

            //    Console.WriteLine("\n15%");
            //    decimal tip15 = (cost * 0.15m);
            //    decimal tip15Total = (cost + tip15);
            //    decimal ftip15 = Math.Round(tip15, 2);
            //    decimal f15Total = Math.Round(tip15Total, 2);
            //    Console.WriteLine($"Tip amount:   {ftip15}");
            //    Console.WriteLine($"Total amount: {f15Total}");

            //    Console.WriteLine("\n20%");
            //    decimal tip20 = (cost * 0.2m);
            //    decimal tip20Total = (cost + tip20);
            //    decimal ftip20 = Math.Round(tip20, 2);
            //    decimal f20Total = Math.Round(tip20Total, 2);
            //    Console.WriteLine($"Tip amount:   {ftip20}");
            //    Console.WriteLine($"Total amount: {f20Total}");

            //    Console.WriteLine("\n25%");
            //    decimal tip25 = (cost * 0.25m);
            //    decimal tip25Total = (cost + tip25);
            //    decimal ftip25 = Math.Round(tip25, 2);
            //    decimal f25Total = Math.Round(tip25Total, 2);
            //    Console.WriteLine($"Tip amount:   {ftip25}");
            //    Console.WriteLine($"Total amount: {f25Total}");

            //    Console.Write("\nContinue? (y/n): ");
            //    choice = Console.ReadLine();
            //}



            //4-4
            //Console.WriteLine("Greatest Common Divisor Finder");

            //string choice = ("y");
            //while (choice.ToLower() == "y")
            //{
            //    Console.Write("\nEnter first number: ");
            //    int x = Int32.Parse(Console.ReadLine());
            //    Console.Write("Enter second number: ");
            //    int y = Int32.Parse(Console.ReadLine());
            //    while (x != 0)
            //    {
            //        while (x <= y)
            //        {
            //            y -= x;
            //        }
            //        int swap = x;
            //        x = y;
            //        y = swap;

            //    }
            //    Console.WriteLine($"Greatest Common divisor: {y}");

            //    Console.Write("\nContinue? (y/n): ");
            //    choice = Console.ReadLine();
            //}

            //5-1
            //Console.WriteLine("Dice Roller\n");


            //string rollDice = GetString("Roll the dice? (y/n) :"); ;
            //while (rollDice == "y")
            //{
            //    int die1 = Random();
            //    int die2 = Random();
            //    int total = die1 + die2;

            //    Console.WriteLine($"Die 1: {die1}");
            //    Console.WriteLine($"Die 2: {die2}");
            //    Console.WriteLine($"Total: {total}");

            //    if (total == 2)
            //    {
            //        Console.WriteLine("Snake eyes!");
            //    }
            //    else if (total == 12) { 
            //        Console.WriteLine("Boxcars!");
            //    }

            //    rollDice = GetString("\nRoll again? (y/n): ");
            //}

            //5-2
            Console.WriteLine("Welcome to the Area and Perimeter Calculator");

            string choice = "y";
            while (choice == "y")
            {
                double len = GetDouble("\nEnter length: ", 1, 1000);
                double width = GetDouble("Enter width: ", 1, 1000);

                double area = len * width;
                double perimeter = (len + width) * 2;

                Console.WriteLine($"Area: {area}");
                Console.WriteLine($"Perimeter: {perimeter}");

                
                choice = GetString("Continue: (y/n) ", "y","n");
            }

        }

        




        private static int Random() {
            return new Random().Next(1, 7);
        }


        private static string GetString(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine().ToLower();
        }


        private static string GetString(string prompt, string s1, string s2) {
            string strVal = "";
            Boolean isValid = false;

            while (!isValid) {
                Console.Write(prompt);
                strVal = Console.ReadLine().ToLower();

                if (strVal == "")
                {
                    Console.WriteLine("Error: entry is required.");
                    continue;
                }
                else if (strVal != s1 && strVal != s2)
                {
                    Console.WriteLine($"Error: entry must be either '{s1} or {s2}'.");
                    continue;
                }
                else {
                    break;
                }
            }
            return strVal;
        }

        private static double GetDouble(string prompt, double min, double max) 
        {
            double douVal = 0.0;
            Boolean isValid = false;

            while(!isValid)
            {
                try {
                    Console.WriteLine(prompt);
                    douVal = Double.Parse(Console.ReadLine());

                    if (douVal < min)
                    {
                        Console.WriteLine($"Error: entry must be greater than '{min}'.");
                        continue;
                    }
                    else if (douVal > max)
                    {
                        Console.WriteLine($"Error: entry must be less than '{max}'.");
                        continue;
                    }
                    else {
                        break;
                    }
                }
                catch (Exception e) {
                    Console.WriteLine("Error:please enter a valid double.");
                    continue;
                }
            }
            return douVal;
        }    
    }
}
