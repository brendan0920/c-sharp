namespace Project_Redo_5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Area and Perimeter Calculator!");

            string choice = "y";
            while (choice == "y")
            {
                double length = GetDouble("Enter length: ", 0.0, 100000.0);
                double width = GetDouble("Enter width: ", 0.0, 100000.0);

                double area = (length * width);
                double perimeter = (length + width) * 2;

                Console.WriteLine($"Area: {area:f2}");
                Console.WriteLine($"Perimeter: {perimeter:f2}");

                choice = GetString("Continue? (y/n): ", "y", "n");
                
            }
            Console.WriteLine("Bye!");
        }



        // GetString
        private static string GetString(string prompt, string s1, string s2)
        {
            string strValue = "";
            Boolean isValid = false;
            while (!isValid)
            {
                Console.Write(prompt);
                strValue = Console.ReadLine().ToLower();
                if (strValue == "")
                {
                    Console.WriteLine("Error: entry is required.");
                    continue;
                }
                else if (strValue != s1 && strValue != s2)
                {
                    Console.WriteLine($"Error: entry must be either '{s1}' or '{s2}'.");
                    continue;
                }
                else
                {
                    break;
                }
            }
            return strValue;
        }

        // GetInt
        private static int GetInt(string prompt, int min, int max)
        {
            int number = 0;
            Boolean isValid = false;
            while (!isValid)
            {
                try
                {
                    Console.Write(prompt);
                    number = Int32.Parse(Console.ReadLine());
                    if (number < min)
                    {
                        Console.WriteLine($"Invalid entry: number less than min ({min})");
                        continue;
                    }
                    else if (number > max)
                    {
                        Console.WriteLine($"Invalid entry: number greater than max ({max})");
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid entry: please enter a valid integer.");
                    continue;
                }
            }
            return number;
        }

        // GetDecimal
        private static decimal GetDecimal(string prompt, decimal min, decimal max)
        {
            decimal number = 0.0m;
            Boolean isValid = false;

            while (!isValid)
            {
                Console.Write(prompt);
                Boolean success = decimal.TryParse(Console.ReadLine(), out number);
                if (!success)
                {
                    Console.WriteLine("Invalid entry: please enter a valid decimal.");
                }
                else
                {
                    if (number < min)
                    {
                        Console.WriteLine($"Invalid entry: number less than min ({min})");
                        continue;
                    }
                    else if (number > max)
                    {
                        Console.WriteLine($"Invalid entry: number greater than max ({max})");
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return number;
        }

        private static double GetDouble(string prompt, double min, double max)
        {
            double douVal = 0.0;
            Boolean isValid = false;

            while (!isValid)
            {
                try
                {
                    Console.Write(prompt);
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
                    else
                    {
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error:please enter a valid double.");
                    continue;
                }
            }
            return douVal;
        }


    }
}
