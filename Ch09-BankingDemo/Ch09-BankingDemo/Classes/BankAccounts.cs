namespace Ch09_BankingDemo.Classes
{
    abstract internal class BankAccount
    {
        // properties
        public int AccountNumber { get; set; }
        public string AccountName { get; set;}
        public int OwnersID { get; set;}
        public decimal Balance { get; set; }
        public string BranchManager { get; set; }
    }

    class CheckingAccount : BankAccount  //Do not repeat yourself!!! -> then use "inheritance"!
    {
        // properties 
        public int LastCheckNumber { get; set; }

    }

    class BusinessCheckingAccount : CheckingAccount
    {
        public string BusinessFedID { get; set; }
    }

    class SavingAccount : BankAccount 
    {
        // properties
        public decimal InterestRate { get; set; }
        public string AccountType { get; set; }
    }



}
