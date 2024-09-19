using SalesDatabaseEFConsole.Db;
using SalesDatabaseEFConsole.Models;

namespace SalesDatabaseEFConsole
{
    internal class Program
    {
        
        private static CustomerDb customerDb = new CustomerDb();
        private static RegionDb regionDb = new RegionDb();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Sales Manager Console App!");

            // Get list of all Customer

            Console.WriteLine("\nGet all Customers");
            List<Customer> customers = customerDb.GetCustomer();
            foreach(Customer customer in customers)
            {
                Console.WriteLine(customer);
            }

            // Get list of all Region

            Console.WriteLine("\nGet all Regions");
            List<Region> regions = regionDb.GetRegion();
            foreach(Region region in regions)
            {
                Console.WriteLine(region);
            }






            Console.WriteLine("\nBye");
        }
    }
}
