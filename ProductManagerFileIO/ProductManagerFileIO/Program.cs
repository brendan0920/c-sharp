using ProductManagerFileIO.Model;

namespace ProductManagerFileIO
{
    internal class Program
    {
        static List<Product> products = new();
        
            // Declare file path for use later            
        static string path = @"c:\files\Names.txt";

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Product Manager App!");

            // LOAD PRODUCTS FROM FILE - into products list
            using StreamReader textIn = new(new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));
            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine() ?? "";
                string[] fields = row.Split('|');
                if (fields.Length == 3)
                {
                    string code = fields[0];
                    string desc = fields[1];
                    decimal price = Decimal.Parse(fields[2]);
                    Product p = new Product(code, desc, price);
                    products.Add(p);
                }
            }



            DisplayMenu();

            string command = "";
            while (command != "exit")
            {
                Console.Write("Command: ");
                command = Console.ReadLine();
                switch (command)
                {
                    case "list":
                        ListProducts();
                        break;
                    case "get":
                        GetProduct();
                        break;
                    case "add":
                        AddProduct();
                        break;
                    case "del":
                        DeleteProduct();
                        break;
                    case "menu":
                        DisplayMenu();
                        break;
                    case "exit":
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }

            Console.WriteLine("Bye");
        }
        static void ListProducts()
        {
            Console.WriteLine("\nProduct List:");
            Console.WriteLine("Method Not Yet Implemented");
        }

        static void GetProduct()
        {
            //Console.WriteLine("\nGet Product By Code:");
            //Console.WriteLine("Method Not Yet Implemented");

            // prompt user for code            
            // find product in list, by code
            string getProduct = GetString("\nGet Product By Code:");


            // display product
            Console.WriteLine($"Product - Code:{getProduct}, Desc:{}, Price: {}");

        }
        static void AddProduct()
        {
            // prompt user for code, desc, price
            Console.WriteLine("\nAdd a New Product for code, desc and price:");            
            // create new instance of product
            Product addProduct = new Product();
            // add product to list
            addProduct.Code = GetString("Enter a product code: ");
            addProduct.Description = GetString("Enter a product description: ");
            addProduct.Price = GetDecimal("Enter a product price: ", 0.0m, decimal.MaxValue);
            products.Add(addProduct);
            // SAVE PRODUCT FILE
            using StreamWriter textOut = new(new FileStream(path, FileMode.Create, FileAccess.Write));
            foreach (Product p in products)
            {
                textOut.Write(p.Code + " | ");
                textOut.Write(p.Description + " | ");
                textOut.Write(p.Price);
            }
        }

        static void DeleteProduct()
        {
            // prompt user for product code
            Console.WriteLine("\nDelete a Product By Code:");            

            // find product by code
            // if product does not exist, display message
            // if product exists, delete product and SAVE PRODUCT FILE
            //
        }

        static void DisplayMenu()
        {
            Console.WriteLine("\nMENU:");
            Console.WriteLine("list - list products");
            Console.WriteLine("add  - add a product");
            Console.WriteLine("get  - get a product by code");
            Console.WriteLine("del  - delete a product");
            Console.WriteLine("menu - display menu");
            Console.WriteLine("exit - exit app");
        }


        // NEW METHODS:
        // SAVE PRODUCT FILE
        // LOAD PRODUCTS FROM FILE


        //GetString
        private static string GetString(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine().ToLower();
        }

        private static string GetString(string prompt, string s1, string s2, string s3)
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
                else if (strValue != s1 && strValue != s2 && strValue != s3)
                {
                    Console.WriteLine($"Error: entry must be either '{s1}', '{s2}' or '{s3}'.");
                    continue;
                }
                else
                {
                    break;
                }
            }
            return strValue;
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


        
    }
}
