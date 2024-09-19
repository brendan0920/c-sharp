using PrsConsole_DEMO_0918.Db;
using PrsConsole_DEMO_0918.Models;
using System.ComponentModel.DataAnnotations;
using System.Runtime;

namespace PrsConsole_DEMO_0918
{
    internal class Program
    {

        private static UserDb userDb = new UserDb();
        private static VendorDb vendorDb = new VendorDb();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the PRS EF Console App");

            string command = "";
            while (command != "exit")
            {

                // DisplayMenu();

                switch (command)
                {
                    case "list users":
                        ListUsers();
                        break;
                    case "list vendors":
                        ListVendors();
                        break;
                    default:
                        Console.WriteLine("Please input valid command.");
                        break;
                }
            }

            Console.WriteLine("Bye");
        }

        // Get list of all users
        private static void ListUsers()
        {
            Console.WriteLine("\nAll Users");

            List<User> users = userDb.GetUsers();
            foreach (User user in users)
            {
                Console.WriteLine(user);
            }
        }



        private static void ListVendors() 
        {
            Console.WriteLine("\nAll Vendors");

            List<Vendor> vendors = vendorDb.GetVendors();
            foreach (Vendor vendor in vendors)
            {
                Console.WriteLine(vendor);
            }
        }



        private static string PromptInput(string input)
        {
            Console.Write(input);
            return Console.ReadLine();

        }
    }



}
