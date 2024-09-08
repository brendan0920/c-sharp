using Ch09_BankingDemo.Classes;

namespace Ch09_BankingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //todo: add copyright message
            Console.WriteLine("Hello, World!");

            //BankAccount account = new BankAccount();
            //BankAccount account2 = new();
            //var account3 = new BankAccount();

            //account.OwnersID = 1;
            //account.Balance = 1000000;
            //account.AccountName = "Corporate 1";
            //account.AccountNumber = 1000;

            CheckingAccount ck1 = new();
            ck1.AccountNumber = 1234;
            ck1.OwnersID = 1;
            ck1.Balance = 1000;
            ck1.AccountName = "Toys";
            ck1.LastCheckNumber = 999;
            ck1.CloseAccount();

            SavingAccount sa1 = new();
            sa1.Balance = 10;
            sa1.AccountName = "Savings 1";
            sa1.OwnersID = 1;
            sa1.AccountNumber = 1234;
            sa1.CloseAccount();






        }
    }
}
