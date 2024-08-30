namespace Project15_2_Wizard_Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Wizard Inventory game");

            // Creat a list with 3 item added
            List<string> items = new List<string>
            {
                "wooden staff",
                "wizard hat",
                "cloth shoes"
            };
            List<int> numbers = new List<int>();
            string command = "";            

            while (command != "exit")
            {
                // Display a menu of options
                // show - show all items
                // edit - Edit an item
                // drop - Drop an item 
                // exit - Exit program
                // Prompt user for command
                command = GetString(GetMenu());

                //Perform that selected option
                switch (command)
                {
                    case "show":
                        //show all items
                        Console.WriteLine($"\nItems: ");                        
                        for (int i = 0; i < items.Count() ; i++)
                        {                            
                            Console.WriteLine($"{i + 1}. {items[i]}");                            
                        }
                                         
                        Console.WriteLine();
                        break;
                    case "grab":
                        //add an item                         
                        if (items.Count() != 4)
                        {
                            string item = GetString("Name: ");
                            items.Add(item);                            
                            Console.WriteLine($"{item} was add.");
                        } else
                        {
                            Console.WriteLine("You can't carry any more items. Drop something first.\n");
                            break;
                        }
                        Console.WriteLine();
                        break;
                    case "edit":
                        //edit an item
                        int nameNbr = GetInt("Number: ", 1, items.Count());
                        string itemEdit = GetString("Updated name: ");                        

                        if (nameNbr >= 0 && nameNbr < items.Count)
                        {
                            items[nameNbr] = itemEdit;
                            Console.WriteLine($"Item number {nameNbr} was updtaed");
                        }
                        else
                        {
                            Console.WriteLine("Enter a valid number and item.\n");
                        }

                        break;
                    case "drop":
                        //remove items
                        //Console.WriteLine("\nRemove a Name:");
                        nameNbr = GetInt("Number: ", 1, items.Count());
                        items.RemoveAt(nameNbr - 1);
                        Console.WriteLine("item removed.\n");
                        break;
                    case "exit":
                        //exit
                        Console.WriteLine("Bye!");
                        break;
                }
            }
        }

        static string GetMenu()
        {
            string menu = "COMMAND MENU:\n" +
                          "show - Show all items\n" +
                          "grab - grab an item\n" +
                          "edit - edit an item\n" +
                          "drop - Drop an item\n" +
                          "exit - Exit program\n" +
                          "Command: ";
            return menu;
        }


        private static string GetString(string prompt)
        {
            Console.Write(prompt);
            string strValue = Console.ReadLine();
            return strValue;
        }



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


    }
}
