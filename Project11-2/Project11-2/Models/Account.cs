namespace Project11_2.Models
{
    // class Account  including 3 interfaces - Depositable, Withdrawable, Balaneable / an instance of the balance
    public class Account 
    {
        public decimal Balance { get; set; }

        public void deposit(decimal amount)
        {
            Balance += amount;
        }

        public void withdraw(decimal amount)
        {
            Balance -= amount;
        }

        // constructor
        public Account(decimal balance) 
        {
            this.Balance = balance;
        }

    }



    public interface IDepositable
    {
        void Deposit(decimal amount);
    }


    public interface IWithdrawable 
    {
        void Withdraw(decimal amount);
    }


    //public interface IBalanceable
    //{
    //    decimal GetBalance();
    //    void SetBalance(decimal amount);
    //}
    
}
