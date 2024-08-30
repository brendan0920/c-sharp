namespace Project15_2_Wizard_Demo
{
    internal class Program
    {

        // inventory is now a class property to be accessible by all methods throughout Program

        static List<string> inventory = new List<string>
        {
            "wooden staff",
            "wizard hat",
            "cloth shoes"
        };

        static void Main(string[] args)
        {
            Console.WriteLine("The Wizard Inventory game");

            // notes / other requirements; 
            // - initialize an initial inventory with items
            // - use our GetInt and GetString for data validation


            // get user input
            // - display menu
            // - prompt for the 'command'
            DisplayMenu();
            // while command != exit
            string command = "";
            while (command != "exit")
            {
                command = GetString("Command: ");
                // business logic
                // - evaluate 'command/ and perform appropriate action;
                // *** switch statement??
                switch (command)
                {
                    case "menu":
                        DisplayMenu();
                        break;
                    // - show : list all items
                    case "show":
                        ShowInventory();
                        Console.WriteLine();
                        break;
                    // - grab :add an item (Limit items 4 - )
                    case "grab":
                        Console.WriteLine("\n***Grab An Item***");
                        string newItem = GetString("New Item Name: ");
                        if (inventory.Count != 4)
                        {
                            inventory.Add(newItem);
                            Console.WriteLine($"{newItem} was added!\n");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("You can't carry any more items. Drop something first.");                            
                        }
                        break;
                    // - edit : prompt use for item #, updated item name, 
                    case "edit":
                        Console.WriteLine("\n***Edit An Item***");
                        int itemNum = GetInt("Edit Item #: ", 1, inventory.Count);
                        string updatedName = GetString("Name to update: ");
                        //save updated name, display conf
                        inventory[itemNum - 1] = updatedName;
                        Console.WriteLine($"{itemNum} has been updated!\n");
                        break;
                    // - drop : prompt use for item #, 
                    case "drop":
                        Console.WriteLine("\n***Drop An Item***");
                        itemNum = GetInt("Item # to remove: ", 1, inventory.Count());
                        //remove item by #, display conf
                        string delItem = inventory[itemNum - 1];
                        inventory.Remove(delItem);
                        Console.WriteLine($"{delItem} has been removed!\n");
                        break;
                    // - exit : exit the game
                    case "exit":
                        Console.WriteLine("\n***Exit***");
                        break;
                    default:
                        Console.WriteLine("Invalid command. Try again/");
                        break;
                }

                // display output
            }

            Console.WriteLine("Bye!");
        }

        private static void ShowInventory()
        {
            Console.WriteLine("\n***Show All Items***");
            for (int i = 0; i < inventory.Count(); i++)
            {
                Console.WriteLine($"{i + 1}. {inventory[i]}");
            }
        }

        private static void DisplayMenu()
        {
            Console.WriteLine("\nCOMMAND MENU");
            Console.WriteLine("menu - Display the menu");
            Console.WriteLine("show - Show all items");
            Console.WriteLine("grab - Grab an item");
            Console.WriteLine("edit - Edit an item");
            Console.WriteLine("drop - Drop an item");
            Console.WriteLine("exit - Exit program\n");
        }


        //GetString
        private static string GetString(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine().ToLower();
        }

        //GetInt
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
