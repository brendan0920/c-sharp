using System.Diagnostics;

namespace Ch12_Clasees_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Appliance a1 = new Appliance();
            a1.Id = 1;
            a1.Name = "QLED 69inch TV";
            a1.Price = 599.99m;
            a1.Brands = "Samsung";
            a1.Description = "5k QLED high resolution";
            
            PrintLabel(a1);


            Stove s1 = new Stove();
            s1.Id = 2;

            PrintLabel(s1);


            TV tv1 = new TV();
            tv1.Id = 3;

            PrintLabel(tv1);


            Computers com1 = new Computers();
            com1.Id = 4;

            PrintLabel(com1);


            Toys toy1 = new Toys();
            toy1.Id = 5;

            PrintLabel(toy1);


            Product[] AllProduct = {a1, s1, tv1, com1, toy1};
            foreach (Product p in AllProduct) {
                Console.WriteLine(p);
            }


        }


        static void PrintLabel(Product p)
        {
            Console.WriteLine($"{p.Id}, {p.Name}, {p.Price}, {p.Brands}, {p.Description}");
        }
    }
}
