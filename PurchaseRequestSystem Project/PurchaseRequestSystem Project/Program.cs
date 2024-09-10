using PurchaseRequestSystem_Project.Models;

namespace PurchaseRequestSystem_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Purchase Request System Console App!");


            User u1 = new User(1, "bkeam", "bk1234", "Brendan", "Keam", "917-624-6069", "brdk1220@gmail.com", true, true);
            User u2 = new User(2, "mdamon", "md1234", "Matt", "Damon", "202-456-8975", "mdamon@gmail.com", false, false);
            User u3 = new User(3, "cbale", "cb1234", "Christian", "Bale", "202-547-7783", "cbale@gmail.com", false, false);
            User u4 = new User(4, "baffleck", "bf1234", "Ben", "Affleck", "917-554-8521", "baffleck@gmail.com", false, false);
            User u5 = new User(5, "Rmcadams", "rm1234", "Rachel", "McAdams", "917-889-6325", "rmcadams@gmail.com", false, false);

            Vendor v1 = new Vendor(1, "P001", "Baldor Specialty Foods", "55 Food Center Dr", "Bronx", "NY", 10474, "718-860-9000", "info@baldorfood.com");
            Vendor v2 = new Vendor(2, "P002", "D’Artagnan", "600 Green Ln", "Union", "NJ", 07083, "877-858-0099", "orders@dartagnan.com");
            Vendor v3 = new Vendor(3, "P003", "The Chefs' Warehouse", "240 Food Center Dr", "Bronx", "NY", 10474, "800-878-3247", "chef@chefswarehouse.com");
            Vendor v4 = new Vendor(4, "P004", "Gourmet Foods International", "38 Fairfield Place", "West Caldwell", "NJ", 07006, "973-487-3980", "info@gfifoods.com");
            Vendor v5 = new Vendor(5, "P005", "Cipriani", "376 West Broadway", "New York", "NY", 10012, "212-343-0999", "downtown@cipriani.com");
            Vendor v6 = new Vendor(6, "P006", "Murray’s Cheese", "254 Bleecker St", "New York", "NY", 10014, "212-243-3289", "orders@murrayscheese.com");

            Console.WriteLine("Users:");
            Console.WriteLine(u1);
            Console.WriteLine(u2);

            Request req1 = new Request(1, u1, "R0001", "Need new supplies for mydesk.", "Need this for my work.", new DateOnly(2024, 9, 17), "Pick-up", "NEW", 0.0m, DateTime.Now, null);
            Console.WriteLine("Request:");
            Console.WriteLine(req1);



        }
    }
}
