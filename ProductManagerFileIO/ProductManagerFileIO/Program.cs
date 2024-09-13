using ProductManagerFileIO.Model;
using System.Diagnostics;
using System.IO;
using System.IO.Pipes;

namespace ProductManagerFileIO
{
    internal class Program
    {
        static List<Product> products = new();
        
            // Declare file path for use later            
        static string path = @"c:\files\Products.txt";

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Product Manager App!");

            // LOAD PRODUCTS FROM FILE - into products list
            LoadProducts();

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
            
            // do biz
            foreach (Product product in products)
            {
                Console.WriteLine(product);
                Console.WriteLine();
            }


        }

        static void GetProduct()
        {
            Console.WriteLine("\nGet Product By Code:");
            // prompt user for code            
            string code = GetString("\nEnter Code:");
            // find product in list, by code
            Product pdt = null;
            foreach(Product product in products)
            {
                if (product.Code == code)
                {
                    pdt = product;
                }
            }
            // display product
            if (pdt != null)
            {
                Console.WriteLine(pdt);
            }else
            {
                Console.WriteLine($"Product for code: {code} not found. ");
            }


        }
        static void AddProduct()
        {
            // prompt user for code, desc, price
            Console.WriteLine("\nAdd a New Product for code, desc and price:");            
            // add product to list
            string code = GetString("Enter a product code: ");
            string description = GetString("Enter a product description: ");
            decimal price = GetDecimal("Enter a product price: ", 0.0m, decimal.MaxValue);
            // create new instance of product
            Product p = new Product(code, description, price);
            products.Add(p);
            // SAVE PRODUCT FILE
            SaveProducts();
            Console.WriteLine($"Product {code} added!\n");
            
        }

        static void DeleteProduct()
        {
            // prompt user for product code
            Console.WriteLine("\nDelete a Product By Code:");
            // prompt user for code            
            string code = GetString("\nEnter Code:");
            // find product in list, by code
            Product pdt = null;
            foreach (Product product in products)
            {
                if (product.Code == code)
                {
                    pdt = product;
                }
            }            
            // if product exists, delete product 
            if(pdt != null)
            {
                products.Remove(pdt);
                
                //SAVE PRODUCT FILE
                SaveProducts();

                Console.WriteLine($"Product {code} removed.\n");
            }
            else
            {
                Console.WriteLine($"No Product for code {code} exists. \n");
            }


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

        //  1. SAVE PRODUCT FILE : save our list of products in the products.txt file
        private static void SaveProducts()
        {
        // create a StreamWriter to access fhte file for writing
            using StreamWriter productsWriter = new(new FileStream(path, FileMode.Create, FileAccess.Write));
        // loop through the products list
            foreach (Product product in products)
            {
        // - streamwriter.write each field separated by '|', then end with a newline
                productsWriter.WriteLine($"{product.Code}|{product.Description}|{product.Price}");                
            }
        }





        //  2. LOAD PRODUCTS FROM FILE        
        private static void LoadProducts()
        {
            // create a StreamReader to access the file
            using StreamReader productsReader = new(new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));
            // read the lines from the file
            while (productsReader.Peek() != -1)
            {
            // parse the fields from each line into a Product
            // add the Product to the products list
                string row = productsReader.ReadLine() ?? "";
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
        }



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
