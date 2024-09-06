using Ch09_BankingDemo.Classes;

namespace Ch09_BankingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //BankAccount account = new BankAccount();
            //BankAccount account2 = new();
            //var account3 = new BankAccount();

            //account.OwnersID = 1;
            //account.Balance = 1000000;
            //account.AccountName = "Corporate 1";
            //account.AccountNumber = 1000;

            CheckingAccount chk1 = new();
            chk1.AccountNumber = 1234;
            chk1.OwnersID = 1;
            chk1.Balance = 1000;
            chk1.AccountName = "Toys";
            chk1.LastCheckNumber = 999;

            SavingAccount sa1 = new();
            sa1.Balance = 10;
            sa1.AccountName = "Savings 1";
            sa1.OwnersID = 1;
            sa1.AccountNumber = 1234;







        }
    }
}
