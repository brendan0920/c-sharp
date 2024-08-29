namespace Project5_2_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            const double MIN_DOUBLE = 1;
            const double MAX_DOUBLE = 1000;

            // + while look start - choice
            string choice = "y";
            while (choice == "y")
            {
                // get input
                // validation:
                // - entries msut be doubles
                // - entries mush be greater than 0

                double length = getDouble("Enter length: ", MIN_DOUBLE, MAX_DOUBLE);
                double width = getDouble("Enter width: ", MIN_DOUBLE, MAX_DOUBLE); ;

                // do logic
                double area = length * width;
                double perimeter = (length + width) * 2;

                //display output
                //dusplay are and perimeter
                Console.WriteLine($"Area: {area}");
                Console.WriteLine($"Perimeter: {perimeter}");

                // + while loop end
                // validation - choice: y or n , can't be empty
                choice = getString("Continue (y/n) ?", "y", "n");
            }

            Console.WriteLine("Bye");
        }

        // get a required string (empty value not accepted) that is either s1 or s2
        private static string getString(string prompt, string s1, string s2) {
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
                    Console.WriteLine{ $"Error: entry must be either '{s1}' or '{s2}'."};
                    continue;
                } else
                {
                    break;
                }

            }

            return strVal;
        }




        private static double getDouble(string prompt, double min, double max)
        {
            double number = 0.0;
            Boolean isValid = false;

            while (!isValid) 
            {
                try
                {
                    Console.Write(prompt);
                    number = Double.Parse(Console.ReadLine());
                    if (number < min) 
                    {
                        Console.WriteLine($"Invalid entry: number less than min ({min})");
                        continue;
                    } else if (number > max)
                    {
                        Console.WriteLine($"Invalid entry: number greater than max ({max})");
                        continue;
                    } else
                    {
                        break;
                    }


                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid entry: please enter a valid double.");
                    continue;
                }
            }

            return number;
        }

    }
}
