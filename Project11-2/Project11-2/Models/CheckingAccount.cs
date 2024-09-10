namespace Project11_2.Models
{
    // class CheckingAccount : Account / an instance of the monthly fee that’s initialized to the value that’s passed to the constructor
    // methods - account balance - SubstractMonthly fee  and return monthly fee

    public class CheckingAccount : Account //IDepositable, IWithdrawable
    {
        public decimal MonthlyFee { get; set; }


        // constructor
        public CheckingAccount(decimal balance, decimal monthlyFee) : base(balance)
        {
            //base.Balance = initialDeposit;
            this.MonthlyFee = monthlyFee;
        }

        // methods - account balance - SubstractMonthly fee  and return monthly fee
        public void SubtractMonthlyFee()
        {
            base.Balance -= MonthlyFee;
        }
        //public decimal GetMonthlyFee()
        //{
        //    MonthlyFee = Balance - monthlyFee;
        //    return MonthlyFee;
        //}



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
