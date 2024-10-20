using System.Xml.Serialization;

namespace Project_Redo_7_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Contact List");

            List<Contact> contacts = new List<Contact>();

            string choice = "y";
            while (choice == "y")
            {
                string userFirstname = GetString("Enter first name: ");
                string userLastname = GetString("Enter last name: ");
                string userEmail = GetString("Enter email: ");
                string userphone = GetString("Enter phone: ");

                Console.WriteLine("\nCurrent Contact\n");
                Contact c = new Contact(userFirstname, userLastname, userEmail, userphone);
                contacts.Add(c);

                foreach(Contact contact in contacts)
                {
                    Console.WriteLine(contact.ToString());
                }


                choice = GetString("Continue? (y/n): ", "y", "n");
            }
            Console.WriteLine("Bye!");
        }

        // GetString
        private static string GetString(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine().ToLower();
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
