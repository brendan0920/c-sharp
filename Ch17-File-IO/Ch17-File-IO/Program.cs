﻿using Ch17_File_IO.Model;
using System.IO;

namespace Ch17_File_IO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the File Processing 101");

            /* Writing and reading a file of simple strings
            // p. 559 Creating a FileStream object for writing to a file
            string path = @"c:\files\Names.txt";
            //FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            //fs.Close();

            // p. 563 Write to a file
            StreamWriter textOut = new(new FileStream(path, FileMode.Create, FileAccess.Write));
            textOut.WriteLine("Brandon Moore");
            textOut.WriteLine("Sarika Srivastava");
            textOut.Close();

            // p 656 Read data from a text file
            StreamReader textIn = new(new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));
            String line = textIn.ReadLine();
            Console.WriteLine("Names:");
            while(line != null)
            {
                Console.WriteLine(line);
                line = textIn.ReadLine();
            }
            

            //Read and Write multiple fields per line
            //Create some instances of Products
            Product p1 = new Product("Java", "Mucrach's Java", 57.80m);
            Product p2 = new Product("C#", "Mucrach's Java", 59.90m);
            Product p3 = new Product("ANDR", "Mucrach's Java", 62.50m);
            List<Product> products = new List<Product>(); // <inside> - Generic type
            products.Add(p1);
            products.Add(p2);
            products.Add(p3);
            Console.WriteLine("Products: ");
            foreach (Product p in products)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();

            string path = @"c:\files\Products.txt";
            // 'using' will let C# auto close the file for us
            using StreamWriter textOut = new(new FileStream(path, FileMode.Create, FileAccess.Write));
            // parse fields from a product and write as separate fields to each line of a file
            foreach (Product p in products)
            {
                textOut.Write(p.Code + " | ");
                textOut.Write(p.Description + " | ");
                textOut.Write(p.Price);
            }

            */

            // Read Products.txt, parse rows into Products, add to a list, then print list to console
            string path = @"C:\files\Products.txt";
            List<Product> products = new List<Product>();
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

            Console.WriteLine("Products from file:");
            foreach (Product p in products)
            {
                Console.WriteLine(p);
            }


            Console.WriteLine("Bye!");



        }
    }
}
