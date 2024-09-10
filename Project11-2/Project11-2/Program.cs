using Project11_2.Models;
using System.Transactions;

namespace Project11_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Account application");

            // class AccountBalanceApp that uses these objects to process and display deposits and withdrawals
            // Don’t allow the user to withdraw more than the current balance of an account.


            Console.WriteLine("Starting Balance");
            // display chk & sav balances

            CheckingAccount ck1 = new CheckingAccount(1000.00m, 1m);
            SavingsAccount sv1 = new SavingsAccount(1000.00m, 0.01);
            Console.WriteLine($"checking: ${ck1.Balance:c}");
            Console.WriteLine($"Savigns: ${sv1.Balance:c}");


            //enter the transactions
            Console.WriteLine("\nEnter the transactions for the month\n");

            string choice = "y";
            while (choice == "y")
            {

                string transaction = GetString("Withdrawal or deposit? (w/d): ", "w","d");
                string accountType = GetString("Checking or savings? (c/s): ", "c", "s");
                
                Account selectedAccount = null;
                decimal maxAmount = Decimal.MaxValue;
                decimal minAmount = 0.01m;

                if(accountType == "c")
                {
                    selectedAccount = ck1;
                } else
                {
                    selectedAccount = sv1;
                }

                if (transaction == "w" && selectedAccount.Balance <= 0) 
                {
                    Console.WriteLine("$0 accoutn balance");
                    continue;
                } 
                else if (transaction == "w")
                {
                    maxAmount = selectedAccount.Balance;
                } 
                

                // withdrawal * don't allow withdrawal of > acct balance
                // withdrawal * if balance <= 0, don't allow withdrawal.
                //              else min is .01, max = balance
                // deposit * min is .01, max = infinity
                decimal amount = GetDecimal("Amount?: ", 0.01m, Decimal.MaxValue);
                // adjust balance
                if (transaction == "w")
                {
                    selectedAccount.withdraw(amount);
                } else
                {
                    selectedAccount.deposit(amount);
                }


                choice = GetString("Continue? (y/n) : ", "y", "n");
            }


            // display monthly payment and fees
            sv1.ApplyPayment();
            ck1.SubtractMonthlyFee();
            
            Console.WriteLine("\nMonthly Payments and Fees");
            Console.WriteLine($"Checking fee:             {ck1.MonthlyFee:c}");
            Console.WriteLine($"Savings interest payment: {sv1.MonInterestPayment:c}");
            
            // display ending balance
            Console.WriteLine("\nFinal Balances");
            Console.WriteLine($"Checking: {ck1.Balance:c}");
            Console.WriteLine($"Savings: {sv1.Balance:c}");


            Console.WriteLine("Bye!");
        }


        private static void DisplayBalances(CheckingAccount ck1, SavingsAccount sv1)
        {
            Console.WriteLine($"Checking: {ck1.Balance:c}");
            Console.WriteLine($"Savings: {sv1.Balance:c}");
        }

        // GetString
        private static string GetString(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine().ToLower();
        }

        private static string GetString(string prompt, string s1, string s2)
        {
            string strValue = "";
            Boolean isValid = false;
            while (!isValid)
            {
                Console.Write(prompt);
                strValue = Console.ReadLine().ToLower();
                if (strValue == "")
                {
                    Console.WriteLine("Error: entry is required.");
                    continue;
                }
                else if (strValue != s1 && strValue != s2)
                {
                    Console.WriteLine($"Error: entry must be either '{s1}' or '{s2}'.");
                    continue;
                }
                else
                {
                    break;
                }
            }
            return strValue;
        }

        //GetInt
        private static int GetInt(string prompt, int min, int max)
        {
            int number = 0;
            Boolean isValid = false;
            while (!isValid)
            {
                try
                {
                    Console.Write(prompt);
                    number = Int32.Parse(Console.ReadLine());
                    if (number < min)
                    {
                        Console.WriteLine($"Invalid entry: number less than min ({min})");
                        continue;
                    }
                    else if (number > max)
                    {
                        Console.WriteLine($"Invalid entry: number greater than max ({max})");
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid entry: please enter a valid integer.");
                    continue;
                }
            }
            return number;
        }

        
        private static decimal GetDecimal(string prompt, decimal min, decimal max)
        {
            decimal number = 0.0m;
            Boolean isValid = false;

            while (!isValid)
            {
                Console.Write(prompt);
                Boolean success = decimal.TryParse(Console.ReadLine(), out number);
                if (!success)
                {
                    Console.WriteLine("Invalid entry: please enter a valid decimal.");
                }
                else
                {
                    if (number < min)
                    {
                        Console.WriteLine($"Invalid entry: number less than min ({min})");
                        continue;
                    }
                    else if (number > max)
                    {
                        Console.WriteLine($"Invalid entry: number greater than max ({max})");
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return number;
        }
            
    }
}
