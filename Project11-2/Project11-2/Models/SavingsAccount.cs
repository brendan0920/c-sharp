namespace Project11_2.Models
{
    // class SavingsAccount : Account / an instance of the monthly interest rate and monthly interest payment
    //      The monthly interest rate should be initialized to the value that’s passed to the constructor.
    //      The monthly interest payment should be calculated by a method that applies the payment to the account balance
    //      a method that returns the monthly interest payment
    public class SavingsAccount : Account //IDepositable, IWithdrawable
    {
        public double MonInterestRate { get; set; }
        public decimal MonInterestPayment { get; set; }


        // constructor
        public SavingsAccount(decimal balance, double monInterestRate) : base(balance)
        {
            this.MonInterestRate = monInterestRate;
            //base.Balance = initialBalance;
        }

        public void ApplyPayment()
        {
            // 1. Calculate MonthlyInterstPayment = balance * MonthlyInterstRate
            // 2. Set MonthlyInterstPayment
            // 3. Set base.Balance += MonthlyInterstPayment
            MonInterestPayment = base.Balance * (decimal)MonInterestRate;
            base.Balance += MonInterestPayment;
        }


        //public void Deposit(decimal amount)
        //{

        //}

        //public void Withdraw(decimal amount)
        //{

        //}

        //public decimal GetBalance()
        //{
        //    return GetBalance();
        //}

        //public void SetBalance(decimal amount)
        //{

        //}



        


    }
}
