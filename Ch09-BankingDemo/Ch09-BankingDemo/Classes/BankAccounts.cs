namespace Ch09_BankingDemo.Classes
{
    abstract internal class BankAccount  // p. 482
    {
        // properties
        public int AccountNumber { get; set; }
        public string AccountName { get; set;}
        public int OwnersID { get; set;}
        public decimal Balance { get; set; }
        public decimal ClosingFee { get; set; }
        public string BranchManager { get; set; }

        abstract public void CloseAccount();
         
            // transfer remaining balance to Mike's account
            // send email
        
        
        

        // events
        // connect to external methods

    }

    class CheckingAccount : BankAccount  //Do not repeat yourself!!! -> then use "inheritance"!
    {
        // properties 
        public int LastCheckNumber { get; set; }

        public override void CloseAccount()
        {
            //TODO: write close code
            throw new NotImplementedException();
        }
    }

    class BusinessCheckingAccount : CheckingAccount
    {
        public string BusinessFedID { get; set; }
    }

    internal class SavingAccount : BankAccount 
    {
        // variables(non-visualble) = field (visuable)
        private decimal defaultInterestRate = .01m;

        int count = 0;

        // properties
        internal decimal InterestRate { get; set; }
        public string AccountType { get; set; }

        public override void CloseAccount()
        {
            throw new NotImplementedException();
        }
    }


    


}
