using MurachProductManager.Models;

namespace MurachProductManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Product Manager!");

            Console.WriteLine("\n======= Product =======");
            Product p1 = new Product();
            p1.Id = 1;
            p1.Code = "C#";
            p1.Description = "Murach's C#";
            p1.Price = 59.5m;
            Console.WriteLine(p1.Id);
            Console.WriteLine(p1.Code);
            Console.WriteLine(p1.Description);
            Console.WriteLine(p1.Price);
            Console.WriteLine(p1);

            Product p2 = new Product(2, "Java", "Murach's Java", 57.5m);
            // Using the override string method
            Console.WriteLine(p2);

            Console.WriteLine("\n======= Book =======");
            Book b1 = new Book(3, "mysql", "Murach's MySQL", 54.25m, "Joel Murach");
            Console.WriteLine(b1);

            Console.WriteLine("\n======= Software =======");
            Software s1 = new Software(4, "vsc", "VS Code", 0.0m, "v1.93");
            Console.WriteLine(s1);

            Console.WriteLine("\n======= List of Products =======");
            List<Product> productsList = new List<Product> { p1, p2, b1, s1};

            PrintProducts(productsList);


            Console.WriteLine("Bye!");
        }


        private static void PrintProducts(List<Product> products)
        {
            foreach (Product product in products) 
            {
                //Console.WriteLine(product);
                product.IPrintToWeb();
                
            }
        }
    }
}
