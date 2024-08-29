using System;
using System.Transactions;

namespace Project_5_3
{
    internal class Program
    {
        public static int Random(int minVal, int MaxVal)
        {
            return new Random().Next(minVal, MaxVal);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Guess the Number Game");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("\nI'm thinking of a number from 1 to 100.");
            Console.WriteLine("Try to guess it.");


            //// user enters the nbr 

            // if the guessed nbr is higher than the random nbr "Too high!"
            // if the guessed nbr is lower than the random nbr "Too low!"
            // if the guessed nbr is more than 10 higher or 10 lower than the random nbr "Way too high!" or "Way too low!"

            // <=3           "Great work! You are a mathematical wizard."
            // > 3 and <= 7  "Not too bad! You've got some potential."
            // > 7           "What took you so long? Maybe you should take some lessons."

            // the app only accept between 1 and 100
            // if not, display an error msg

            // the app only accept y and n
            // if null, "Error! This entry is required. Try again."
            // if anything wrong, "Error! Entry must be 'y' or 'n'. Try again."
            
            
            string choice = "y";
            while (choice.ToLower() == "y")
            {
                int ranNum = Random(1, 101);
                Console.WriteLine($"random # is {ranNum}.");
                Console.Write("Enter number: ");
                int enterNum = Int32.Parse(Console.ReadLine());
                while (enterNum != ranNum)
                {
                    int count = 0;
                    Console.Write("Enter number: ");
                    enterNum = Int32.Parse(Console.ReadLine());
                    
                    if (enterNum == ranNum)
                    {                        
                        count++;
                        if (count == 1)
                        {
                            Console.WriteLine("You got it in 1 tries.");
                            Console.WriteLine("Great work! You are a mathematical wizard.");
                            break;
                        } else if (count > 1 && count <= 3)
                        {
                            Console.WriteLine("Great work! You are a mathematical wizard.");
                            break;
                        }
                    } 


                }         
                    

                    //int count = 1;
                    //Console.WriteLine($"random # is {ranNum}.");
                    //if (enterNum == ranNum)
                    //{
                    //    count += 1;
                    //    if (count > 7)
                    //    {
                    //        Console.WriteLine("What took you so long? Maybe you should take some lessons.");                            
                    //        break ;
                    //    } else if (count > 3 && count <= 7)
                    //    {
                    //        Console.WriteLine("Not too bad! You've got some potential.");
                    //        break ;
                    //    } else if (count > 1 && count <= 3)
                    //    {
                    //        Console.WriteLine("Great work! You are a mathematical wizard.");
                    //        break ;
                    //    } else if  (count == 1)
                    //    {
                    //        Console.WriteLine("You got it in 1 tries.");
                    //        Console.WriteLine("Great work! You are a mathematical wizard.");
                    //        break ;
                    //    }
                    //    break;
                    //}

                
                
                    //while (enterNum != ranNum)

                //count += 1;
                //Console.Write("Enter number: ");
                //int enterNum2 = Int32.Parse(Console.ReadLine());
                //Console.WriteLine($"random # is {ranNum}.");

                Console.WriteLine("Try again? (y/n)");
                choice = Console.ReadLine();
            }
        }


        //Console.WriteLine("You got it in 1 tries.");
        //Console.WriteLine("Great work! You are a mathematical wizard.");
        //Console.WriteLine("Great work! You are a mathematical wizard.");
        //Console.WriteLine("Not too bad! You've got some potential.");
        //Console.WriteLine("What took you so long? Maybe you should take some lessons.");



    }
}
