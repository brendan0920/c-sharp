namespace Ch12_Classes_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // define a class
            // use the class
            int number = 5;

            // define a Product named 'p1' and assign values...
            Product p1 = new Product();
            p1.Code = "c#";
            p1.Description = "Murach's c# Programing";
            p1.Price = 57.5m;

            Console.WriteLine($"number: {number}");
            Console.WriteLine($"p1: {p1}");
            Console.WriteLine($"p1 properties: code - {p1.Code} - description - {p1.Description}, price - {p1.Price}");

            p1.Price = 49.99m;
            Console.WriteLine($"p1 properties: code - {p1.Code} - description - {p1.Description}, price - {p1.Price}");

            // using constructor to pass parameters
            Product p2 = new Product("Java", "Murach's Jave programming", 59.50m);

            Product p3 = new Product("andr", "Murach's Jave programming", 62.50m);
            //Console.WriteLine(p3.GetDetails());

            //inheritance
            Console.WriteLine("pass p1 directly to WriteLine: " + p1.ToString());
            //by defailt, ToString is applied witout the its keyword
            Console.WriteLine(p1);

            List<Product> products = new List<Product>();

            products.Add(p1);
            products.Add(p2);
            products.Add(p3);

            Console.WriteLine("List of Products:");
            foreach (Product p in products)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("Find a prodct by code: ");
            Console.Write("Enter code to find: ");
            string code = Console.ReadLine();

            Product foundProduct = null;
            foreach (Product p in products)
            {
                if (p.Code == code)
                {
                    foundProduct = p;
                    break;
                }
            }

            if (foundProduct != null)
            {
                Console.WriteLine($"Found Product: {foundProduct}");
            } else
            {
                Console.WriteLine($"No product found for code: '{code}'");
            }
            
            //Console.WriteLine($"object count: {Product.ObjectCount}");




        }
    }
}
